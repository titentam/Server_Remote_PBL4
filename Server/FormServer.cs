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
            server = new MyServer(5910);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() =>
            {
                server.Start();
            });
            label1.Text = "Is Listening";

            t.Start();
            
        }
    }
}
