using RestSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinalProject.FmHome;

namespace FinalProject
{
    public partial class FmInformationCustomer : Form
    {
        private string TourName = "";
        private string KhoiHanh = "";
        private Image picTour_;
        private string price_ = "";
        private int count = 1;
        public delegate void SendContact(string Message);
        public SendContact Sender;
        public FmInformationCustomer(string tourName, string khoiHanh, Image picTour, string price_)
        {
            InitializeComponent();
            Sender = new SendContact(GetMessage);
            TourName = tourName;
            KhoiHanh = khoiHanh;
            this.picTour_ = picTour;
            this.price_ = price_;
            //Sender = new SendMessage(GetMessageInfo);
        }

        public static List<Booked> bookeds = new List<Booked>();
        double OriPrice = 0;
        private void FmInformationCustomer_Load(object sender, EventArgs e)
        {
            UCGetInformationCus uCGetInformationCus = new UCGetInformationCus();
            pnlControl.Controls.Add(uCGetInformationCus);
            picTour.Image = picTour_;
            lblTour.Text = TourName;
            lblStartDay.Text = KhoiHanh;
            lblPrice.Text = price_;
            OriPrice = Convert.ToDouble(price_.Replace(",", "").Replace(" đ", ""));
        }

        

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblSoLuong.Text = count.ToString();
            UCGetInformationCus uCContactCustomer = new UCGetInformationCus();
            pnlControl.Controls.Add(uCContactCustomer);
            OriPrice += Convert.ToDouble(price_.Replace(",", "").Replace(" đ", ""));
            string FinalOriPrice = string.Format("{0:N}", OriPrice).Replace(',', '.');
            lblPrice.Text = FinalOriPrice.Substring(0, FinalOriPrice.Length - 3) + " đ";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            count--;
            lblSoLuong.Text = count.ToString();
            pnlControl.Controls.RemoveAt(pnlControl.Controls.Count - 1);
            OriPrice -= Convert.ToDouble(price_.Replace(",", "").Replace(" đ", ""));
            string FinalOriPrice = string.Format("{0:N}", OriPrice).Replace(',', '.');
            lblPrice.Text = FinalOriPrice.Substring(0, FinalOriPrice.Length - 3) + " đ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GetMessage(string Message)
        {

        }

        private void btnDatTour_Click(object sender, EventArgs e)
        {
            Booked booked = new Booked(lblTour.Text);
            bookeds.Add(booked);
            for(int i = 0; i < bookeds.Count; i++)
            {
                if (bookeds[i].getset_TourName == lblTour.Text)
                {
                    bookeds[i].getset_NameBookedCus.Add(ucContactCustomer1.txtNameCus.Text);
                    bookeds[i].getset_EmailBookedCus.Add(ucContactCustomer1.txtEmailCus.Text);                  
                    bookeds[i].getset_PhoneBookedCus.Add(ucContactCustomer1.txtPhoneCus.Text);
                    bookeds[i].getset_AddressBookedCus.Add(ucContactCustomer1.txtAddressCus.Text);
                    foreach(UCGetInformationCus item in pnlControl.Controls)
                    {
                        bookeds[i].getset_NameCus.Add(item.txtName.Text);
                        bookeds[i].getset_GenderCus.Add(item.txtGender.Text);
                        bookeds[i].getset_DayOfBirthCus.Add(item.dateTimePicker1.Text);
                    }    
                }
            }  
            FmPayment fmPayment = new FmPayment(TourName, KhoiHanh, picTour_, lblPrice.Text);
            this.Hide();
            fmPayment.ShowDialog();
            this.Show();
        }
    }
}
