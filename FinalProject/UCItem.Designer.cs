namespace FinalProject
{
    partial class UCItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.picTour = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTour)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 336);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(121, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Tên tour";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(5, 383);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(97, 28);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Thời gian";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(350, 457);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(115, 32);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "10000000";
            // 
            // picTour
            // 
            this.picTour.Location = new System.Drawing.Point(4, 4);
            this.picTour.Name = "picTour";
            this.picTour.Size = new System.Drawing.Size(493, 329);
            this.picTour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTour.TabIndex = 0;
            this.picTour.TabStop = false;
            // 
            // UCItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picTour);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UCItem";
            this.Size = new System.Drawing.Size(502, 502);
            this.Load += new System.EventHandler(this.UCItem_Load);
            this.Click += new System.EventHandler(this.UCItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picTour;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.Label lblPrice;
    }
}
