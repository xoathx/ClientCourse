using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Client
{
    public partial class TcpClient : Form
    {
        const int serverPort = 8888;
        const string serverIP = "127.0.0.1";

        IPEndPoint tcpEndPoint;
        Socket tcpSocket;

        public TcpClient()
        {
            InitializeComponent();

            butDrop.Enabled = false;

            tcpEndPoint = new IPEndPoint(IPAddress.Parse(serverIP), serverPort);


        }

        private void TcpClient_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            butDrop.Enabled = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string move = "add";
            if(boxString.Text.Length > 0)
            {
                
                var message = boxString.Text;
                TcpMessage tcpMessage = new TcpMessage()
                {
                    Move = move,
                    MessageToAdd = message
                };

                byte[] buffer = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(tcpMessage));
                StartListening();
                tcpSocket.Send(buffer);
                StopListening();
            }
            else
            {
                MessageBox.Show("Enter message.");
            }
        }

        private void butDrop_Click(object sender, EventArgs e)
        {
            string move = "del";

            TcpMessage tcpMessage = new TcpMessage()
            {
                Move = move
            };
           
            byte[] buffer = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(tcpMessage));
            StartListening();
            tcpSocket.Send(buffer);
            StopListening();

        }


        public void StartListening()
        {
            
            tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpSocket.Connect(tcpEndPoint);
        }

        public void StopListening()
        {
            tcpSocket.Close();
        }
    }
}
