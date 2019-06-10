using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace tcp_example
{
    public partial class Form1 : Form
    {
        TCP_Ex tcp1 = new TCP_Ex();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        { // filling listboxes
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(rnd.Next(1000, 10000));
                listBox2.Items.Add(rnd.Next(1000, 10000));
            }
        }

        private void buttonServerToClient_Click(object sender, EventArgs e)
        {
            object item = listBox1.SelectedItem;
            if (item != null)
            {
                tcp1.sendServerToClient(item);// sending the selected data
                listBox2.Items.Add(tcp1.receiveFromServer());//receiving the data and adding to relevant listbox
                listBox1.Items.Remove(item); //removing the data from other listbox
            }
        }

        private void buttonClientToServer_Click(object sender, EventArgs e)
        { //sending the other way
            object item = listBox2.SelectedItem;
            if (item != null)
            {
                tcp1.sendServerToClient(item);
                listBox1.Items.Add(tcp1.receiveFromServer());
                listBox2.Items.Remove(item);
            }
        }
    }

    public class TCP_Ex
    {   //my class for tcp communication
        TcpListener server = new TcpListener(IPAddress.Any, 2500); // server listens from any ip
        TcpClient client = new TcpClient();
        NetworkStream streamServer;
        NetworkStream streamClient;
        TcpClient acceptedTCPClient;

        public TCP_Ex()
        {
            server.Start();
            client.Connect(IPAddress.Parse("127.0.0.1"), 2500);
            acceptedTCPClient = server.AcceptTcpClient();
            streamServer = acceptedTCPClient.GetStream();
            streamClient = client.GetStream();
        }
        public void sendServerToClient(object item)
        {
            //send item to client from server
            streamServer.Write(Encoding.ASCII.GetBytes(item.ToString()), 0, item.ToString().Length);
        }
        public object receiveFromServer()
        {
            //receive item from server
            byte[] item = new byte[10];
            streamClient.Read(item, 0, item.Length);
            return Encoding.ASCII.GetString(item);
        }
        public void sendClientToServer(object item)
        {
            //send item to client from server
            streamClient.Write(Encoding.ASCII.GetBytes(item.ToString()), 0, item.ToString().Length);
        }
        public object receiveFromClient()
        {
            //receive item from client
            byte[] item = new byte[acceptedTCPClient.ReceiveBufferSize];
            streamServer.Read(item, 0, item.Length);
            return Encoding.ASCII.GetString(item);
        }
    }
}
