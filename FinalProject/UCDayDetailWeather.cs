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
    public partial class UCDayDetailWeather : UserControl
    {
        public UCDayDetailWeather()
        {
            InitializeComponent();
        }

        public string Time { get => lblTime.Text; set => lblTime.Text = value; }
        public string Day { get => lblDay.Text; set => lblDay.Text = value; }
        public string Main { get => lblMain.Text; set => lblMain.Text = value; }
        public string temp { get => lblTemp.Text; set => lblTemp.Text = value; }
        public string wind { get => lblWind.Text; set => lblWind.Text = value; }    
        public string humidity { get => lblHumidity.Text; set => lblHumidity.Text = value;}
        /*public string sunrise { get => lblSunrise.Text; set => lblSunrise.Text = value; }
        public string sunset { get => lblSunset.Text; set => lblSunset.Text = value; }*/
        public string image { get => pictureBox1.ImageLocation; set =>pictureBox1.ImageLocation = value; }

    }
}
