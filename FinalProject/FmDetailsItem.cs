using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static FinalProject.FmHome;

namespace FinalProject
{
    public partial class FmDetailsItem : Form
    {
        public static List<Weather5Days> weather5s = new List<Weather5Days>();
        private string title;
        private string city;
        public FmDetailsItem(string title_)
        {
            title = title_;
            InitializeComponent();
        }

        string APIKey = "2724b06529928acbf2189721ec01ea17";
        void getWeather(string city)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", city , APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                picWeatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                /*lblTemp.Text = (Info.main.temp - 273.15).ToString();
                label8.Text = Info.weather[0].description.ToString();*/

            }    
        }

        DateTime convertDateTime(long millisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddMilliseconds(millisec).ToLocalTime();

            return day;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FmDetailsItem_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < nodeList.Count; i++)
            {
                if(title == DataTour.GlobalTourTitle[i])
                {
                    lblKhoihanh.Text = "Ngày khởi hành " + DataTour.GlobalTourStart[i];
                    lblSoLuongKhach.Text = "Số lượng khách " + DataTour.GlobalTourCount[i];
                    lblDetails.Text = DataTour.GlobalTourDetails[i];
                    lblTitle.Text = title;
                    lblPrice.Text = DataTour.GlobalTourPrice[i];
                    city = DataTour.GlobalTourStartPlace[i];
                    picDetails1.Image = Base64ToImage(nodeList[i].SelectSingleNode("pic1").InnerText);
                    picDetails2.Image = Base64ToImage(nodeList[i].SelectSingleNode("pic2").InnerText);
                    picDetails3.Image = Base64ToImage(nodeList[i].SelectSingleNode("pic3").InnerText);
                    picDetails4.Image = Base64ToImage(nodeList[i].SelectSingleNode("pic4").InnerText);

                }
            }    
            getWeather(city);
        }

        private void picWeatherIcon_Click(object sender, EventArgs e)
        {

        }

        private void lblChiTiet_Click(object sender, EventArgs e)
        {
            FmWeatherInfo fmWeatherInfo = new FmWeatherInfo(city);
            fmWeatherInfo.ShowDialog();
        }

        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }
    }
}
