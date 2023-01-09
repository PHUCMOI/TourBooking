using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace FinalProject
{
    public partial class FmAddTour : Form
    {
        public FmAddTour()
        {
            InitializeComponent();
        }

        public XmlDocument doc = new XmlDocument();
        public XmlElement root;

        private string fileName = @"..//..//data.xml";

        public void AddItem(string Title, string time, string startPlace, string destination, string price, string start, string count, string schedule, string pic1, string pic2, string pic3, string pic4)
        {
            doc.Load(fileName);

            root = doc.DocumentElement;

            XmlNode item = doc.CreateElement("tour");

            XmlElement Title_ = doc.CreateElement("title");
            Title_.InnerText = Title;
            item.AppendChild(Title_);

            XmlElement time_ = doc.CreateElement("time");
            time_.InnerText = time;
            item.AppendChild(time_);

            XmlElement startPlace_ = doc.CreateElement("startPlace");
            startPlace_.InnerText = startPlace;
            item.AppendChild(startPlace_);

            XmlElement destination_ = doc.CreateElement("destination");
            destination_.InnerText = destination;
            item.AppendChild(destination_);

            XmlElement price_ = doc.CreateElement("price");
            price_.InnerText = price;
            item.AppendChild(price_);

            XmlElement start_ = doc.CreateElement("start");
            start_.InnerText = start;
            item.AppendChild(start_);

            XmlElement count_ = doc.CreateElement("count");
            count_.InnerText = count;
            item.AppendChild(count_);

            XmlElement schedule_ = doc.CreateElement("schedule");
            schedule_.InnerText = schedule;
            item.AppendChild(schedule_);

            XmlElement pic1_ = doc.CreateElement("pic1");
            pic1_.InnerText = pic1;
            item.AppendChild(pic1_);

            XmlElement pic2_ = doc.CreateElement("pic2");
            pic2_.InnerText = pic2;
            item.AppendChild(pic2_);

            XmlElement pic3_ = doc.CreateElement("pic3");
            pic3_.InnerText = pic3;
            item.AppendChild(pic3_);

            XmlElement pic4_ = doc.CreateElement("pic4");
            pic4_.InnerText = pic4;
            item.AppendChild(pic4_);

            root.AppendChild(item);
            doc.Save(fileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtTitle.Text != "" || txtTime.Text != "" || txtStartPlace.Text != "" || txtDestination.Text != "" || txtPrice.Text != "" || txtCount.Text != "" || txtSchedule.Text != "" || pic1 != "" || pic2 != "" || pic3 != "" || pic4 != "")
            {
                AddItem(txtTitle.Text, txtTime.Text, txtStartPlace.Text, txtDestination.Text, txtPrice.Text, txtdateStart.Text, txtCount.Text, txtSchedule.Text, pic1, pic2, pic3, pic4);

            }    
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
        }

        public string ImageToBase64(string path)
        {
            // string path = "D:\SampleImage.jpg";
            using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }

        public string url = "";
        public string pic1, pic2, pic3, pic4;

        private void button5_Click(object sender, EventArgs e)
        {
            opendig();
            pic4 = ImageToBase64(url);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            opendig();
            pic3 = ImageToBase64(url);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            opendig();
            pic2 = ImageToBase64(url);
            //pictureBox2.Image = Base64ToImage(ImageToBase64(url));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opendig();
            pic1 = ImageToBase64(url);
        }

        public void opendig()
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(dlg.FileName);
                    url = dlg.FileName;
                }
            }
        }
    }
}
