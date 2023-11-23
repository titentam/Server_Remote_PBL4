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

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
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

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton2_Click_1(object sender, EventArgs e)
        {
            ChatForm chatForm = new ChatForm();
            chatForm.StartChat();
            chatForm.Show();
        }

        private void uiRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
