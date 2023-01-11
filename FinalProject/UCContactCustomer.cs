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
    public partial class UCContactCustomer : UserControl
    {
        public UCContactCustomer()
        {
            InitializeComponent();
        }
        
        
        public string NameCus { get => txtNameCus.Text; set => txtNameCus.Text = value; }
        public string EmailCus { get => txtEmailCus.Text; set => txtEmailCus.Text = value;  }
        public string PhoneCus { get => txtPhoneCus.Text; set => txtPhoneCus.Text = value;  }
        public string AddressCus { get => txtAddressCus.Text; set => txtAddressCus.Text = value; }

        
    }
}
