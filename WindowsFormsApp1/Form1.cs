using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;
using System.Net;
using System.Net.Sockets;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool Server = true;
        string localIP = "?";
        string ChosenIP = "?";
        string ServerPort = "?";
        string ChosenPort = "?";


        private TcpClient Client;
        public StreamReader STR;
        public string DataToSend;

        public Form1()
        {
            InitializeComponent();

 
            foreach (var ip in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }

            this.textBox2.Text = localIP;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Server)
            {
                ServerPort = textBox1.Text;
            }
            else
            {
                ChosenPort = textBox1.Text;
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Connect";
            label2.Text = "Connecting";
            this.Text = "Client";
            Server = false;
            this.textBox2.Text = ChosenIP;
            this.textBox1.Text = ChosenPort;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChosenIP = this.textBox2.Text;
            button1.Text = "Share";
            label2.Text = "Sharing";
            this.Text = "Server";
            this.textBox2.Text = localIP;
            Server = true;
            this.textBox1.Text = ServerPort;
        }

        private void ConnectOrShare(object sender, EventArgs e)
        {
           
           
            if (Server)
            {
                MessageBox.Show("Sharing");
                TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(
            }
            else
            {
                MessageBox.Show("Connection");
            }
        }

        private void Stop(object sender, EventArgs e)
        {
            if (Server)
            {
                MessageBox.Show("Stoping server");
            }
            else
            {
                MessageBox.Show("Stopping connection");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
