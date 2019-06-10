using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace tcp_android
{
    public partial class Form1 : Form
    {
        public static asClient asClientForm = new asClient();
        public static asServer asServerForm = new asServer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_asClient_Click(object sender, EventArgs e)
        {
            asClientForm.Show();
            this.Hide();
        }

        private void Button_asServer_Click(object sender, EventArgs e)
        {
            asServerForm.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
