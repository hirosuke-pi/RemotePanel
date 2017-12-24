using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace RemotePanel.TCP
{
    public class Server
    {

        private TcpListener listener = null;
        private TcpClient client = null;
        IPEndPoint ipAddr = null;

        public Server(int Port)
        {
            ipAddr = new IPEndPoint(IPAddress.Parse(GetLocalIP), Port);
            listener = new TcpListener(ipAddr);
        }

        public string GetClientIP
        {
            get { return ((System.Net.IPEndPoint)client.Client.RemoteEndPoint).Address.ToString(); }
        }

        public int SetBufferSize
        {
            set
            {
                client.ReceiveBufferSize = value;
                client.SendBufferSize = value;
            }
        }

        public static string GetLocalIP
        {
            get
            {
                String hostName = Dns.GetHostName();
                IPAddress[] addresses = Dns.GetHostAddresses(hostName);

                foreach (IPAddress address in addresses)
                {
                    // IPv4 のみを追加する
                    if (address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return address.ToString();
                    }
                }

                return "";
            }
        }

        public void Start()
        {

            listener.Start();
            while (true)
            {                
                client = listener.AcceptTcpClient();
                if (client.Connected)
                {
                    listener.Stop();
                    break;
                }
            }
        }

        public void Stop()
        {
            try
            {
                listener.Stop();
                client.GetStream().Dispose();
                client.Close();
                listener = null;
                client = null;               
            }
            catch
            { }
            GC.Collect();
        }

        public string RecvString(int Timeout_ms = 5000, int BufferSize = 1024 * 1024 * 10)
        {
            return Encoding.UTF8.GetString(RecvBytes(Timeout_ms, BufferSize)).Replace("\0", "");
        }

        public byte[] RecvBytes(int Timeout_ms = 5000, int BufferSize = 1024 * 1024 * 10)
        {
            NetworkStream ns = client.GetStream();
            ns.ReadTimeout = Timeout_ms;
            MemoryStream ms = new MemoryStream();
            byte[] resBytes = new byte[BufferSize];
            int resSize = 0;
            do
            {
                resSize = ns.Read(resBytes, 0, resBytes.Length);
                ms.Write(resBytes, 0, resSize);
            } while (resSize == 0);
            resBytes = null;
            GC.Collect();

            return ms.GetBuffer();
        }

        public void Send(string SendData, int Timeout_ms = 5000)
        {
            Send(Encoding.UTF8.GetBytes(SendData), Timeout_ms);
        }

        public void Send(byte[] SendData, int Timeout_ms = 5000)
        {
            client.SendBufferSize = SendData.Length;
            NetworkStream ns = client.GetStream();
            ns.WriteTimeout = Timeout_ms;
            ns.Write(SendData, 0, SendData.Length);
            SendData = null;
            GC.Collect();
        }
    }
}
