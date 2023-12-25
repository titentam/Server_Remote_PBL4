using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class ChatForm : Form
    {
        private TcpListener server;
        private TcpClient client;
        private NetworkStream clientStream;
        private Thread listenerThread;

        public ChatForm()
        {
            InitializeComponent();

        }

        public void StartChat()
        {
            server = new TcpListener(IPAddress.Any, 6966);
            server.Start();

            client = server.AcceptTcpClient();
            clientStream = client.GetStream();

            listenerThread = new Thread(new ThreadStart(ListenForMessages));
            listenerThread.Start();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            chatArea.ReadOnly = true;
        }

        private void ListenForMessages()
        {
            while (true)
            {
                byte[] message = new byte[4096];
                int bytesRead;

                try
                {
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    break;
                }

                if (bytesRead == 0)
                    break;

                string receivedMessage = Encoding.ASCII.GetString(message, 0, bytesRead);
                DisplayMessage("Client: " + receivedMessage);
            }
        }

        private void DisplayMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(DisplayMessage), message);
                return;
            }

            chatArea.AppendText(message + Environment.NewLine);
        }

        private void SendMessage(string message)
        {
            byte[] messageBytes = Encoding.ASCII.GetBytes(message);
            clientStream.Write(messageBytes, 0, messageBytes.Length);
            DisplayMessage("You: " + message);
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            string message = chatTxt.Text;
            SendMessage(message);
            chatTxt.Clear();
        }
    }
}
