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
        public ChatFormServer chatForm;

        public Action ShowChatForm;
        public MyServer(int port, string passServer="")
        {
            this.port = port;
            handlers = new ArrayList();
            this.passServer = passServer;

            
        }
        public void InitChat()
        {
            chatForm = new ChatFormServer();
            chatForm.Show();
            chatForm.Visible = false;
            chatForm.SendMessage += SendMessage;


            var client = GetClientHandler();
            if (client == null) return;
            client.DisplayMessage += chatForm.DisplayMessage;
            

        }

        public void ShowChat()
        {
            if (chatForm == null || chatForm.IsDisposed)
            {
                ShowChatForm.Invoke();
            }
        }

        public void CloseChat()
        {
            if(chatForm!=null)
            {
                try
                {
                    chatForm.Invoke(new Action(() =>
                    {
                        chatForm.Dispose();
                    }));
                }
                catch (Exception)
                {

                    // do something;
                }
                
                
            }
        }

        public static string GetIp()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "";
        }

        public void Start()
        {

            server = new TcpListener(IPAddress.Any,port);
            server.Start();
            isListening = true;

            //InitChat();
            while (isListening)
            {
                try
                {
                    var client = server.AcceptTcpClient();
                    var clientHandler = new ClientHandler(client, passServer);

                    clientHandler.ShowChatForm += ShowChat;
                    clientHandler.CloseChatForm += CloseChat;



                    RemoveClient();
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
            if(chatForm != null)
            {
                chatForm.Dispose();
            }
          
            server.Stop();
        }

        public ClientHandler GetClientHandler()
        {
            if (handlers.Count == 0) return null;
            return (ClientHandler)handlers[0];
        }

        private void RemoveClient()
        {
            for(int i = 0;i < handlers.Count; i++)
            {
                var handler = (ClientHandler)handlers[i];
                if(!handler.isConnected)
                {
                    handlers.RemoveAt(i);
                }
            }
        }

        private void SendMessage(string message)
        {
            var client = GetClientHandler();
            if (client == null) return;
            client.SendMessage(message);
        }



    }
}
