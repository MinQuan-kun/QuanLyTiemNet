namespace Do_anLaptrinhWinCK
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnHethong = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.subpanelHethong = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.subpanelDanhmuc = new System.Windows.Forms.Panel();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnHoadon = new System.Windows.Forms.Button();
            this.btnTaikhoan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHopThu = new System.Windows.Forms.Button();
            this.subpanelChucnang = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDangky = new System.Windows.Forms.Button();
            this.btnNhaphang = new System.Windows.Forms.Button();
            this.btnDangkythe = new System.Windows.Forms.Button();
            this.btnChucnang = new System.Windows.Forms.Button();
            this.btnDanhmuc = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.txtDate = new System.Windows.Forms.ToolStripLabel();
            this.lblInfor = new System.Windows.Forms.ToolStripLabel();
            this.Logout = new System.Windows.Forms.ToolStripButton();
            this.register = new System.Windows.Forms.ToolStripButton();
            this.panelhethong = new System.Windows.Forms.Panel();
            this.btnminisize = new Guna.UI2.WinForms.Guna2Button();
            this.btnfullsize = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PanelMain = new System.Windows.Forms.Panel();
            this.The = new Do_anLaptrinhWinCK.All_Cards.Cards();
            this.Taikhoan = new Do_anLaptrinhWinCK.All_Customer.Taikhoan();
            this.ThucDon = new Do_anLaptrinhWinCK.All_Computer.ThucDon();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.subpanelHethong.SuspendLayout();
            this.subpanelDanhmuc.SuspendLayout();
            this.panel1.SuspendLayout();
            this.subpanelChucnang.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panelhethong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnHethong
            // 
            this.btnHethong.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHethong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHethong.FlatAppearance.BorderSize = 0;
            this.btnHethong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHethong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHethong.Location = new System.Drawing.Point(0, 100);
            this.btnHethong.Name = "btnHethong";
            this.btnHethong.Size = new System.Drawing.Size(225, 52);
            this.btnHethong.TabIndex = 1;
            this.btnHethong.Text = "Hệ thống";
            this.btnHethong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHethong.UseVisualStyleBackColor = false;
            this.btnHethong.Click += new System.EventHandler(this.btnHethong_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(225, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hệ thống quản lý tiệm net";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // subpanelHethong
            // 
            this.subpanelHethong.Controls.Add(this.btnThoat);
            this.subpanelHethong.Controls.Add(this.btnDangxuat);
            this.subpanelHethong.Dock = System.Windows.Forms.DockStyle.Top;
            this.subpanelHethong.Location = new System.Drawing.Point(0, 152);
            this.subpanelHethong.Name = "subpanelHethong";
            this.subpanelHethong.Size = new System.Drawing.Size(225, 78);
            this.subpanelHethong.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(0, 37);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnThoat.Size = new System.Drawing.Size(225, 39);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDangxuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangxuat.FlatAppearance.BorderSize = 0;
            this.btnDangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangxuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangxuat.Location = new System.Drawing.Point(0, 0);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDangxuat.Size = new System.Drawing.Size(225, 37);
            this.btnDangxuat.TabIndex = 8;
            this.btnDangxuat.Text = "Đăng xuất";
            this.btnDangxuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangxuat.UseVisualStyleBackColor = false;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // subpanelDanhmuc
            // 
            this.subpanelDanhmuc.Controls.Add(this.btnCard);
            this.subpanelDanhmuc.Controls.Add(this.btnMenu);
            this.subpanelDanhmuc.Controls.Add(this.btnHoadon);
            this.subpanelDanhmuc.Controls.Add(this.btnTaikhoan);
            this.subpanelDanhmuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.subpanelDanhmuc.Location = new System.Drawing.Point(0, 278);
            this.subpanelDanhmuc.Name = "subpanelDanhmuc";
            this.subpanelDanhmuc.Size = new System.Drawing.Size(225, 167);
            this.subpanelDanhmuc.TabIndex = 4;
            // 
            // btnCard
            // 
            this.btnCard.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCard.FlatAppearance.BorderSize = 0;
            this.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCard.Location = new System.Drawing.Point(0, 121);
            this.btnCard.Name = "btnCard";
            this.btnCard.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCard.Size = new System.Drawing.Size(225, 40);
            this.btnCard.TabIndex = 6;
            this.btnCard.Text = "Thẻ";
            this.btnCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCard.UseVisualStyleBackColor = false;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Location = new System.Drawing.Point(0, 81);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(225, 40);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnHoadon
            // 
            this.btnHoadon.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoadon.FlatAppearance.BorderSize = 0;
            this.btnHoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoadon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHoadon.Location = new System.Drawing.Point(0, 40);
            this.btnHoadon.Name = "btnHoadon";
            this.btnHoadon.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHoadon.Size = new System.Drawing.Size(225, 41);
            this.btnHoadon.TabIndex = 3;
            this.btnHoadon.Text = "Hóa đơn";
            this.btnHoadon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoadon.UseVisualStyleBackColor = false;
            this.btnHoadon.Click += new System.EventHandler(this.btnHoadon_Click);
            // 
            // btnTaikhoan
            // 
            this.btnTaikhoan.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTaikhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaikhoan.FlatAppearance.BorderSize = 0;
            this.btnTaikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaikhoan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTaikhoan.Location = new System.Drawing.Point(0, 0);
            this.btnTaikhoan.Name = "btnTaikhoan";
            this.btnTaikhoan.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTaikhoan.Size = new System.Drawing.Size(225, 40);
            this.btnTaikhoan.TabIndex = 0;
            this.btnTaikhoan.Text = "Tài khoản";
            this.btnTaikhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaikhoan.UseVisualStyleBackColor = false;
            this.btnTaikhoan.Click += new System.EventHandler(this.btnTaikhoan_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnHopThu);
            this.panel1.Controls.Add(this.subpanelChucnang);
            this.panel1.Controls.Add(this.btnChucnang);
            this.panel1.Controls.Add(this.subpanelDanhmuc);
            this.panel1.Controls.Add(this.btnDanhmuc);
            this.panel1.Controls.Add(this.subpanelHethong);
            this.panel1.Controls.Add(this.btnHethong);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 700);
            this.panel1.TabIndex = 9;
            // 
            // btnHopThu
            // 
            this.btnHopThu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHopThu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHopThu.FlatAppearance.BorderSize = 0;
            this.btnHopThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHopThu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHopThu.Location = new System.Drawing.Point(0, 718);
            this.btnHopThu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHopThu.Name = "btnHopThu";
            this.btnHopThu.Padding = new System.Windows.Forms.Padding(48, 0, 0, 0);
            this.btnHopThu.Size = new System.Drawing.Size(225, 43);
            this.btnHopThu.TabIndex = 17;
            this.btnHopThu.Text = "Hộp thư";
            this.btnHopThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHopThu.UseVisualStyleBackColor = false;
            this.btnHopThu.Click += new System.EventHandler(this.btnHopThu_Click);
            // 
            // subpanelChucnang
            // 
            this.subpanelChucnang.Controls.Add(this.btnReset);
            this.subpanelChucnang.Controls.Add(this.btnDangky);
            this.subpanelChucnang.Controls.Add(this.btnNhaphang);
            this.subpanelChucnang.Controls.Add(this.btnDangkythe);
            this.subpanelChucnang.Dock = System.Windows.Forms.DockStyle.Top;
            this.subpanelChucnang.Location = new System.Drawing.Point(0, 493);
            this.subpanelChucnang.Name = "subpanelChucnang";
            this.subpanelChucnang.Size = new System.Drawing.Size(225, 225);
            this.subpanelChucnang.TabIndex = 8;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(0, 129);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReset.Size = new System.Drawing.Size(225, 43);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset mật khẩu";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDangky
            // 
            this.btnDangky.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDangky.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangky.FlatAppearance.BorderSize = 0;
            this.btnDangky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangky.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangky.Location = new System.Drawing.Point(0, 86);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDangky.Size = new System.Drawing.Size(225, 43);
            this.btnDangky.TabIndex = 14;
            this.btnDangky.Text = "Đăng ký tài khoản";
            this.btnDangky.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangky.UseVisualStyleBackColor = false;
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // btnNhaphang
            // 
            this.btnNhaphang.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNhaphang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhaphang.FlatAppearance.BorderSize = 0;
            this.btnNhaphang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhaphang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNhaphang.Location = new System.Drawing.Point(0, 43);
            this.btnNhaphang.Name = "btnNhaphang";
            this.btnNhaphang.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNhaphang.Size = new System.Drawing.Size(225, 43);
            this.btnNhaphang.TabIndex = 13;
            this.btnNhaphang.Text = "Nhập hàng";
            this.btnNhaphang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhaphang.UseVisualStyleBackColor = false;
            this.btnNhaphang.Click += new System.EventHandler(this.btnNhaphang_Click);
            // 
            // btnDangkythe
            // 
            this.btnDangkythe.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDangkythe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangkythe.FlatAppearance.BorderSize = 0;
            this.btnDangkythe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangkythe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangkythe.Location = new System.Drawing.Point(0, 0);
            this.btnDangkythe.Name = "btnDangkythe";
            this.btnDangkythe.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDangkythe.Size = new System.Drawing.Size(225, 43);
            this.btnDangkythe.TabIndex = 12;
            this.btnDangkythe.Text = "Đăng ký thẻ";
            this.btnDangkythe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangkythe.UseVisualStyleBackColor = false;
            this.btnDangkythe.Click += new System.EventHandler(this.btnDangkythe_Click);
            // 
            // btnChucnang
            // 
            this.btnChucnang.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChucnang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChucnang.FlatAppearance.BorderSize = 0;
            this.btnChucnang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChucnang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChucnang.Location = new System.Drawing.Point(0, 445);
            this.btnChucnang.Name = "btnChucnang";
            this.btnChucnang.Size = new System.Drawing.Size(225, 48);
            this.btnChucnang.TabIndex = 6;
            this.btnChucnang.Text = "Chức năng";
            this.btnChucnang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChucnang.UseVisualStyleBackColor = false;
            this.btnChucnang.Click += new System.EventHandler(this.btnChucnang_Click);
            // 
            // btnDanhmuc
            // 
            this.btnDanhmuc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDanhmuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhmuc.FlatAppearance.BorderSize = 0;
            this.btnDanhmuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhmuc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDanhmuc.Location = new System.Drawing.Point(0, 230);
            this.btnDanhmuc.Name = "btnDanhmuc";
            this.btnDanhmuc.Size = new System.Drawing.Size(225, 48);
            this.btnDanhmuc.TabIndex = 3;
            this.btnDanhmuc.Text = "Danh mục";
            this.btnDanhmuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhmuc.UseVisualStyleBackColor = false;
            this.btnDanhmuc.Click += new System.EventHandler(this.btnDanhmuc_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Black;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtDate,
            this.lblInfor,
            this.Logout,
            this.register});
            this.toolStrip2.Location = new System.Drawing.Point(6, 9);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(321, 27);
            this.toolStrip2.TabIndex = 11;
            this.toolStrip2.Text = "Bạn chưa đăng nhập";
            // 
            // txtDate
            // 
            this.txtDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(111, 24);
            this.txtDate.Text = "toolStripLabel1";
            // 
            // lblInfor
            // 
            this.lblInfor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfor.Name = "lblInfor";
            this.lblInfor.Size = new System.Drawing.Size(149, 24);
            this.lblInfor.Text = "Bạn chưa đăng nhập!";
            // 
            // Logout
            // 
            this.Logout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(29, 24);
            this.Logout.Text = "Đăng xuất";
            this.Logout.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // register
            // 
            this.register.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.register.Image = global::Do_anLaptrinhWinCK.Properties.Resources.Add_User_Male;
            this.register.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(29, 24);
            this.register.Text = "register";
            this.register.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // panelhethong
            // 
            this.panelhethong.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelhethong.Controls.Add(this.btnminisize);
            this.panelhethong.Controls.Add(this.btnfullsize);
            this.panelhethong.Controls.Add(this.toolStrip2);
            this.panelhethong.Controls.Add(this.pictureBox4);
            this.panelhethong.Controls.Add(this.btnClose);
            this.panelhethong.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelhethong.Location = new System.Drawing.Point(246, 0);
            this.panelhethong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelhethong.Name = "panelhethong";
            this.panelhethong.Size = new System.Drawing.Size(804, 36);
            this.panelhethong.TabIndex = 13;
            // 
            // btnminisize
            // 
            this.btnminisize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnminisize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnminisize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnminisize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnminisize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnminisize.FillColor = System.Drawing.Color.Black;
            this.btnminisize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnminisize.ForeColor = System.Drawing.Color.White;
            this.btnminisize.Image = global::Do_anLaptrinhWinCK.Properties.Resources.Minimize_Window;
            this.btnminisize.Location = new System.Drawing.Point(699, 0);
            this.btnminisize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnminisize.Name = "btnminisize";
            this.btnminisize.Size = new System.Drawing.Size(35, 36);
            this.btnminisize.TabIndex = 15;
            this.btnminisize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnminisize.Click += new System.EventHandler(this.btnminisize_Click);
            // 
            // btnfullsize
            // 
            this.btnfullsize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnfullsize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnfullsize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnfullsize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnfullsize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnfullsize.FillColor = System.Drawing.Color.Black;
            this.btnfullsize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnfullsize.ForeColor = System.Drawing.Color.White;
            this.btnfullsize.Image = global::Do_anLaptrinhWinCK.Properties.Resources.Toggle_Full_Screen;
            this.btnfullsize.Location = new System.Drawing.Point(734, 0);
            this.btnfullsize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnfullsize.Name = "btnfullsize";
            this.btnfullsize.Size = new System.Drawing.Size(35, 36);
            this.btnfullsize.TabIndex = 14;
            this.btnfullsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnfullsize.Click += new System.EventHandler(this.btnfullsize_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-15, -13);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(225, 200);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FillColor = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::Do_anLaptrinhWinCK.Properties.Resources.close123;
            this.btnClose.Location = new System.Drawing.Point(769, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelMain.Controls.Add(this.The);
            this.PanelMain.Controls.Add(this.Taikhoan);
            this.PanelMain.Controls.Add(this.ThucDon);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(246, 36);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(804, 664);
            this.PanelMain.TabIndex = 14;
            this.PanelMain.Resize += new System.EventHandler(this.PanelMain_Resize);
            // 
            // The
            // 
            this.The.Dock = System.Windows.Forms.DockStyle.Fill;
            this.The.Location = new System.Drawing.Point(0, 0);
            this.The.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.The.Name = "The";
            this.The.Size = new System.Drawing.Size(804, 664);
            this.The.TabIndex = 2;
            // 
            // Taikhoan
            // 
            this.Taikhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Taikhoan.Location = new System.Drawing.Point(0, 0);
            this.Taikhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Taikhoan.Name = "Taikhoan";
            this.Taikhoan.Size = new System.Drawing.Size(804, 664);
            this.Taikhoan.TabIndex = 1;
            // 
            // ThucDon
            // 
            this.ThucDon.AutoSize = true;
            this.ThucDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThucDon.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThucDon.Location = new System.Drawing.Point(0, 0);
            this.ThucDon.Name = "ThucDon";
            this.ThucDon.Size = new System.Drawing.Size(804, 664);
            this.ThucDon.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1050, 700);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.panelhethong);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1050, 700);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý tiệm net";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.subpanelHethong.ResumeLayout(false);
            this.subpanelDanhmuc.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.subpanelChucnang.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panelhethong.ResumeLayout(false);
            this.panelhethong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHethong;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel subpanelHethong;
        private System.Windows.Forms.Panel subpanelDanhmuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel txtDate;
        private System.Windows.Forms.ToolStripLabel lblInfor;
        private System.Windows.Forms.ToolStripButton Logout;
        private System.Windows.Forms.Panel panelhethong;
        private Guna.UI2.WinForms.Guna2Button btnfullsize;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnminisize;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHoadon;
        private System.Windows.Forms.Button btnTaikhoan;
        private System.Windows.Forms.Button btnChucnang;
        private System.Windows.Forms.Button btnDanhmuc;
        private System.Windows.Forms.Button btnDangxuat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel subpanelChucnang;
        private System.Windows.Forms.ToolStripButton register;
        private System.Windows.Forms.Button btnDangkythe;
        private System.Windows.Forms.Panel PanelMain;
        public All_Customer.Taikhoan Taikhoan;
        public All_Computer.ThucDon ThucDon;
        private System.Windows.Forms.Button btnNhaphang;
        private System.Windows.Forms.Button btnCard;
        public All_Cards.Cards The;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnHopThu;
    }
}