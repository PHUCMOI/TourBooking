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
            this.label3 = new System.Windows.Forms.Label();
            this.lblStartDay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTour = new System.Windows.Forms.PictureBox();
            this.btnDatTour = new _20521782_TranMinhPhuc_BTTH2.RJButton();
            this.pnlBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTour)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControl.Location = new System.Drawing.Point(12, 12);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(1115, 672);
            this.pnlControl.TabIndex = 0;
            // 
            // pnlBill
            // 
            this.pnlBill.Controls.Add(this.lblSoLuong);
            this.pnlBill.Controls.Add(this.btnPlus);
            this.pnlBill.Controls.Add(this.btnMinus);
            this.pnlBill.Controls.Add(this.label2);
            this.pnlBill.Controls.Add(this.lbl);
            this.pnlBill.Controls.Add(this.label3);
            this.pnlBill.Controls.Add(this.lblStartDay);
            this.pnlBill.Controls.Add(this.label1);
            this.pnlBill.Controls.Add(this.lblTour);
            this.pnlBill.Location = new System.Drawing.Point(1134, 13);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(358, 446);
            this.pnlBill.TabIndex = 1;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(248, 342);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(23, 28);
            this.lblSoLuong.TabIndex = 9;
            this.lblSoLuong.Text = "1";
            // 
            // btnPlus
            // 
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.Image = ((System.Drawing.Image)(resources.GetObject("btnPlus.Image")));
            this.btnPlus.Location = new System.Drawing.Point(299, 346);
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
            this.btnMinus.Location = new System.Drawing.Point(198, 346);
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
            this.label2.Location = new System.Drawing.Point(14, 390);
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
            this.lbl.Location = new System.Drawing.Point(15, 340);
            this.lbl.MaximumSize = new System.Drawing.Size(340, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(110, 32);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "So luong";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(184, 390);
            this.label3.MaximumSize = new System.Drawing.Size(340, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "10,000,000 đ\r\n";
            // 
            // lblStartDay
            // 
            this.lblStartDay.AutoSize = true;
            this.lblStartDay.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDay.Location = new System.Drawing.Point(14, 290);
            this.lblStartDay.MaximumSize = new System.Drawing.Size(340, 0);
            this.lblStartDay.Name = "lblStartDay";
            this.lblStartDay.Size = new System.Drawing.Size(125, 32);
            this.lblStartDay.TabIndex = 2;
            this.lblStartDay.Text = "Khoi hanh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 240);
            this.label1.MaximumSize = new System.Drawing.Size(340, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tour";
            // 
            // lblTour
            // 
            this.lblTour.Location = new System.Drawing.Point(4, 4);
            this.lblTour.Name = "lblTour";
            this.lblTour.Size = new System.Drawing.Size(351, 235);
            this.lblTour.TabIndex = 0;
            this.lblTour.TabStop = false;
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
            this.btnDatTour.Location = new System.Drawing.Point(1157, 478);
            this.btnDatTour.Name = "btnDatTour";
            this.btnDatTour.Size = new System.Drawing.Size(310, 50);
            this.btnDatTour.TabIndex = 5;
            this.btnDatTour.Text = "Đặt ngay";
            this.btnDatTour.TextColor = System.Drawing.Color.White;
            this.btnDatTour.UseVisualStyleBackColor = false;
            // 
            // FmInformationCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1504, 696);
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
            ((System.ComponentModel.ISupportInitialize)(this.lblTour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlControl;
        private System.Windows.Forms.Panel pnlBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblStartDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox lblTour;
        private _20521782_TranMinhPhuc_BTTH2.RJButton btnDatTour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.PictureBox btnPlus;
        private System.Windows.Forms.PictureBox btnMinus;
    }
}