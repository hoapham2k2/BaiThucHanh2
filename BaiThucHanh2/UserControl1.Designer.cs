namespace BaiThucHanh2
{
    partial class UserControl1
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
            this.ptbAnh = new System.Windows.Forms.PictureBox();
            this.labelTen = new System.Windows.Forms.Label();
            this.labelGia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbAnh
            // 
            this.ptbAnh.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbAnh.Location = new System.Drawing.Point(0, 0);
            this.ptbAnh.Name = "ptbAnh";
            this.ptbAnh.Size = new System.Drawing.Size(243, 215);
            this.ptbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnh.TabIndex = 0;
            this.ptbAnh.TabStop = false;
            // 
            // labelTen
            // 
            this.labelTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTen.ForeColor = System.Drawing.Color.Maroon;
            this.labelTen.Location = new System.Drawing.Point(20, 218);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(203, 29);
            this.labelTen.TabIndex = 1;
            this.labelTen.Text = "label1";
            this.labelTen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelGia
            // 
            this.labelGia.BackColor = System.Drawing.Color.Transparent;
            this.labelGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGia.Location = new System.Drawing.Point(45, 255);
            this.labelGia.Name = "labelGia";
            this.labelGia.Size = new System.Drawing.Size(154, 21);
            this.labelGia.TabIndex = 2;
            this.labelGia.Text = "label1";
            this.labelGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.labelGia);
            this.Controls.Add(this.labelTen);
            this.Controls.Add(this.ptbAnh);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(243, 294);
            this.Click += new System.EventHandler(this.UserControl1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbAnh;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.Label labelGia;
    }
}
