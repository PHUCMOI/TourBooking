using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using static FinalProject.ConnectFireBase;
using RestSharp.Extensions;

namespace FinalProject
{
    public partial class FmSignIn : Form
    {
        /*IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "mpfM9JA9tibP1cbQc4JjRQmkH17ikeuwVNF0nkN4",
            BasePath = "https://finalproject-274d9-default-rtdb.firebaseio.com/"
        };*/

        IFirebaseClient client;

        public FmSignIn()
        {
            InitializeComponent();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void FmSignIn_Load(object sender, EventArgs e)
        {
            label1.Text = "Tournament\n     Travel";
            /*client = new FireSharp.FirebaseClient(config);
            FirebaseResponse resp2 = await client.GetTaskAsync("user/");
            Data obj2 = resp2.ResultAs<Data>();

            for (int i = 0; i < obj2.HoTen.Length; i++)
            {
                ManageAccount.Account.GlobalHoten.Add(obj2.HoTen);
                ManageAccount.Account.GlobalEmail.Add(obj2.Email);
                ManageAccount.Account.GlobalSĐT.Add(obj2.SĐT);
                ManageAccount.Account.GlobalPassword.Add(obj2.Password);
            }
            label1.Text = Convert.ToString(ManageAccount.Account.GlobalHoten.Count);*/
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "admin" && txtMatKhau.Text == "admin")
            {
                FmHome f1 = new FmHome(true);
                this.Hide();
                f1.ShowDialog();
                this.Show();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FmSignUp f1 = new FmSignUp();
            f1.ShowDialog();
            this.Close();
        }
    }
}