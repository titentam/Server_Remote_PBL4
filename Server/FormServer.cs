using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FormServer : Form
    {
        private MyServer server;
        private TcpListener chatServer;
        private TcpClient chatClient;
        private NetworkStream chatClientStream;
        private Thread chatListenerThread;
        public event Action<string> MessageReceived;
        private ChatForm chatForm;
        public bool isChatConnected;
        public FormServer()
        {
            InitializeComponent();
            Init();
           
        }
        public void StartChat()
        {
            chatServer = new TcpListener(IPAddress.Any, 6966);
            chatServer.Start();
            Thread t = new Thread(() =>
            {


                chatClient = chatServer.AcceptTcpClient();
                chatClientStream = chatClient.GetStream();

                chatListenerThread = new Thread(new ThreadStart(ListenForMessages));
                chatListenerThread.Start();

            });
            t.Start();
        }
        private void ListenForMessages()
        {
            while (isChatConnected)
            {
                try
                {
                    byte[] message = new byte[4096];
                    int bytesRead;

                    try
                    {
                        bytesRead = chatClientStream.Read(message, 0, 4096);
                    }
                    catch
                    {
                        break;
                    }

                    if (bytesRead == 0)
                        break;

                    string receivedMessage = Encoding.ASCII.GetString(message, 0, bytesRead);
                    if (receivedMessage != null)
                    {
                        // Gọi sự kiện để thông báo về tin nhắn mới
                        MessageReceived?.Invoke(receivedMessage);
                    }
                    //DisplayMessage("Client: " + receivedMessage);


                }
                catch (Exception ex)
                {
                    isChatConnected=false;
                    this.StopChat();
                    break;
                }
            }
        }
        private void StopChat()
        {
            isChatConnected = false;

            // Thực hiện đóng kết nối
            if (chatClient.Connected)
            {
                chatClient.Close();
            }
            if (chatServer != null)
            {
                chatServer.Stop();
            }
        }

        private void OnMessageReceived(string message = null)
        {
            // Kiểm tra xem ChatForm đã được tạo chưa
            if (chatForm == null || chatForm.IsDisposed)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    // Nếu chưa, tạo một instance mới của ChatForm
                    chatForm = new ChatForm(chatClientStream);
                    chatForm.Show();
                    if (message!= null)
                    {
                        chatForm.DisplayMessage("Client: "+message);
                    }
                });
                
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    chatForm.DisplayMessage("Client: "+message);
                });
                // Nếu đã tạo, thêm tin nhắn mới vào ChatForm hiện tại
               
            }
        }

        private void Init() 
        {
            btnListen.Enabled = true;   
            btnStop.Enabled = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            btnChat.Enabled = false;

            swSpeaker.Enabled = false;
            swVoice.Enabled = false;
            swVoice.Active = false;
            swSpeaker.Active = false;

        }

        
        private void btnListen_Click(object sender, EventArgs e)
        {
            btnListen.Enabled = false;
            btnStop.Enabled = true;
            swSpeaker.Enabled = true;
            swVoice.Enabled = true;
            btnChat.Enabled = true;
            MessageBox.Show("Server is listening!");

            string pass = txtPassword.Text;

            server = new MyServer(5910, pass);
            Thread t = new Thread(() =>
            {
                server.Start();
            });

            t.Start();
            MessageReceived += OnMessageReceived;
            StartChat();
            isChatConnected = true;
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            OnMessageReceived();
        }

        private void swVoice_ValueChanged(object sender, bool value)
        {
            var client = server.GetClientHandler();
            if (client != null)
            {
                if (swVoice.Active)
                {
                    client.VoiceRecorder();
                }
                else
                {
                    client.VoiceStop();
                }
            }
            
        }

        

        private void swSpeaker_ValueChanged(object sender, bool value)
        {
            var client = server.GetClientHandler();
            if (client != null)
            {
                if (swSpeaker.Active)
                {
                    client.ReceiveVoice();
                }
                else
                {
                    client.StopReceiveVoice();
                }
            }
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Init();
            StopChat();

            MessageBox.Show("Server is stopped!");
            server.Stop();
        }

        
    }
}
