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
            Init();
        }

        private void Init() 
        {
            btnStop.Enabled = false;
            btnChat.Enabled = false;

        }
        
        private void btnListen_Click(object sender, EventArgs e)
        {
            btnListen.Enabled = false;
            btnStop.Enabled = true;
            this.Log("Server is listening!");

            string pass = txtPassword.Text;

            server = new MyServer(5910, pass);
            Thread t = new Thread(() =>
            {
                server.Start();
            });

            t.Start();
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

        public void Log(string log)
        {
            txtaLog.AppendText(log+"\n");
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

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnListen.Enabled = true;
            btnStop.Enabled = false;
            this.Log("Server is stopped!");

            server.Stop();
        }

        
    }
}
