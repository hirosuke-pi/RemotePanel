using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace RemotePanel.UDP
{
    class Server
    {


        public Server(int Port)
        {
            IPEndPoint ipAddr = new IPEndPoint(IPAddress.Parse(Dns.GetHostAddresses(Dns.GetHostName())[0].ToString()), Port);

        }
    }
}
