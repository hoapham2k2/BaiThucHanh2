namespace BaiThucHanh2.Components
{
    partial class item
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
            this.components = new System.ComponentModel.Container();
            this.ptbAnh = new System.Windows.Forms.PictureBox();
            this.labelTen = new System.Windows.Forms.Label();
            this.labelGia = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbAnh
            // 
            this.ptbAnh.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbAnh.Location = new System.Drawing.Point(0, 0);
            this.ptbAnh.Name = "ptbAnh";
            this.ptbAnh.Size = new System.Drawing.Size(248, 199);
            this.ptbAnh.TabIndex = 0;
            this.ptbAnh.TabStop = false;
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Location = new System.Drawing.Point(85, 202);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(44, 16);
            this.labelTen.TabIndex = 1;
            this.labelTen.Text = "label1";
            // 
            // labelGia
            // 
            this.labelGia.AutoSize = true;
            this.labelGia.Location = new System.Drawing.Point(85, 231);
            this.labelGia.Name = "labelGia";
            this.labelGia.Size = new System.Drawing.Size(44, 16);
            this.labelGia.TabIndex = 2;
            this.labelGia.Text = "label2";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelGia);
            this.Controls.Add(this.labelTen);
            this.Controls.Add(this.ptbAnh);
            this.Name = "item";
            this.Size = new System.Drawing.Size(248, 270);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbAnh;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.Label labelGia;
        private System.Windows.Forms.ImageList imageList1;
    }
}
