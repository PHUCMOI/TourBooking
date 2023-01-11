using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class UCItem : UserControl
    {
        public event EventHandler OnSelect = null;
        public UCItem()
        {
            InitializeComponent();
        }

        public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }
        public string Time { get => lblTime.Text; set => lblTime.Text = value; }
        public string Price { get => lblPrice.Text; set => lblPrice.Text = value; }
        public Image ImageTour { get => picTour.Image; set => picTour.Image = value; }
        public string destination { get => label2.Text; set => label2.Text = value; }

        public string StartPlace { get => label1.Text; set => label1.Text = value; }

        private void UCItem_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
        }

        private void UCItem_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
