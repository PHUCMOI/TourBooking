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

namespace FinalProject
{
    public partial class FmMessageAdmin : Form
    {
        /*private TcpClient Client;
        public StreamReader STR;
        public StreamWriter STW;
        public string Recieve;
        public string TexttoSend;*/

        IPEndPoint ipe;
        Socket client;
        TcpListener tcpListener;
        public FmMessageAdmin()
        {
            InitializeComponent();

            /*IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            string a;
            foreach (IPAddress address in localIP)
            {
                if(address.AddressFamily == AddressFamily.InterNetwork)
                {
                    a = address.ToString();
                }
            }    */
            Connect();
        }
        void Connect()
        {
            ipe = new IPEndPoint(IPAddress.Any, 9999);
            tcpListener = new TcpListener(ipe);
            Thread thread = new Thread(() =>
            {
                while(true)
                {
                    tcpListener.Start();
                    client = tcpListener.AcceptSocket();
                    Thread rec = new Thread(Recieve);
                    rec.IsBackground = true;
                    rec.Start(client);
                }    
            });
            thread.IsBackground = true;
            thread.Start();

        }

        void Send(Socket client)
        {
            byte[] data = Encoding.UTF8.GetBytes(txtMessage.Text);
            client.Send(data);
            AddMessage(System.Environment.NewLine + "Client: " + txtMessage.Text + "\n" + System.Environment.NewLine);
        }

        void Recieve(Object obj)
        {
            while(true)
            {
                //Socket client = obj as Socket;
                byte[] recv = new byte[1024];
                client.Receive(recv);
                string s = Encoding.UTF8.GetString(recv);
                AddMessage(System.Environment.NewLine + "Admin: " + s + "\n" + System.Environment.NewLine);
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
        }
        private void FmMessage_Load(object sender, EventArgs e)
        {
            /*TcpListener listener = new TcpListener(IPAddress.Any, int.Parse("80"));
            listener.Start();
            Client = listener.AcceptTcpClient();
            STR = new StreamReader(Client.GetStream());
            STW = new StreamWriter(Client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;

            Client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse("192.168.1.194"), int.Parse("80"));

            try
            {
                //ChatScreen.AppendText("Connect to Server \n");
                STW = new StreamWriter(Client.GetStream());
                STR = new StreamReader(Client.GetStream());
                STW.AutoFlush = true;
                backgroundWorker1.RunWorkerAsync();
                backgroundWorker2.WorkerSupportsCancellation = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            /*while(Client.Connected)
            {
                try
                {
                    Recieve  = STR.ReadLine();
                    this.ChatScreen.Invoke(new MethodInvoker(delegate ()
                    {
                        ChatScreen.AppendText("You: " + Recieve + "\n");
                    }));
                    Recieve = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }    */
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            /*if(Client.Connected)
            {
                STW.WriteLine(TexttoSend);
                this.ChatScreen.Invoke(new MethodInvoker(delegate ()
                {
                    ChatScreen.AppendText("Me: " + TexttoSend + "\n");
                }));
            }    
            else
            {
                MessageBox.Show("Gửi lỗi");
            }

            backgroundWorker2.CancelAsync();*/
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            /* if(txtMessage.Text != "")
             {
                 TexttoSend = txtMessage.Text;
                 backgroundWorker2.RunWorkerAsync();
             }
             txtMessage.Text = "";*/
            Send(client);
        }
    }
}
