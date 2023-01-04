using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Weather5Days
    {
        private string Day = "";
        private List<string> weatherIcon = new List<string>();
        private List<string> weatherTime = new List<string>();
        private List<string> weatherMain = new List<string>();
        private List<double> weatherTempMax = new List<double>();
        private List<double> weatherTempMin = new List<double>();
        private List<double> weatherHumdity = new List<double>();
        private List<double> weatherWind = new List<double>();
        private List<long> weatherSunrise = new List<long>();
        private List<long> weatherSunset= new List<long>();

        public Weather5Days(string day)
        {
            Day = day;
        }

        public string getset_Day
        {
            get
            {
                return Day;
            }
            set
            {
                Day = value;
            }
        }
        public List<string> getset_weatherIcon
        {
            get
            {
                return weatherIcon;
            }
            set
            {
                weatherIcon.Add(value.ToString());
            }
        }
        public List<string> getset_weatherTime
        {
            get
            {
                return weatherTime;
            }
            set
            {
                weatherTime.Add(value.ToString());
            }
        }
        public List<string> getset_weatherMain
        {
            get
            {
                return weatherMain;
            }
            set
            {
                weatherMain.Add(value.ToString());
            }
        }
        public List<double> getset_weatherTempMax
        {
            get
            {
                return weatherTempMax;
            }
            set
            {
                weatherTempMax = value;
            }
        }
        public List<double> getset_weatherTempMin
        {
            get
            {
                return weatherTempMin;
            }
            set
            {
                weatherTempMin = value;
            }
        }
        public List<double> getset_weatherHumdity
        {
            get
            {
                return weatherHumdity;
            }
            set
            {
                weatherHumdity = value;
            }
        }
        public List<double> getset_weatherWind
        {
            get
            {
                return weatherWind;
            }
            set
            {
                weatherWind = value;
            }
        }

        public List<long> getset_weatherSunrise
        {
            get
            {
                return weatherSunrise;
            }
            set
            {
                weatherSunrise = value;
            }
        }

        public List<long> getset_weatherSunset
        {
            get
            {
                return weatherSunset;
            }
            set
            {
                weatherSunset = value;
            }
        }
    }
}
