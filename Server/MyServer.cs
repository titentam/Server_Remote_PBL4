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
        private string passServer;

        public MyServer(int port, string passServer="")
        {
            this.port = port;
            handlers = new ArrayList();
            this.passServer = passServer;
        }

        public void Start()
        {

            server = new TcpListener(IPAddress.Any,port);
            server.Start();
            isListening = true;
            while (isListening)
            {
                try
                {
                    var client = server.AcceptTcpClient();
                    var clientHandler = new ClientHandler(client, passServer);
                    handlers.Add(clientHandler);
                    clientHandler.Start();
                }
                catch (SocketException) 
                {
                    break;
                }
                
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

        public ClientHandler GetClientHandler()
        {
            if (handlers.Count == 0) return null;
            return (ClientHandler)handlers[0];
        }

    }
}
