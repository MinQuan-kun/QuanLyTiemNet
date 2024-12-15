namespace Do_anLaptrinhWinCK
{
    partial class frmDangky
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangky));
            this.panelScreen = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.Paneldk = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDk = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblusername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnDangky = new Guna.UI2.WinForms.Guna2Button();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panelScreen.SuspendLayout();
            this.Paneldk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelScreen
            // 
            this.panelScreen.Controls.Add(this.Paneldk);
            this.panelScreen.Controls.Add(this.guna2PictureBox2);
            this.panelScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScreen.Location = new System.Drawing.Point(0, 0);
            this.panelScreen.Name = "panelScreen";
            this.panelScreen.Size = new System.Drawing.Size(808, 540);
            this.panelScreen.TabIndex = 2;
            // 
            // Paneldk
            // 
            this.Paneldk.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Paneldk.BackgroundImage = global::Do_anLaptrinhWinCK.Properties.Resources.Screenshot_2024_11_29_133411;
            this.Paneldk.Controls.Add(this.lblDk);
            this.Paneldk.Controls.Add(this.lblusername);
            this.Paneldk.Controls.Add(this.btnDangky);
            this.Paneldk.Controls.Add(this.txtUser);
            this.Paneldk.Location = new System.Drawing.Point(272, 76);
            this.Paneldk.Name = "Paneldk";
            this.Paneldk.Size = new System.Drawing.Size(282, 255);
            this.Paneldk.TabIndex = 3;
            // 
            // lblDk
            // 
            this.lblDk.BackColor = System.Drawing.Color.Transparent;
            this.lblDk.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDk.Location = new System.Drawing.Point(50, 43);
            this.lblDk.Name = "lblDk";
            this.lblDk.Size = new System.Drawing.Size(190, 32);
            this.lblDk.TabIndex = 16;
            this.lblDk.Text = "Đăng ký tài khoản";
            // 
            // lblusername
            // 
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblusername.Location = new System.Drawing.Point(61, 102);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(64, 19);
            this.lblusername.TabIndex = 7;
            this.lblusername.Text = "Username";
            // 
            // btnDangky
            // 
            this.btnDangky.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangky.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangky.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangky.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangky.FillColor = System.Drawing.Color.White;
            this.btnDangky.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangky.ForeColor = System.Drawing.Color.Black;
            this.btnDangky.Location = new System.Drawing.Point(93, 188);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(94, 30);
            this.btnDangky.TabIndex = 1;
            this.btnDangky.Text = "Đăng ký";
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // txtUser
            // 
            this.txtUser.BorderColor = System.Drawing.Color.White;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "";
            this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.Location = new System.Drawing.Point(61, 128);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PlaceholderText = "";
            this.txtUser.SelectedText = "";
            this.txtUser.Size = new System.Drawing.Size(152, 25);
            this.txtUser.TabIndex = 3;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox2.Image = global::Do_anLaptrinhWinCK.Properties.Resources.ff5c3321a863db98821f6045453aac9b;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(808, 540);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // frmDangky
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(808, 540);
            this.Controls.Add(this.panelScreen);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.frmDangky_Load);
            this.panelScreen.ResumeLayout(false);
            this.Paneldk.ResumeLayout(false);
            this.Paneldk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelScreen;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDk;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblusername;
        private Guna.UI2.WinForms.Guna2Button btnDangky;
        public Guna.UI2.WinForms.Guna2TextBox txtUser;
        public Guna.UI2.WinForms.Guna2Panel Paneldk;
    }
}