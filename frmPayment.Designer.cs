namespace Do_anLaptrinhWinCK
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.picturethanhtoan = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblHinhthuc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnTienmat = new Guna.UI2.WinForms.Guna2Button();
            this.btnCk = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturethanhtoan)).BeginInit();
            this.SuspendLayout();
            // 
            // picturethanhtoan
            // 
            this.picturethanhtoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturethanhtoan.Image = global::Do_anLaptrinhWinCK.Properties.Resources.hinh_nen_may_tinh_meme_22;
            this.picturethanhtoan.ImageRotate = 0F;
            this.picturethanhtoan.Location = new System.Drawing.Point(0, 0);
            this.picturethanhtoan.Name = "picturethanhtoan";
            this.picturethanhtoan.Size = new System.Drawing.Size(396, 241);
            this.picturethanhtoan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturethanhtoan.TabIndex = 0;
            this.picturethanhtoan.TabStop = false;
            // 
            // lblHinhthuc
            // 
            this.lblHinhthuc.BackColor = System.Drawing.Color.Transparent;
            this.lblHinhthuc.BackgroundImage = global::Do_anLaptrinhWinCK.Properties.Resources.hinh_nen_may_tinh_meme_22;
            this.lblHinhthuc.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinhthuc.ForeColor = System.Drawing.Color.Red;
            this.lblHinhthuc.Location = new System.Drawing.Point(83, 64);
            this.lblHinhthuc.Name = "lblHinhthuc";
            this.lblHinhthuc.Size = new System.Drawing.Size(216, 25);
            this.lblHinhthuc.TabIndex = 1;
            this.lblHinhthuc.Text = "Chọn hình thức thanh toán";
            // 
            // btnTienmat
            // 
            this.btnTienmat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTienmat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTienmat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTienmat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTienmat.FillColor = System.Drawing.Color.Black;
            this.btnTienmat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTienmat.ForeColor = System.Drawing.Color.White;
            this.btnTienmat.Location = new System.Drawing.Point(39, 127);
            this.btnTienmat.Name = "btnTienmat";
            this.btnTienmat.Size = new System.Drawing.Size(130, 38);
            this.btnTienmat.TabIndex = 2;
            this.btnTienmat.Text = "Tiền mặt";
            this.btnTienmat.Click += new System.EventHandler(this.btnTienmat_Click);
            // 
            // btnCk
            // 
            this.btnCk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCk.FillColor = System.Drawing.Color.Black;
            this.btnCk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCk.ForeColor = System.Drawing.Color.White;
            this.btnCk.Location = new System.Drawing.Point(215, 127);
            this.btnCk.Name = "btnCk";
            this.btnCk.Size = new System.Drawing.Size(130, 38);
            this.btnCk.TabIndex = 3;
            this.btnCk.Text = "Chuyển khoản";
            this.btnCk.Click += new System.EventHandler(this.btnCk_Click);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 241);
            this.Controls.Add(this.btnCk);
            this.Controls.Add(this.btnTienmat);
            this.Controls.Add(this.lblHinhthuc);
            this.Controls.Add(this.picturethanhtoan);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phương thức thanh toán";
            ((System.ComponentModel.ISupportInitialize)(this.picturethanhtoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picturethanhtoan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHinhthuc;
        private Guna.UI2.WinForms.Guna2Button btnTienmat;
        private Guna.UI2.WinForms.Guna2Button btnCk;
    }
}