using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; // for ipaddress stuff
using System.Net.Sockets; // for tcp comm.
using System.Threading; // for thread


namespace tcp_android
{
    public partial class asClient : Form
    {
        public static TcpClient client;
        public static IPEndPoint server_IPendpoint = new IPEndPoint(IPAddress.Parse("10.0.2.117"), 2500); // ipendpoint for client to connect
        public static NetworkStream stream_client = null;

        public static Thread thread_Read = new Thread(new ThreadStart(read)); 
        public static EventWaitHandle ewh = new EventWaitHandle(false, EventResetMode.ManualReset);
        bool clientStatus = false; //false = not connected

        public asClient()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            thread_Read.Start(); // reading started but it waits the button to set the ewh
        }


        //starting connection
        private void Button_connect_Click(object sender, EventArgs e)
        {
            Button thisButton = sender as Button;
            if (clientStatus == false)
            {
                this.listBox1.Items.Add("Trying connecting...");
                client = new TcpClient();// we are creating new instance because we want to reset the connection
                client.Connect(server_IPendpoint); // connected server
                if (client.Connected == true)
                {
                    this.listBox1.Items.Add("Connected to server...");
                }
                else
                {
                    this.listBox1.Items.Add("Connection failed. Try again.");
                    return;
                }
                stream_client = client.GetStream(); // gathered stream
                Form1.asClientForm.listBox1.Items.Add("Starts reading...");
                ewh.Set(); // thread continues
                thisButton.Text = "STOP";
                clientStatus = true;
            }
            else
            {
                ewh.Reset();
                client.Client.Shutdown(SocketShutdown.Both);
                client.Client.Close(); // socket closes
                clientStatus = false;
                thisButton.Text = "CONNECT";
            }

            
        }

        //reading function
        public static void read()
        { // reading
            while (true)
            {
                try
                {
                    ewh.WaitOne();
                    if (stream_client.DataAvailable)
                    {
                        byte[] item = new byte[client.ReceiveBufferSize];
                        stream_client.Read(item, 0, item.Length);
                        Form1.asClientForm.listBox1.Items.Add(Encoding.ASCII.GetString(item, 0, item.Length));
                    }
                }
                catch (SocketException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //data send function
        private void Button_send_Click(object sender, EventArgs e)
        {
            if (client.Connected == false) // connected değilse olmalı
                MessageBox.Show("You neeed to connect first.");
            else
                stream_client.Write(Encoding.ASCII.GetBytes(this.textBox1.Text), 0, Encoding.ASCII.GetBytes(this.textBox1.Text).Length);
        }

        private void AsClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainForm.Show();
        }
    }
}
