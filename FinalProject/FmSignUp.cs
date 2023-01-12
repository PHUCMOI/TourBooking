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
        public static bool flag = false;
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
              
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            flag = true;
            FmSignIn fmSignIn = new FmSignIn();
            this.Hide();
            fmSignIn.ShowDialog();
            this.Close();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FmHome fmHome = new FmHome(flag);
            this.Hide();
            fmHome.ShowDialog();
            this.Close();
        }
    }

    
}
