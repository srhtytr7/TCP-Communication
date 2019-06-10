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
    public partial class asServer : Form
    {
        public static TcpListener server = new TcpListener(IPAddress.Any, 2500); // server listens to any ipaddress and it listens port number 2500
        public static TcpClient acceptedClient = null;
        public static NetworkStream stream_server = null;
        public static Thread thread_Receive = new Thread(new ThreadStart(read));
        public static Thread thread_Connect;// = new Thread(new ThreadStart(connect));
        public static EventWaitHandle ewh = new EventWaitHandle(false, EventResetMode.ManualReset);
        bool serverStatus = false; // false=stopped, true=started

        public asServer()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            thread_Receive.Start(); //ewh controls the thread so we can start it whereever we want.
        }

        //server starting
        private void Button_server_start_Click(object sender, EventArgs e)
        {
            Button thisButton = sender as Button;
            if (serverStatus == false)
            {
                server.Start(); // server started
                thread_Connect = new Thread(new ThreadStart(connect));
                thread_Connect.Start(); // connect thread started

                this.listBox1.Items.Add("Server started and listening...");
                thisButton.Text = "STOP SERVER";
                serverStatus = true;
            }
            else
            {
                server.Stop(); // server stopped. we need to stop it to not listen.
                ewh.Reset();// reading stopped

                this.listBox1.Items.Add("Server stopped...");
                thisButton.Text = "START SERVER";
                serverStatus = false;
            }
            
        }
        // accepting a client
        public static void connect()
        {
            Form1.asServerForm.listBox1.Items.Add("Waiting for a client...");
            acceptedClient = server.AcceptTcpClient(); // accepted a client
            Form1.asServerForm.listBox1.Items.Add("Connected to " + acceptedClient.Client.RemoteEndPoint.ToString());
            stream_server = acceptedClient.GetStream(); // gets the stream
            Form1.asServerForm.listBox1.Items.Add("Waiting for messages");
            ewh.Set();// allows read thread to work ( started reading )
            
        }
        // starts reading from accepted client
        public static void read()
        { // reading
            while (true)
            {
                try
                {
                    ewh.WaitOne();
                    if (stream_server.DataAvailable)
                    {
                        byte[] item = new byte[acceptedClient.ReceiveBufferSize];
                        stream_server.Read(item, 0, item.Length);
                        Form1.asServerForm.listBox1.Items.Add(Encoding.ASCII.GetString(item, 0, item.Length));
                    }
                }
                catch (SocketException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        // sending data
        private void Button_send_Click(object sender, EventArgs e)
        {
            if (acceptedClient == null)
                MessageBox.Show("You neeed to connect first.");
            else
                stream_server.Write(Encoding.ASCII.GetBytes(this.textBox1.Text), 0, this.textBox1.Text.Length);
        }


        //turns back to main form
        private void AsServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainForm.Show();
        }

        
    }
}