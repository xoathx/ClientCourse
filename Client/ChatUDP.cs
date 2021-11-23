using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Newtonsoft.Json;

namespace Client
{
    public partial class ChatUDP : Form
    {
        const string serverIp = "127.0.0.1";
        const int serverPort = 8888;

        Thread thread;
        UdpClient udpClient;
        ManualResetEvent manualReset;
        IPEndPoint serverEndPoint;
        IPEndPoint clientEndPoint;
      
        public ChatUDP()
        {
            InitializeComponent();
            serverEndPoint = new IPEndPoint(IPAddress.Parse(serverIp), serverPort);

           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ChatUDP_Load(object sender, EventArgs e)
        {

           /* string Host = Dns.GetHostName();
            var  IP = Dns.GetHostAddresses(Host);*/

            boxIP.Text = "127.0.0.1"; //IP[0].ToString();
            boxPort.Text = "8081";
            boxName.Text = "UserName";

            boxIP.Enabled = false;
            boxDialog.Enabled = false;
            boxMessage.Enabled = false;
            butSend.Enabled = false;

            
            
        }

        public void  butConnect_Click(object sender, EventArgs e)
        {



            try
            {
                StartListening();
                boxPort.Enabled = false;
                boxName.Enabled = false;

                boxDialog.Enabled = true;
                boxMessage.Enabled = true;
                butSend.Enabled = true;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            
        }

        private void butSend_Click(object sender, EventArgs e)
        {
            var serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
            
            using (UdpClient client = new UdpClient())
            {
                Message msg = new Message()
                {
                    ClientPort = int.Parse(boxPort.Text),
                    MessageText = boxName.Text + ":" + boxMessage.Text
                };
                byte[] buffer = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(msg));
                client.Send(buffer, buffer.Length, serverEndPoint);
            }
            
        }

        private void StartListening()
        {
            clientEndPoint = new IPEndPoint(IPAddress.Parse(boxIP.Text), int.Parse(boxPort.Text));
            udpClient = new UdpClient(clientEndPoint);

            var serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);

            using (UdpClient client = new UdpClient())
            {
                Message msg = new Message()
                {
                    ClientPort = int.Parse(boxPort.Text),
                    MessageText = boxName.Text + " подключен."
                };
                byte[] buffer = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(msg));
                client.Send(buffer, buffer.Length, serverEndPoint);
            }

            manualReset = new ManualResetEvent(false);
            thread = new Thread(Listen);
            thread.Start();
        }

        private void StopListening()
        {
            thread?.Interrupt();
            udpClient?.Dispose();
            
        }
        private void Listen()
        {
            try 
            {

                while(true)
                {
                    manualReset.Reset();
                    udpClient.BeginReceive(DataReceived, udpClient);
                    manualReset.WaitOne();
                }
                
            }
            catch(ThreadInterruptedException)
            {
                return;
            }
           
         }
        private void DataReceived(IAsyncResult ar)
        {
            manualReset.Set();
            UdpClient client = (UdpClient)ar.AsyncState;

            IPEndPoint receivedIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
            try
            {
                byte[] receivedBytes = client.EndReceive(ar, ref receivedIpEndPoint);

                string answer = Encoding.UTF8.GetString(receivedBytes);


                boxDialog.Invoke((MethodInvoker)delegate {
                    boxDialog.Text += answer + Environment.NewLine;
                });

                // MessageBox.Show(answer);
            }
            catch (ObjectDisposedException)
            {
                return;
            }
        }

        private void ChatUDP_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopListening();
        }

        private void tcpClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TcpClient tcpClient = new TcpClient();
            tcpClient.Show();
            
        }
    }
}
