using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Xml;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using static FinalProject.ConnectFireBase;

namespace FinalProject
{
    public partial class FmSignUp : Form
    {
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "mpfM9JA9tibP1cbQc4JjRQmkH17ikeuwVNF0nkN4",
            BasePath = "https://finalproject-274d9-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public FmSignUp()
        {
            InitializeComponent();
        }
        public static bool IsEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(strRegex);

            return regex.IsMatch(email);
        }

        public static bool IsPhoneNumber(string value)
        {
            if (value.Length > 10)
                return false;
            string pattern = @"^-*[0-9,\.?\-?\(?\)?\ ]+$";
            return Regex.IsMatch(value, pattern);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Tournament\n     Travel";
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                label7.Text = "Connected";
            }    
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnDangKy_Click(object sender, EventArgs e)
        {
            //Lưu vào database
            Data DataLayer = new Data()
            {
                HoTen = txtHoTen.Text,
                SĐT = txtSoDienThoai.Text,
                Email = txtEmail.Text,
                Password = txtMatKhau.Text
            };

            SetResponse response = await client.SetTaskAsync("", DataLayer);
            Data result = response.ResultAs<Data>();


            /* FmSignIn f1 = new FmSignIn();
             f1.ShowDialog();
             this.Hide();*/
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (IsPhoneNumber(txtSoDienThoai.Text) == true || txtSoDienThoai.Text == "")
            {
                pnlCheckSĐT.BackColor = Color.Lime;
            }
            else
            {
                pnlCheckSĐT.BackColor = Color.Red;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (IsEmail(txtEmail.Text) == true || txtEmail.Text == "")
            {
                pnlCheckEmail.BackColor = Color.Lime;
            }
            else
            {
                pnlCheckEmail.BackColor = Color.Red;
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if(txtMatKhau.Text.Length < 8)
            {
                pnlCheckPass.BackColor = Color.Red;
            }
            else
            {
                pnlCheckPass.BackColor = Color.Lime;
            }
        }

        private void txtNhapLaiMatKhau_TextChanged(object sender, EventArgs e)
        {
            if(String.Compare(txtMatKhau.Text, txtNhapLaiMatKhau.Text) != 0)
            {
                pnlCheckPass1.BackColor = Color.Red;
            }    
            else
            {
                pnlCheckPass1.BackColor = Color.Lime;
            }    
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FmSignIn f1 = new FmSignIn();
            f1.ShowDialog();
            this.Close();
        }
    }

    
}
