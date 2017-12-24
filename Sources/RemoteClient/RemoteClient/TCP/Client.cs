using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace RemoteClient.TCP
{
    class Client
    {
        private TcpClient tcp_client = null;

        public class ServerTimedOutException : Exception
        {
            public ServerTimedOutException()
            {
            }
        }

        public Client(string IP_Address, int Port, int SetContinue = -1)
        {
            int continueNumber = 0;
            bool connectedServer = false;
            do
            {
                tcp_client = new TcpClient();
                var result = tcp_client.BeginConnect(IP_Address, Port, null, null);
                connectedServer = result.AsyncWaitHandle.WaitOne(TimeSpan.FromMilliseconds(1000));

                if (connectedServer)
                {
                    Console.WriteLine("Connected");
                    break;
                }
                else
                {
                    Console.WriteLine("Failed: " + Port.ToString());
                    continueNumber++;
                }
            } while (SetContinue == -1 | continueNumber < SetContinue);

            if (!connectedServer) throw new ServerTimedOutException();
        }

        public class TimeoutException : Exception
        {
            public TimeoutException(string Message) { }
        }

        public class HostDisconnected : Exception
        {
            public HostDisconnected(string Message) { } 
        }

        public string GetServerIP 
        {
            get { return ((IPEndPoint)tcp_client.Client.RemoteEndPoint).Address.ToString(); }
        }

        public int SetBufferSize
        {
            set
            {
                tcp_client.ReceiveBufferSize = value;
                tcp_client.SendBufferSize = value;
            }
        }

        public void Send(string SendData, int Timeout_ms = -1)
        {
            Send(Encoding.UTF8.GetBytes(SendData), Timeout_ms);
        }

        public void Send(byte[] SendData, int Timeout_ms = -1)
        {
            NetworkStream ns = tcp_client.GetStream();
            ns.WriteTimeout = Timeout_ms;
            ns.Write(SendData, 0, SendData.Length);
            SendData = null;
            GC.Collect();
        }

        public string RecvString(int Timeout_ms = -1, int Buffer = 1024 * 1024 * 10)
        {
            byte[] raw_data = RecvBytes(Timeout_ms, Buffer);
            return Encoding.UTF8.GetString(raw_data, 0, raw_data.Length).Replace("\0", "");
        }

        public byte[] RecvBytes(int Timeout_ms = -1, int Buffer = 1024 * 1024 * 10)
        {           
            NetworkStream ns = tcp_client.GetStream();
            ns.ReadTimeout = Timeout_ms;
            MemoryStream ms = new MemoryStream();
            byte[] resBytes = new byte[Buffer];
            int resSize = 0;
            do
            {
                resSize = ns.Read(resBytes, 0, resBytes.Length);
                if (resSize == 0)
                {
                    break;
                }
                ms.Write(resBytes, 0, resSize);
            } while (ns.DataAvailable);
            resBytes = null;
            GC.Collect();

            return ms.GetBuffer();
        }


        public void Close()
        {
            if (tcp_client != null)
            {
                if (tcp_client.Connected)
                {
                    tcp_client.GetStream().Dispose();
                    tcp_client.Close();
                }
            }           
            tcp_client = null;
            GC.Collect();
        }
    }
}
