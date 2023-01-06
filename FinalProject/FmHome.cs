﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FinalProject
{
    public partial class FmHome : Form
    {
        public static XmlDocument xmlDoc = new XmlDocument();
        public static XmlNodeList nodeList;
        public static class DataTour
        {
            private static List<string> TourTitle = new List<string>();
            private static List<string> TourTime = new List<string>();
            private static List<string> TourPrice = new List<string>();
            private static List<string> TourDetails = new List<string>();


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
        }
        public FmHome()
        {
            InitializeComponent();
        }

        private void FmHome_Load(object sender, EventArgs e)
        {
            xmlDoc.Load("..//..//data.xml");

            nodeList = xmlDoc.DocumentElement.SelectNodes("/tours/" + "/tour");
            for(int i = 0; i < nodeList.Count; i++)
            {
                DataTour.GlobalTourTitle.Add(nodeList[i].SelectSingleNode("title").InnerText);
                DataTour.GlobalTourTime.Add(nodeList[i].SelectSingleNode("time").InnerText);
                DataTour.GlobalTourPrice.Add(nodeList[i].SelectSingleNode("price").InnerText);
                DataTour.GlobalTourDetails.Add(nodeList[i].SelectSingleNode("schedule").InnerText);


                AddTourItem(DataTour.GlobalTourTitle[i],
                    DataTour.GlobalTourTime[i],
                    DataTour.GlobalTourPrice[i],
                    DataTour.GlobalTourTitle[i] + ".jpg");
            }
            label1.Text = DataTour.GlobalTourTitle[0];
        }

        public void AddTourItem(string title, string time, string price, string image)
        {
            var m = new UCItem()
            {
                Title = title,
                Time = time,
                Price = price,
                ImageTour = Image.FromFile("..//..//image/" + image)
            };

            pnlControl.Controls.Add(m); 

            m.OnSelect += (ss, ee) =>
            {
                var tourItem = (UCItem)ss;
                pnlControl.Visible = false;
                FmDetailsItem frm3 = new FmDetailsItem();
                frm3.TopLevel = false;
                pnlControl.Hide();
                if (pnlControl.Visible == false)
                {
                    pnlOpenChildForm.Visible = true;
                    pnlOpenChildForm.Dock = DockStyle.Fill;
                    pnlOpenChildForm.Controls.Add(frm3);
                    frm3.BringToFront();
                    frm3.Dock = DockStyle.Fill;
                    frm3.Show();
                }
            };
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}