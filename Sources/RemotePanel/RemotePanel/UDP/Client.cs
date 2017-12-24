using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace RemotePanel.UDP
{
    class Client
    {
        private UdpClient udp_client;

        public Client(string IP_Address, int Port)
        {
            IPEndPoint ipAddr = new IPEndPoint(IPAddress.Parse(IP_Address), Port);
            udp_client = new UdpClient(ipAddr);
        }

        public string RecvString()
        {
            return Encoding.UTF8.GetString(RecvBytes());
        }

        public byte[] RecvBytes()
        {
            IPEndPoint remoteEP = null;
            return udp_client.Receive(ref remoteEP);
        }

        public void Send(string SendData)
        {
            Send(Encoding.UTF8.GetBytes(SendData));
        }

        public void Send(byte[] SendData)
        {
            udp_client.Send(SendData, SendData.Length);
        }

    }
}
