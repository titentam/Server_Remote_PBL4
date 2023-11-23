using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class ChatForm : Form
    {
        private static ChatForm instance;

        public delegate void SendMessageDelegate(string message);
        public SendMessageDelegate SendMessage;


        public static ChatForm Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChatForm();
                return instance;
            }
        }

        private ChatForm()
        {
            InitializeComponent();
        }

        public void DisplayMessage(string message)
        {

            chatArea.AppendText(message + Environment.NewLine);
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            string message = chatTxt.Text;
            SendMessage(message);
            chatTxt.Clear();
        }
    }
}
