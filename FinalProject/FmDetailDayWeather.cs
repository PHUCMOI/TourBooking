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
    public partial class FmDetailDayWeather : Form
    {
        string Day;
        public FmDetailDayWeather(string day_)
        {
            InitializeComponent();
            Day = day_;
        }
        public void AddWeatherDetails(string time, string day, string main, string temp, string humidity, string wind, string image)
        {
            var m = new UCDayDetailWeather()
            {
                Time = time,
                Day = day,
                Main = "Bầu trời: " + main,
                temp = "Nhiệt độ: " + temp,
                wind = "Tốc độ gió: " + wind,
                humidity = "Độ ẩm: " + humidity,
                image = image
            };
            pnlControl.Controls.Add(m);
        }
        private void FmDetailDayWeather_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < FmDetailsItem.weather5s.Count; i++)
            {
                if (FmDetailsItem.weather5s[i].getset_Day == Day)
                {
                    for (int j = 0; j < FmDetailsItem.weather5s[i].getset_weatherTempMax.Count; j++)
                    {
                        AddWeatherDetails(FmDetailsItem.weather5s[i].getset_weatherTime[j],
                            FmDetailsItem.weather5s[i].getset_Day,
                            FmDetailsItem.weather5s[i].getset_weatherMain[j],
                            "Cao: " + FmDetailsItem.weather5s[i].getset_weatherTempMax[j].ToString() + "°C \n    Thấp: " + FmDetailsItem.weather5s[i].getset_weatherTempMin[j].ToString() + "°C",
                            Math.Round(FmDetailsItem.weather5s[i].getset_weatherHumdity[j], 2).ToString() + "%",
                            Math.Round(FmDetailsItem.weather5s[i].getset_weatherWind[j], 2).ToString() + "m/s",
                            "https://openweathermap.org/img/w/" + FmDetailsItem.weather5s[i].getset_weatherIcon[j] + ".png");
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();        
        }
    }
}
