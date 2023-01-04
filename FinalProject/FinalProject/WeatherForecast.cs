using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static FinalProject.WeatherForecast;

namespace FinalProject
{
    class WeatherForecast
    {
        public List<list> list { get; set; }
        public city city { get; set; }
    }
    public class wind
    {
        public double speed { get; set; }
    }

    public class weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class main
    {
        public double temp { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public double humidity { get; set; }
    }

    public class list
    {
        public double dt { get; set; }
        public wind wind { get; set; }
        public List<weather> weather { get; set; }
        public main main { get; set; }
        public string dt_txt { get; set; }
    }
    public class city
    {
        public string name { get; set; }
        public string country { get; set; }
        public double sunrise { get; set; }
        public double sunset { get; set; }
    }
}
