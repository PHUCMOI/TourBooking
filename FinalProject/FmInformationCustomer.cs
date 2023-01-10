using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FmInformationCustomer : Form
    {
        private int count = 1;
        public FmInformationCustomer()
        {
            InitializeComponent();
        }

        private void FmInformationCustomer_Load(object sender, EventArgs e)
        {
            UCGetInformationCus uCGetInformationCus = new UCGetInformationCus();
            pnlControl.Controls.Add(uCGetInformationCus);
            UCContactCustomer uCContactCustomer = new UCContactCustomer();
            pnlControl.Controls.Add(uCContactCustomer);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblSoLuong.Text = count.ToString();
            UCContactCustomer uCContactCustomer = new UCContactCustomer();
            pnlControl.Controls.Add(uCContactCustomer);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            count--;
            lblSoLuong.Text = count.ToString();
            pnlControl.Controls.RemoveAt(pnlControl.Controls.Count - 1);
        }
    }
}
