using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FmWeatherInfo : Form
    {
        static FmWeatherInfo _obj;
        private string city;

        public PictureBox BtnBack
        {
            get { return btnBack; }
            set { btnBack = value; }
        }
        public FmWeatherInfo(string city_)
        {
            city = city_;
            InitializeComponent();
        }
        void getForecast()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?q={0}&appid=2724b06529928acbf2189721ec01ea17", city);
                var json = web.DownloadString(url);
                WeatherForecast forecastInfo = JsonConvert.DeserializeObject<WeatherForecast>(json);
                lblTitle.Text = forecastInfo.city.name;
                int a = 0;
                for (int i = 0; i < forecastInfo.list.Count; i++)
                {
                    if (CheckDuplicate(convertDateTime(forecastInfo.list[i].dt).DayOfWeek.ToString()) == 1)
                    {
                        Weather5Days weather5Days = new Weather5Days(convertDateTime(forecastInfo.list[i].dt).DayOfWeek.ToString());
                        FmDetailsItem.weather5s.Add(weather5Days);
                        a++;
                    }
                }
                label1.Text = a.ToString();
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < forecastInfo.list.Count; j++)
                    {
                        if (FmDetailsItem.weather5s[i].getset_Day == convertDateTime(forecastInfo.list[j].dt).DayOfWeek.ToString())
                        {
                            FmDetailsItem.weather5s[i].getset_weatherIcon.Add(forecastInfo.list[j].weather[0].icon);
                            FmDetailsItem.weather5s[i].getset_weatherTime.Add((forecastInfo.list[j].dt_txt).Substring(0, 10));
                            FmDetailsItem.weather5s[i].getset_weatherMain.Add(forecastInfo.list[j].weather[0].main);
                            FmDetailsItem.weather5s[i].getset_weatherTempMax.Add(Math.Round(forecastInfo.list[j].main.temp_max - 273.15, 2));
                            FmDetailsItem.weather5s[i].getset_weatherTempMin.Add(Math.Round(forecastInfo.list[j].main.temp_min - 273.15, 2));
                            FmDetailsItem.weather5s[i].getset_weatherHumdity.Add(forecastInfo.list[j].main.humidity);
                            FmDetailsItem.weather5s[i].getset_weatherWind.Add(forecastInfo.list[j].wind.speed);
                        }
                    }
                }
            }
        }

        private void Visible5Days()
        {
            for(int i = 0; i < 6; i++)
            {
                if (FmDetailsItem.weather5s[i].getset_weatherTime.Count != 0)
                {
                    AddWeatherDetails(FmDetailsItem.weather5s[i].getset_weatherTime[0],
                        FmDetailsItem.weather5s[i].getset_Day,
                        FmDetailsItem.weather5s[i].getset_weatherMain[0],
                        "Cao: " + FmDetailsItem.weather5s[i].getset_weatherTempMax.Max().ToString() + "°C  Thấp" + FmDetailsItem.weather5s[i].getset_weatherTempMin.Min().ToString() + "°C",
                        Math.Round(FmDetailsItem.weather5s[i].getset_weatherHumdity.Average(), 2).ToString() + "%",
                        Math.Round(FmDetailsItem.weather5s[i].getset_weatherWind.Average(), 2).ToString() + "m/s",
                        "https://openweathermap.org/img/w/" + FmDetailsItem.weather5s[i].getset_weatherIcon[0] + ".png");
                }
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FmWeatherInfo_Load(object sender, EventArgs e)
        {
            _obj = this;
            getForecast();
            Visible5Days();
        }

        //Load data detail day weather

        DateTime convertDateTime(double millisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(millisec).ToLocalTime();

            return day;
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlControl.Controls["UCForecast5Days"].BringToFront();
        }

        public static int CheckDuplicate(string Day)
        {
            for (int i = 0; i < FmDetailsItem.weather5s.Count; i++)
            {
                if (Day == FmDetailsItem.weather5s[i].getset_Day)
                    return 0;
            }
            return 1;
        }
        public void AddWeatherDetails(string time, string day, string main, string temp, string humidity, string wind, string image)
        {
            var m = new UCForecast5Days()
            {
                Time = time,
                Day = day,
                Main = main,
                temp = temp,
                wind = wind,
                humidity = humidity,
                image = image
            };

            pnlControl.Controls.Add(m);

            m.OnSelect += (ss, ee) =>
            {
                var uCForecast5Days = (UCForecast5Days)ss;
                
                pnlControl.Visible = false;
                FmDetailDayWeather frm3 = new FmDetailDayWeather(day);
                frm3.TopLevel = false;
                pnlControl.Hide();
                if (pnlControl.Visible == false)
                {
                    pnlDetailDayWeather.Visible = true;
                    pnlDetailDayWeather.Dock = DockStyle.Fill;
                    pnlDetailDayWeather.Controls.Add(frm3);
                    frm3.BringToFront();
                    frm3.Dock = DockStyle.Fill;
                    frm3.Show();
                }
            };
        }
    }
}



