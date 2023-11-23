using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FormServer : Form
    {
        private MyServer server;
        public FormServer()
        {
            InitializeComponent();
            
        }
        
        private void btnListen_Click(object sender, EventArgs e)
        {
            string pass = txtPassword.Text;

            server = new MyServer(5910, pass);
            Thread t = new Thread(() =>
            {
                server.Start();
            });

            t.Start();
            MessageBox.Show("Dang nghe");
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            ChatForm.Instance.SendMessage = server.GetClientHandler().SendMessage;
            ChatForm.Instance.Show();
        }

        private void swVoice_ValueChanged(object sender, bool value)
        {
            var client = server.GetClientHandler();
            if (swVoice.Active)
            {
                client.VoiceRecorder();
            }
            else
            {
                client.VoiceStop();
            }
        }

        private void swSpeaker_ValueChanged(object sender, bool value)
        {
            var client = server.GetClientHandler();
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
}
