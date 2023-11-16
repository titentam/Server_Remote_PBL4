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
        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
