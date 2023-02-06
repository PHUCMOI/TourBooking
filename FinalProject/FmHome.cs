using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.Net.Sockets;

namespace FinalProject
{
    public partial class FmHome : Form
    {
        bool flag;
        public delegate void SendMessage(string Message);
        public SendMessage Sender;

        public delegate void SendCloseForm(string Message);
        public SendCloseForm sendCloseForm;

        public static XmlDocument xmlDoc = new XmlDocument();
        public static XmlNodeList nodeList, dayList;

        public static class DataTour
        {
            private static List<string> TourTitle = new List<string>();
            private static List<string> TourTime = new List<string>();
            private static List<string> TourPrice = new List<string>();
            private static List<string> TourDetails = new List<string>();
            private static List<string> TourCount = new List<string>();
            private static List<string> TourStart = new List<string>();
            private static List<string> TourStartPlace = new List<string>();
            private static List<string> TourDestination = new List<string>();
            private static List<string> TourImage = new List<string>();


            public static List<string> GlobalTourTitle
            {
                get { return TourTitle; }
                set { TourTitle.Add(value.ToString()); }
            }
            public static List<string> GlobalTourTime
            {
                get { return TourTime; }
                set { TourTime.Add(value.ToString()); }
            }
            public static List<string> GlobalTourPrice
            {
                get { return TourPrice; }
                set { TourPrice.Add(value.ToString()); }
            }
            public static List<string> GlobalTourDetails
            {
                get { return TourDetails; }
                set { TourDetails.Add(value.ToString()); }
            }
            public static List<string> GlobalTourCount
            {
                get { return TourCount; }
                set { TourCount.Add(value.ToString()); }
            }
            public static List<string> GlobalTourStart
            {
                get { return TourStart; }
                set { TourStart.Add(value.ToString()); }
            }
            public static List<string> GlobalTourStartPlace
            {
                get { return TourStartPlace; }
                set { TourStartPlace.Add(value.ToString()); }
            }
            public static List<string> GlobalTourImage
            {
                get { return TourImage; }
                set { TourImage.Add(value.ToString()); }
            }
            public static List<string> GlobalTourDestination
            {
                get { return TourDestination; }
                set { TourDestination.Add(value.ToString()); }
            }
        }
        public FmHome(bool flag)
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
            sendCloseForm = new SendCloseForm(GetCloseForm);
            this.flag = flag;
        }
        private void GetMessage(string Message)
        {
            if (Message == "1")
            {
                xmlDoc.Load("..//..//data.xml");

                nodeList = xmlDoc.DocumentElement.SelectNodes("/tours/" + "/tour");
                var m = new UCItem()
                {
                    Title = nodeList[nodeList.Count - 1].SelectSingleNode("title").InnerText,
                    Time = nodeList[nodeList.Count - 1].SelectSingleNode("time").InnerText,
                    Price = nodeList[nodeList.Count - 1].SelectSingleNode("price").InnerText + "VNĐ",
                    ImageTour = Base64ToImage(nodeList[nodeList.Count - 1].SelectSingleNode("pic1").InnerText)
                };
                pnlControl.Controls.Add(m);
                m.OnSelect += (ss, ee) =>
                {
                    FmDetailsItem fmDetailsItem = new FmDetailsItem(m.Title);
                    this.Hide();
                    fmDetailsItem.ShowDialog();
                    this.Show();
                    /*var tourItem = (UCItem)ss;
                    pnlControl.Visible = false;
                    FmDetailsItem frm3 = new FmDetailsItem(title);
                    frm3.TopLevel = false;
                    pnlControl.Hide();
                    pnlFilter.Hide();
                    if (pnlControl.Visible == false)
                    {
                        pnlOpenChildForm.Visible = true;
                        pnlOpenChildForm.Dock = DockStyle.Fill;
                        pnlOpenChildForm.Controls.Add(frm3);
                        frm3.BringToFront();
                        frm3.Dock = DockStyle.Fill;
                        frm3.Show();
                    }*/
                };
            }
        }

        List<string> DiemDi = new List<string>();
        List<string> DiemDen = new List<string>();

        private void FmHome_Load(object sender, EventArgs e)
        {
            if(flag == false)
            {
                button1.Visible = false;
            }    
            xmlDoc.Load("..//..//data.xml");
            nodeList = xmlDoc.DocumentElement.SelectNodes("/tours/" + "/tour");
            for(int i = 0; i < nodeList.Count; i++)
            {
                DataTour.GlobalTourTitle.Add(nodeList[i].SelectSingleNode("title").InnerText);
                DataTour.GlobalTourTime.Add(nodeList[i].SelectSingleNode("time").InnerText);
                DataTour.GlobalTourPrice.Add(nodeList[i].SelectSingleNode("price").InnerText);
                DataTour.GlobalTourDetails.Add(nodeList[i].SelectSingleNode("schedule").InnerText);
                DataTour.GlobalTourCount.Add(nodeList[i].SelectSingleNode("count").InnerText);
                DataTour.GlobalTourStart.Add(nodeList[i].SelectSingleNode("start").InnerText);
                DataTour.GlobalTourStartPlace.Add(nodeList[i].SelectSingleNode("startPlace").InnerText);
                DataTour.GlobalTourDestination.Add(nodeList[i].SelectSingleNode("destination").InnerText);
                DataTour.GlobalTourImage.Add(nodeList[i].SelectSingleNode("pic1").InnerText);

                AddTourItem(DataTour.GlobalTourTitle[i],
                    DataTour.GlobalTourTime[i],
                    DataTour.GlobalTourPrice[i],
                    Base64ToImage(DataTour.GlobalTourImage[i]),
                    DataTour.GlobalTourStartPlace[i],
                    DataTour.GlobalTourDestination[i]);

                if(DiemDi.Contains(nodeList[i].SelectSingleNode("startPlace").InnerText))
                {
                    
                }
                else
                {
                    DiemDi.Add(nodeList[i].SelectSingleNode("startPlace").InnerText);
                }
                if (DiemDen.Contains(nodeList[i].SelectSingleNode("destination").InnerText))
                {

                }
                else
                {
                    DiemDen.Add(nodeList[i].SelectSingleNode("destination").InnerText);
                }
                
                 //SoNgay.Items.Add(nodeList[i].SelectSingleNode("time").InnerText);
            }
              CheckDuplicate();
        }



        public void CheckDuplicate()
        {
            for (int i = 0; i < DiemDi.Count; i++)
            {
                cboDiemDi.Items.Add(DiemDi[i]);
            }

            for (int i = 0; i < DiemDen.Count; i++)
            {
                cboDiemden.Items.Add(DiemDen[i]);
            }
        }

        public void AddTourItem(string title, string time, string price, Image image, string StartPlace, string Destination)
        {
            var m = new UCItem()
            {
                Title = title,
                Time = time,
                Price = price + "VNĐ",
                ImageTour = image,
                StartPlace = StartPlace,
                destination = Destination
               
            };

            pnlControl.Controls.Add(m); 

            m.OnSelect += (ss, ee) =>
            {
                FmDetailsItem fmDetailsItem = new FmDetailsItem(title);
                this.Hide();
                fmDetailsItem.ShowDialog();
                this.Show();
                /*var tourItem = (UCItem)ss;
                pnlControl.Visible = false;
                FmDetailsItem frm3 = new FmDetailsItem(title);
                frm3.TopLevel = false;
                pnlControl.Hide();
                pnlFilter.Hide();
                if (pnlControl.Visible == false)
                {
                    pnlOpenChildForm.Visible = true;
                    pnlOpenChildForm.Dock = DockStyle.Fill;
                    pnlOpenChildForm.Controls.Add(frm3);
                    frm3.BringToFront();
                    frm3.Dock = DockStyle.Fill;
                    frm3.Show();
                }*/
            };
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            FmAddTour fm = new FmAddTour();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }

        private void pnlControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGmail_Click(object sender, EventArgs e)
        {
            FmSendGamilCus fmSendGamilCus = new FmSendGamilCus();
            fmSendGamilCus.ShowDialog();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            foreach (var item in pnlControl.Controls)
            {
                var touritem = (UCItem)item;
                if (touritem.label1.Text == cboDiemDi.SelectedItem.ToString() && touritem.label2.Text == cboDiemden.SelectedItem.ToString())
                {
                    touritem.Visible = true;
                }
                else
                    touritem.Visible = false;
            }
        }

        private void btnMess_Click(object sender, EventArgs e)
        {
            FmMessageAdmin fmMessage = new FmMessageAdmin();
            fmMessage.ShowDialog();
        }

        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }

        private void GetCloseForm(string Message)
        {
            if (Message == "1")
            {
                pnlOpenChildForm.Visible = false;
            }
        }
    }
}
