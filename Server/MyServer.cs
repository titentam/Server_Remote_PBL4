using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class MyServer
    {
        private TcpListener server;
        private int port;
        private bool isListening;
        private ArrayList handlers;

        public MyServer(int port)
        {
            this.port = port;
            handlers = new ArrayList();
        }

        public void Start()
        {
            server = new TcpListener(IPAddress.Any,port);
            server.Start();
            isListening = true;
            while (isListening)
            {
                var client = server.AcceptTcpClient();
                var clientHandler = new ClientHandler(client);
                handlers.Add(clientHandler);
                clientHandler.Start();
            }

        }

        public void Stop()
        {
           for (int i = 0; i < handlers.Count; i++)
            {
                var handler = (ClientHandler)handlers[i];
                handler.Stop();
            }
           server.Stop();
        }

    }
}
