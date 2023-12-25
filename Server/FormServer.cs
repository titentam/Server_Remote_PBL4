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
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            ChatForm chatForm = new ChatForm();
            chatForm.StartChat();
            chatForm.Show();
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


            MessageBox.Show("Server is stopped!");
            server.Stop();
        }

        
    }
}
