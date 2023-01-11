using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Image = System.Drawing.Image;
using Font = iTextSharp.text.Font;
using System.Net.Mail;

namespace FinalProject
{
    public partial class FmPayment : Form
    {
        private string TourName = "";
        private string KhoiHanh = "";
        private Image picTour_;
        private string price_ = "";
        public FmPayment(string tourName, string khoiHanh, Image picTour, string price_)
        {
            InitializeComponent();
            TourName = tourName;
            KhoiHanh = khoiHanh;
            this.picTour_ = picTour;
            this.price_ = price_;
        }

        private void FmPayment_Load(object sender, EventArgs e)
        {
            picTour.Image = picTour_;
            lblTour.Text = TourName;
            lblStartDay.Text = KhoiHanh;
            lblPrice.Text = price_;
            for (int i = 0; i < FmInformationCustomer.bookeds.Count; i++)
            {
                for(int j = 0; j < FmInformationCustomer.bookeds[i].getset_NameCus.Count; j++)
                {
                    var uCDeatilCustomer = new UCDeatilCustomer()
                    {
                        Name = FmInformationCustomer.bookeds[i].getset_NameCus[j],
                        Gender = FmInformationCustomer.bookeds[i].getset_GenderCus[j],
                        DayOfBirth = FmInformationCustomer.bookeds[i].getset_DayOfBirthCus[j]
                    };
                    pnlControl.Controls.Add(uCDeatilCustomer);               
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DataTable MakeDataTable()
        {
            //Create friend table object
            DataTable Customers = new DataTable();

            //Define columns
            Customers.Columns.Add("STT");
            Customers.Columns.Add("Họ và Tên");
            Customers.Columns.Add("Giới tính");
            Customers.Columns.Add("Ngày sinh");

            //Populate with friends :)
            for(int i = 0; i < FmInformationCustomer.bookeds.Count; i++)
            {
                for(int j = 0; j < FmInformationCustomer.bookeds[i].getset_NameCus.Count;j++)
                {
                    Customers.Rows.Add(j + 1,
                        FmInformationCustomer.bookeds[i].getset_NameCus[j],
                        FmInformationCustomer.bookeds[i].getset_GenderCus[j],
                        FmInformationCustomer.bookeds[i].getset_DayOfBirthCus[j]);
                }    
            }    
            /*friend.Rows.Add("1", "Smith", "United State", "California");
            friend.Rows.Add("2", "Jack", "United Kingdom", "London");
            friend.Rows.Add("3", "Kajal Singh", "India", "Delhi");
            friend.Rows.Add("4", "Emmanuel", "South Africa", "Pretoria");
            friend.Rows.Add("5", "Lucas", "Germany", "Berlin");
            friend.Rows.Add("6", "Khalid", "UAE", "Dubai");
            friend.Rows.Add("7", "William", "Australia", "Canberra");*/

            return Customers;
        }

        void ExportDataTableToPdf(DataTable dtblTable, String strPdfPath, string strHeader)
        {
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntHead = new Font(bfntHead, 16, 1, iTextSharp.text.BaseColor.BLACK);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAuthor = new Font(btnAuthor, 8, 2, iTextSharp.text.BaseColor.GRAY);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("\nDate : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Add line break
            //document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, iTextSharp.text.BaseColor.WHITE);
            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = iTextSharp.text.BaseColor.GRAY;
                cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    table.AddCell(dtblTable.Rows[i][j].ToString());
                }
            }

            BaseFont bfntInfo = BaseFont.CreateFont("C:\\C#\\TourBooking\\FinalProject\\times-ro.ttf", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntInfo = new Font(bfntInfo, 13, 1, iTextSharp.text.BaseColor.BLACK);
            document.Add(new Chunk("Dear \n", fntInfo));
            document.Add(new Chunk("Thank you very much for using our service.\n", fntInfo));
            document.Add(new Chunk("TOURNAMENT TRAVEL would like to send you a tour registration invoice " + TourName + " " + KhoiHanh
                + " we send you trip information.\n", fntInfo));
            document.Add(new Chunk("\nFor more information, please contact us via fanpage, gmail and phone number.\n", fntInfo));

            document.Add(new Chunk("Customer contact information:" + FmInformationCustomer.bookeds[0].getset_NameBookedCus[0] + "\n" , fntInfo));
            document.Add(new Chunk("                                       " + FmInformationCustomer.bookeds[0].getset_PhoneBookedCus[0] + "\n" , fntInfo));
            document.Add(new Chunk("                                       " + FmInformationCustomer.bookeds[0].getset_EmailBookedCus[0] + "\n", fntInfo));


            document.Add(table);

            document.Add(new Chunk("Total " + price_ + "VND\n", fntInfo));

            if (rdoATM.Checked)
            {
                document.Add(new Chunk("You have successfully paid via Internet Banking service! Please arrive at the meeting point to collect your tickets before departure time.\n", fntInfo));
                document.Add(new Chunk("\r\nBest regards,\n", fntInfo));
                document.Add(new Chunk("TOURNAMENT TRAVEL.\n", fntInfo));
            }
            else
            {
                document.Add(new Chunk("\r\nPlease go to the company headquarters at the University of Information Technology to pay!\n", fntInfo));
                document.Add(new Chunk("Best regards,,\n", fntInfo));
                document.Add(new Chunk("TOURNAMENT TRAVEL.\n", fntInfo));
            }

            document.Add(new Chunk("Address: Trường Đại học Công Nghệ Thông tin\n", fntInfo));
            document.Add(new Chunk("Phone Number: 0835413038\n", fntInfo));
            document.Add(new Chunk("Email: 20521782@gm.uit.edu.vn\n", fntInfo));

            document.Close();
            writer.Close();
            fs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDatTour_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtbl = MakeDataTable();
                if (rdoATM.Checked || rdoCash.Checked)
                {
                    ExportDataTableToPdf(dtbl, @"Travel.pdf" , "TOURNAMENT TRAVEL");
                    System.Diagnostics.Process.Start(@"Travel.pdf");
                    this.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }

            try
            {
                MailMessage mailMessage = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                mailMessage.From = new MailAddress("20521782@gm.uit.edu.vn");
                mailMessage.Subject = "THÔNG TIN DU LỊCH";
                mailMessage.Body = "TOURNAMENT TRAVEL gửi quý khách thông tin chuyến du lịch.";
                //mailMessage.To.Add("tmp8122017@gmail.com"); 
                mailMessage.To.Add(FmInformationCustomer.bookeds[0].getset_EmailBookedCus[0]);

                System.Net.Mail.Attachment attachment;
                attachment = new Attachment(@"test.pdf");
                mailMessage.Attachments.Add(attachment);

                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential("20521782@gm.uit.edu.vn", "Minhphuc0159@");
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
                MessageBox.Show("Sended", "Sended", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if(FmSignUp.flag == false)
            {
                FmHome fmHome = new FmHome(false);
                fmHome.Show();
                this.Close();
            }
            else
            {
                FmHome fmHome = new FmHome(true);
                fmHome.Show();
                this.Close();
            }
            
        }
    }
}
