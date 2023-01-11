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
    public partial class UCDeatilCustomer : UserControl
    {
        public UCDeatilCustomer()
        {
            InitializeComponent();
        }
        public string Name { get => lblName.Text; set => lblName.Text = value; }
        public string Gender { get => lblGender.Text; set => lblGender.Text = value; }
        public string DayOfBirth { get => lblDateOFBirth.Text; set => lblDateOFBirth.Text = value; }
    }
}
