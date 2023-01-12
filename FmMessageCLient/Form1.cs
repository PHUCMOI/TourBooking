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
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace FmMessageCLient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Connect();
        }
        IPEndPoint ipe;
        TcpClient tcpListener;
        Stream stream;
        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
        }
        void Connect()
        {
            ipe = new IPEndPoint(IPAddress.Parse("192.168.1.194"), 9999);
            tcpListener = new TcpClient();
            tcpListener.Connect(ipe);
            stream = tcpListener.GetStream();
            Thread recv = new Thread(Recevie);
            recv.IsBackground = true;
            recv.Start();
        }

        void Send()
        {
            byte[] data = Encoding.UTF8.GetBytes(txtMessage.Text);
            stream.Write(data, 0, data.Length);
            AddMessage(System.Environment.NewLine + "Admin: " + txtMessage.Text + "\n" + System.Environment.NewLine);
        }

        void Recevie()
        {
            while (true)
            {
                byte[] recv = new byte[1024];
                stream.Read(recv, 0, recv.Length);
                string s = Encoding.UTF8.GetString(recv);
                AddMessage(System.Environment.NewLine + "Client: " + s + "\n" + System.Environment.NewLine);
            }
        }
        delegate void SetTextCallback(string text);
        void AddMessage(string mess)
        {
            if (this.chatScreen.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(AddMessage);
                this.Invoke(d, new object[] { mess });
            }
            else
            {
                this.chatScreen.AppendText(mess);
            }
            //chatScreen.AppendText(mess);
            /*if (listView1.InvokeRequired)
            {
                listView1.Invoke((MethodInvoker)delegate ()
                {
                    ListViewItem item = new ListViewItem(mess);
                    listView1.Items.Add(item);
                    listView1.EnsureVisible(listView1.Items.Count - 1);
                });
            }*/
        }
    }
}
