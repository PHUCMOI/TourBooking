namespace FinalProject
{
    partial class FmInformationCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmInformationCustomer));
            this.pnlControl = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBill = new System.Windows.Forms.Panel();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.PictureBox();
            this.btnMinus = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStartDay = new System.Windows.Forms.Label();
            this.lblTour = new System.Windows.Forms.Label();
            this.picTour = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ucContactCustomer1 = new FinalProject.UCContactCustomer();
            this.btnDatTour = new _20521782_TranMinhPhuc_BTTH2.RJButton();
            this.pnlBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.AutoScroll = true;
            this.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControl.Location = new System.Drawing.Point(12, 208);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1115, 476);
            this.pnlControl.TabIndex = 0;
            // 
            // pnlBill
            // 
            this.pnlBill.Controls.Add(this.lblSoLuong);
            this.pnlBill.Controls.Add(this.btnPlus);
            this.pnlBill.Controls.Add(this.btnMinus);
            this.pnlBill.Controls.Add(this.label2);
            this.pnlBill.Controls.Add(this.lbl);
            this.pnlBill.Controls.Add(this.lblPrice);
            this.pnlBill.Controls.Add(this.picTour);
            this.pnlBill.Controls.Add(this.flowLayoutPanel1);
            this.pnlBill.Location = new System.Drawing.Point(1134, 57);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(358, 492);
            this.pnlBill.TabIndex = 1;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(250, 373);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(23, 28);
            this.lblSoLuong.TabIndex = 9;
            this.lblSoLuong.Text = "1";
            // 
            // btnPlus
            // 
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.Image = ((System.Drawing.Image)(resources.GetObject("btnPlus.Image")));
            this.btnPlus.Location = new System.Drawing.Point(301, 377);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(25, 21);
            this.btnPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlus.TabIndex = 8;
            this.btnPlus.TabStop = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.Image = ((System.Drawing.Image)(resources.GetObject("btnMinus.Image")));
            this.btnMinus.Location = new System.Drawing.Point(200, 377);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(25, 21);
            this.btnMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinus.TabIndex = 7;
            this.btnMinus.TabStop = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 421);
            this.label2.MaximumSize = new System.Drawing.Size(340, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng cộng";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(17, 371);
            this.lbl.MaximumSize = new System.Drawing.Size(340, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(110, 32);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "So luong";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(186, 421);
            this.lblPrice.MaximumSize = new System.Drawing.Size(340, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(149, 32);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "10,000,000 đ\r\n";
            // 
            // lblStartDay
            // 
            this.lblStartDay.AutoSize = true;
            this.lblStartDay.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDay.Location = new System.Drawing.Point(71, 0);
            this.lblStartDay.MaximumSize = new System.Drawing.Size(340, 0);
            this.lblStartDay.Name = "lblStartDay";
            this.lblStartDay.Size = new System.Drawing.Size(125, 0);
            this.lblStartDay.TabIndex = 2;
            this.lblStartDay.Text = "Khoi hanh";
            // 
            // lblTour
            // 
            this.lblTour.AutoSize = true;
            this.lblTour.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTour.Location = new System.Drawing.Point(3, 0);
            this.lblTour.MaximumSize = new System.Drawing.Size(340, 0);
            this.lblTour.Name = "lblTour";
            this.lblTour.Size = new System.Drawing.Size(62, 0);
            this.lblTour.TabIndex = 1;
            this.lblTour.Text = "Tour";
            // 
            // picTour
            // 
            this.picTour.Location = new System.Drawing.Point(4, 4);
            this.picTour.Name = "picTour";
            this.picTour.Size = new System.Drawing.Size(351, 235);
            this.picTour.TabIndex = 0;
            this.picTour.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1452, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 6;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblTour);
            this.flowLayoutPanel1.Controls.Add(this.lblStartDay);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 240);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(351, 128);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // ucContactCustomer1
            // 
            this.ucContactCustomer1.AddressCus = "";
            this.ucContactCustomer1.BackColor = System.Drawing.Color.White;
            this.ucContactCustomer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucContactCustomer1.EmailCus = "";
            this.ucContactCustomer1.Location = new System.Drawing.Point(12, 12);
            this.ucContactCustomer1.Name = "ucContactCustomer1";
            this.ucContactCustomer1.NameCus = "";
            this.ucContactCustomer1.PhoneCus = "";
            this.ucContactCustomer1.Size = new System.Drawing.Size(1115, 181);
            this.ucContactCustomer1.TabIndex = 7;
            // 
            // btnDatTour
            // 
            this.btnDatTour.BackColor = System.Drawing.Color.Red;
            this.btnDatTour.BackgroundColor = System.Drawing.Color.Red;
            this.btnDatTour.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDatTour.BorderRadius = 20;
            this.btnDatTour.BorderSize = 0;
            this.btnDatTour.FlatAppearance.BorderSize = 0;
            this.btnDatTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatTour.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatTour.ForeColor = System.Drawing.Color.White;
            this.btnDatTour.Location = new System.Drawing.Point(1157, 555);
            this.btnDatTour.Name = "btnDatTour";
            this.btnDatTour.Size = new System.Drawing.Size(310, 50);
            this.btnDatTour.TabIndex = 5;
            this.btnDatTour.Text = "Đặt ngay";
            this.btnDatTour.TextColor = System.Drawing.Color.White;
            this.btnDatTour.UseVisualStyleBackColor = false;
            this.btnDatTour.Click += new System.EventHandler(this.btnDatTour_Click);
            // 
            // FmInformationCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1504, 696);
            this.Controls.Add(this.ucContactCustomer1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDatTour);
            this.Controls.Add(this.pnlBill);
            this.Controls.Add(this.pnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmInformationCustomer";
            this.Text = "FmInformationCustomer";
            this.Load += new System.EventHandler(this.FmInformationCustomer_Load);
            this.pnlBill.ResumeLayout(false);
            this.pnlBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlControl;
        private System.Windows.Forms.Panel pnlBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblStartDay;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.PictureBox picTour;
        private _20521782_TranMinhPhuc_BTTH2.RJButton btnDatTour;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.PictureBox btnPlus;
        private System.Windows.Forms.PictureBox btnMinus;
        private System.Windows.Forms.PictureBox btnExit;
        private UCContactCustomer ucContactCustomer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}