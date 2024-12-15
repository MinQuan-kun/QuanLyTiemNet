namespace Do_anLaptrinhWinCK
{
    partial class frmOrder
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
            this.PanelChucnang = new System.Windows.Forms.Panel();
            this.panelchitiet = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvorder = new System.Windows.Forms.DataGridView();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelthanhtien = new System.Windows.Forms.Panel();
            this.lblTongtien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.paneltieude = new System.Windows.Forms.Panel();
            this.lblMenu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PanelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.panelhinh = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtprice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbldongia = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTenmon = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbltenmon = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblsoluong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSoluong = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnxem = new Guna.UI2.WinForms.Guna2Button();
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnlammoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnxoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnKem = new Guna.UI2.WinForms.Guna2Button();
            this.btnNuoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnCom = new Guna.UI2.WinForms.Guna2Button();
            this.btnMi = new Guna.UI2.WinForms.Guna2Button();
            this.btnSnack = new Guna.UI2.WinForms.Guna2Button();
            this.PanelChucnang.SuspendLayout();
            this.panelchitiet.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorder)).BeginInit();
            this.panelthanhtien.SuspendLayout();
            this.paneltieude.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelChucnang
            // 
            this.PanelChucnang.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelChucnang.Controls.Add(this.btnxem);
            this.PanelChucnang.Controls.Add(this.btnAll);
            this.PanelChucnang.Controls.Add(this.btnOrder);
            this.PanelChucnang.Controls.Add(this.btnlammoi);
            this.PanelChucnang.Controls.Add(this.btnxoa);
            this.PanelChucnang.Controls.Add(this.btnKem);
            this.PanelChucnang.Controls.Add(this.btnNuoc);
            this.PanelChucnang.Controls.Add(this.btnCom);
            this.PanelChucnang.Controls.Add(this.btnMi);
            this.PanelChucnang.Controls.Add(this.btnSnack);
            this.PanelChucnang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelChucnang.Location = new System.Drawing.Point(0, 482);
            this.PanelChucnang.Name = "PanelChucnang";
            this.PanelChucnang.Size = new System.Drawing.Size(807, 49);
            this.PanelChucnang.TabIndex = 0;
            // 
            // panelchitiet
            // 
            this.panelchitiet.Controls.Add(this.guna2Panel1);
            this.panelchitiet.Controls.Add(this.panelthanhtien);
            this.panelchitiet.Controls.Add(this.paneltieude);
            this.panelchitiet.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelchitiet.Location = new System.Drawing.Point(414, 0);
            this.panelchitiet.Name = "panelchitiet";
            this.panelchitiet.Size = new System.Drawing.Size(393, 482);
            this.panelchitiet.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.dgvorder);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 66);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(393, 375);
            this.guna2Panel1.TabIndex = 3;
            // 
            // dgvorder
            // 
            this.dgvorder.AllowUserToAddRows = false;
            this.dgvorder.AllowUserToDeleteRows = false;
            this.dgvorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodName,
            this.Price,
            this.Quantity,
            this.TotalPrice});
            this.dgvorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvorder.Location = new System.Drawing.Point(0, 0);
            this.dgvorder.Name = "dgvorder";
            this.dgvorder.ReadOnly = true;
            this.dgvorder.RowHeadersWidth = 51;
            this.dgvorder.RowTemplate.Height = 24;
            this.dgvorder.Size = new System.Drawing.Size(393, 375);
            this.dgvorder.TabIndex = 2;
            this.dgvorder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvorder_CellClick);
            // 
            // FoodName
            // 
            this.FoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodName.DataPropertyName = "FoodName";
            this.FoodName.HeaderText = "Tên món";
            this.FoodName.MinimumWidth = 6;
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Đơn giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 83;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 90;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Thành tiền";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 90;
            // 
            // panelthanhtien
            // 
            this.panelthanhtien.Controls.Add(this.lblTongtien);
            this.panelthanhtien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelthanhtien.Location = new System.Drawing.Point(0, 441);
            this.panelthanhtien.Name = "panelthanhtien";
            this.panelthanhtien.Size = new System.Drawing.Size(393, 41);
            this.panelthanhtien.TabIndex = 2;
            // 
            // lblTongtien
            // 
            this.lblTongtien.BackColor = System.Drawing.Color.Transparent;
            this.lblTongtien.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTongtien.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongtien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTongtien.Location = new System.Drawing.Point(0, 0);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(174, 25);
            this.lblTongtien.TabIndex = 1;
            this.lblTongtien.Text = "Tổng tiền: 0.00 VNĐ";
            this.lblTongtien.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paneltieude
            // 
            this.paneltieude.Controls.Add(this.lblMenu);
            this.paneltieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltieude.Location = new System.Drawing.Point(0, 0);
            this.paneltieude.Name = "paneltieude";
            this.paneltieude.Size = new System.Drawing.Size(393, 66);
            this.paneltieude.TabIndex = 1;
            // 
            // lblMenu
            // 
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMenu.Location = new System.Drawing.Point(0, 41);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(137, 25);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Chi tiết hóa đơn";
            this.lblMenu.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.panelhinh);
            this.PanelMenu.Controls.Add(this.guna2Panel2);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(414, 482);
            this.PanelMenu.TabIndex = 2;
            // 
            // panelhinh
            // 
            this.panelhinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelhinh.Location = new System.Drawing.Point(0, 0);
            this.panelhinh.Name = "panelhinh";
            this.panelhinh.Size = new System.Drawing.Size(414, 394);
            this.panelhinh.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.txtprice);
            this.guna2Panel2.Controls.Add(this.lbldongia);
            this.guna2Panel2.Controls.Add(this.txtTenmon);
            this.guna2Panel2.Controls.Add(this.lbltenmon);
            this.guna2Panel2.Controls.Add(this.lblsoluong);
            this.guna2Panel2.Controls.Add(this.txtSoluong);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 394);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(414, 88);
            this.guna2Panel2.TabIndex = 0;
            // 
            // txtprice
            // 
            this.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprice.DefaultText = "";
            this.txtprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.Location = new System.Drawing.Point(136, 29);
            this.txtprice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.PlaceholderText = "";
            this.txtprice.SelectedText = "";
            this.txtprice.Size = new System.Drawing.Size(88, 18);
            this.txtprice.TabIndex = 8;
            // 
            // lbldongia
            // 
            this.lbldongia.BackColor = System.Drawing.Color.Transparent;
            this.lbldongia.Location = new System.Drawing.Point(136, 6);
            this.lbldongia.Name = "lbldongia";
            this.lbldongia.Size = new System.Drawing.Size(49, 18);
            this.lbldongia.TabIndex = 7;
            this.lbldongia.Text = "Đơn giá";
            // 
            // txtTenmon
            // 
            this.txtTenmon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenmon.DefaultText = "";
            this.txtTenmon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenmon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenmon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenmon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenmon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenmon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenmon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenmon.Location = new System.Drawing.Point(12, 29);
            this.txtTenmon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenmon.Name = "txtTenmon";
            this.txtTenmon.PasswordChar = '\0';
            this.txtTenmon.PlaceholderText = "";
            this.txtTenmon.SelectedText = "";
            this.txtTenmon.Size = new System.Drawing.Size(88, 18);
            this.txtTenmon.TabIndex = 6;
            // 
            // lbltenmon
            // 
            this.lbltenmon.BackColor = System.Drawing.Color.Transparent;
            this.lbltenmon.Location = new System.Drawing.Point(14, 6);
            this.lbltenmon.Name = "lbltenmon";
            this.lbltenmon.Size = new System.Drawing.Size(56, 18);
            this.lbltenmon.TabIndex = 5;
            this.lbltenmon.Text = "Tên món";
            // 
            // lblsoluong
            // 
            this.lblsoluong.BackColor = System.Drawing.Color.Transparent;
            this.lblsoluong.Location = new System.Drawing.Point(272, 6);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(56, 18);
            this.lblsoluong.TabIndex = 4;
            this.lblsoluong.Text = "Số lượng";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoluong.DefaultText = "";
            this.txtSoluong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoluong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoluong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoluong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoluong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoluong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoluong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoluong.Location = new System.Drawing.Point(272, 29);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.PasswordChar = '\0';
            this.txtSoluong.PlaceholderText = "";
            this.txtSoluong.SelectedText = "";
            this.txtSoluong.Size = new System.Drawing.Size(88, 18);
            this.txtSoluong.TabIndex = 3;
            this.txtSoluong.Leave += new System.EventHandler(this.txtSoluong_Leave);
            // 
            // btnxem
            // 
            this.btnxem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnxem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnxem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnxem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnxem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnxem.FillColor = System.Drawing.Color.Black;
            this.btnxem.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxem.ForeColor = System.Drawing.Color.White;
            this.btnxem.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnxem.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnxem.Image = global::Do_anLaptrinhWinCK.Properties.Resources.Bill;
            this.btnxem.ImageOffset = new System.Drawing.Point(14, -10);
            this.btnxem.Location = new System.Drawing.Point(433, 0);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(90, 49);
            this.btnxem.TabIndex = 35;
            this.btnxem.Text = "Xem đơn";
            this.btnxem.TextOffset = new System.Drawing.Point(-5, 10);
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // btnAll
            // 
            this.btnAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAll.FillColor = System.Drawing.Color.Black;
            this.btnAll.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnAll.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnAll.Image = global::Do_anLaptrinhWinCK.Properties.Resources.Select_All;
            this.btnAll.ImageOffset = new System.Drawing.Point(7, -10);
            this.btnAll.Location = new System.Drawing.Point(340, 0);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(71, 49);
            this.btnAll.TabIndex = 34;
            this.btnAll.Text = "Tất cả";
            this.btnAll.TextOffset = new System.Drawing.Point(-5, 10);
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOrder.FillColor = System.Drawing.Color.Black;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnOrder.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnOrder.Image = global::Do_anLaptrinhWinCK.Properties.Resources.Add_Shopping_Cart;
            this.btnOrder.ImageOffset = new System.Drawing.Point(14, -10);
            this.btnOrder.Location = new System.Drawing.Point(523, 0);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(104, 49);
            this.btnOrder.TabIndex = 33;
            this.btnOrder.Text = "Thanh toán";
            this.btnOrder.TextOffset = new System.Drawing.Point(-5, 10);
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlammoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlammoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlammoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlammoi.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnlammoi.FillColor = System.Drawing.Color.Black;
            this.btnlammoi.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoi.ForeColor = System.Drawing.Color.White;
            this.btnlammoi.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnlammoi.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnlammoi.Image = global::Do_anLaptrinhWinCK.Properties.Resources.Sync;
            this.btnlammoi.ImageOffset = new System.Drawing.Point(14, -10);
            this.btnlammoi.Location = new System.Drawing.Point(627, 0);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(90, 49);
            this.btnlammoi.TabIndex = 32;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.TextOffset = new System.Drawing.Point(-5, 10);
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnxoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnxoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnxoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnxoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnxoa.FillColor = System.Drawing.Color.Black;
            this.btnxoa.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.White;
            this.btnxoa.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnxoa.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnxoa.Image = global::Do_anLaptrinhWinCK.Properties.Resources.remove2;
            this.btnxoa.ImageOffset = new System.Drawing.Point(14, -10);
            this.btnxoa.Location = new System.Drawing.Point(717, 0);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(90, 49);
            this.btnxoa.TabIndex = 31;
            this.btnxoa.Text = "Xóa món";
            this.btnxoa.TextOffset = new System.Drawing.Point(-5, 10);
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnKem
            // 
            this.btnKem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKem.FillColor = System.Drawing.Color.Black;
            this.btnKem.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKem.ForeColor = System.Drawing.Color.White;
            this.btnKem.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnKem.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnKem.Image = global::Do_anLaptrinhWinCK.Properties.Resources.Kawaii_Ice_Cream;
            this.btnKem.ImageOffset = new System.Drawing.Point(7, -10);
            this.btnKem.Location = new System.Drawing.Point(272, 0);
            this.btnKem.Name = "btnKem";
            this.btnKem.Size = new System.Drawing.Size(68, 49);
            this.btnKem.TabIndex = 26;
            this.btnKem.Text = "Kem";
            this.btnKem.TextOffset = new System.Drawing.Point(-5, 10);
            this.btnKem.Click += new System.EventHandler(this.btnKem_Click);
            // 
            // btnNuoc
            // 
            this.btnNuoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNuoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNuoc.FillColor = System.Drawing.Color.Black;
            this.btnNuoc.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuoc.ForeColor = System.Drawing.Color.White;
            this.btnNuoc.Image = global::Do_anLaptrinhWinCK.Properties.Resources.Wine_Bar;
            this.btnNuoc.ImageOffset = new System.Drawing.Point(8, -10);
            this.btnNuoc.Location = new System.Drawing.Point(204, 0);
            this.btnNuoc.Name = "btnNuoc";
            this.btnNuoc.Size = new System.Drawing.Size(68, 49);
            this.btnNuoc.TabIndex = 28;
            this.btnNuoc.Text = "Nước";
            this.btnNuoc.TextOffset = new System.Drawing.Point(-5, 10);
            this.btnNuoc.Click += new System.EventHandler(this.btnNuoc_Click);
            // 
            // btnCom
            // 
            this.btnCom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCom.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCom.FillColor = System.Drawing.Color.Black;
            this.btnCom.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCom.ForeColor = System.Drawing.Color.White;
            this.btnCom.Image = global::Do_anLaptrinhWinCK.Properties.Resources.Rice_Bowl;
            this.btnCom.ImageOffset = new System.Drawing.Point(8, -10);
            this.btnCom.Location = new System.Drawing.Point(136, 0);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(68, 49);
            this.btnCom.TabIndex = 27;
            this.btnCom.Text = "Cơm";
            this.btnCom.TextOffset = new System.Drawing.Point(-5, 10);
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // btnMi
            // 
            this.btnMi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMi.FillColor = System.Drawing.Color.Black;
            this.btnMi.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMi.ForeColor = System.Drawing.Color.White;
            this.btnMi.Image = global::Do_anLaptrinhWinCK.Properties.Resources.Kawaii_Noodle;
            this.btnMi.ImageOffset = new System.Drawing.Point(5, -10);
            this.btnMi.Location = new System.Drawing.Point(68, 0);
            this.btnMi.Name = "btnMi";
            this.btnMi.Size = new System.Drawing.Size(68, 49);
            this.btnMi.TabIndex = 25;
            this.btnMi.Text = "Mì";
            this.btnMi.TextOffset = new System.Drawing.Point(-5, 10);
            this.btnMi.Click += new System.EventHandler(this.btnMi_Click);
            // 
            // btnSnack
            // 
            this.btnSnack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSnack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSnack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSnack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSnack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSnack.FillColor = System.Drawing.Color.Black;
            this.btnSnack.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnack.ForeColor = System.Drawing.Color.White;
            this.btnSnack.Image = global::Do_anLaptrinhWinCK.Properties.Resources.Potato_Chips;
            this.btnSnack.ImageOffset = new System.Drawing.Point(10, -10);
            this.btnSnack.Location = new System.Drawing.Point(0, 0);
            this.btnSnack.Name = "btnSnack";
            this.btnSnack.Size = new System.Drawing.Size(68, 49);
            this.btnSnack.TabIndex = 15;
            this.btnSnack.Text = "Snack";
            this.btnSnack.TextOffset = new System.Drawing.Point(-5, 10);
            this.btnSnack.Click += new System.EventHandler(this.btnSnack_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 531);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.panelchitiet);
            this.Controls.Add(this.PanelChucnang);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrder";
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.PanelChucnang.ResumeLayout(false);
            this.panelchitiet.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvorder)).EndInit();
            this.panelthanhtien.ResumeLayout(false);
            this.panelthanhtien.PerformLayout();
            this.paneltieude.ResumeLayout(false);
            this.paneltieude.PerformLayout();
            this.PanelMenu.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelChucnang;
        private Guna.UI2.WinForms.Guna2Button btnSnack;
        private Guna.UI2.WinForms.Guna2Button btnNuoc;
        private Guna.UI2.WinForms.Guna2Button btnCom;
        private Guna.UI2.WinForms.Guna2Button btnMi;
        private System.Windows.Forms.Panel panelchitiet;
        private System.Windows.Forms.Panel panelthanhtien;
        private System.Windows.Forms.Panel paneltieude;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridView dgvorder;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTongtien;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private Guna.UI2.WinForms.Guna2Panel PanelMenu;
        private Guna.UI2.WinForms.Guna2Panel panelhinh;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblsoluong;
        private Guna.UI2.WinForms.Guna2TextBox txtSoluong;
        private Guna.UI2.WinForms.Guna2TextBox txtprice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbldongia;
        private Guna.UI2.WinForms.Guna2TextBox txtTenmon;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbltenmon;
        private Guna.UI2.WinForms.Guna2Button btnKem;
        private Guna.UI2.WinForms.Guna2Button btnAll;
        public Guna.UI2.WinForms.Guna2Button btnOrder;
        public Guna.UI2.WinForms.Guna2Button btnlammoi;
        public Guna.UI2.WinForms.Guna2Button btnxoa;
        public Guna.UI2.WinForms.Guna2Button btnxem;
    }
}