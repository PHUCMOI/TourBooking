using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class UCGetInformationCus : UserControl
    {
        public UCGetInformationCus()
        {
            InitializeComponent();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if(txtName.Text == "Vui lòng nhập họ tên")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
            }    
        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtGender.Text == "Giới tính")
            {
                txtGender.Text = "";
                txtGender.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtGender.Text == "")
            {
                txtGender.Text = "Giới tính";
                txtGender.ForeColor = Color.Silver;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Vui lòng nhập họ tên";
                txtName.ForeColor = Color.Silver;
            }
        }

        private void UCGetInformationCus_Load(object sender, EventArgs e)
        {
            
        }
    }
}
