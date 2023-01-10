using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;

namespace FinalProject
{
    public partial class FmSendGamilCus : Form
    {
        public FmSendGamilCus()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            lblLinkFiles.Text = openFileDialog1.FileName;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                mailMessage.From = new MailAddress(txtFrom.Text);
                mailMessage.Subject = txtTitle.Text;
                mailMessage.Body = txtBody.Text;
                //mailMessage.To.Add("tmp8122017@gmail.com"); 
                mailMessage.To.Add("20521769@gm.uit.edu.vn");

                System.Net.Mail.Attachment attachment;
                attachment = new Attachment(lblLinkFiles.Text);
                mailMessage.Attachments.Add(attachment);

                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential(txtFrom.Text, txtPassword.Text);
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
                MessageBox.Show("Sended", "Sended", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
