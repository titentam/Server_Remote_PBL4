using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class ChatFormServer : Form
    {
        public Action<string> SendMessage;
        public ChatFormServer()
        {
            InitializeComponent();
            

        }

        public void DisplayMessage(string message)
        {

            if (chatArea.IsHandleCreated)
            {
                chatArea.Invoke(new Action(() =>
                {
                    chatArea.AppendText(message + "\n");
                }));
            }
            else
            {
                // dosomething
            }
            
        }


        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            string message = chatTxt.Text;
            DisplayMessage("Me: " + message);
            SendMessage.Invoke(message); // send to client
            chatTxt.Clear();
        }

       
    }
}
