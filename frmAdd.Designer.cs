namespace Do_anLaptrinhWinCK
{
    partial class frmAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dgvNhap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelChitiet = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelChucnang = new Guna.UI2.WinForms.Guna2Panel();
            this.btnIn = new Guna.UI2.WinForms.Guna2Button();
            this.btnXacnhan = new Guna.UI2.WinForms.Guna2Button();
            this.txtQuantum = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtImportID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFoodID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCategoryID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSoluong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblImportID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaloai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMamon = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Paneltongtin = new System.Windows.Forms.Panel();
            this.lblTongtien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNhaphang = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.lblCategory = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTenmon = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhap)).BeginInit();
            this.panelChitiet.SuspendLayout();
            this.PanelChucnang.SuspendLayout();
            this.Paneltongtin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.dgvNhap);
            this.panelMain.Controls.Add(this.panelChitiet);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 74);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(807, 402);
            this.panelMain.TabIndex = 14;
            // 
            // dgvNhap
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhap.ColumnHeadersHeight = 36;
            this.dgvNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodName,
            this.SumPrice,
            this.Quantity,
            this.Quantum,
            this.CustomerID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhap.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhap.Location = new System.Drawing.Point(293, 0);
            this.dgvNhap.Name = "dgvNhap";
            this.dgvNhap.RowHeadersVisible = false;
            this.dgvNhap.RowHeadersWidth = 51;
            this.dgvNhap.RowTemplate.Height = 24;
            this.dgvNhap.Size = new System.Drawing.Size(514, 402);
            this.dgvNhap.TabIndex = 0;
            this.dgvNhap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhap.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNhap.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNhap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNhap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNhap.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhap.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvNhap.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNhap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNhap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvNhap.ThemeStyle.HeaderStyle.Height = 36;
            this.dgvNhap.ThemeStyle.ReadOnly = false;
            this.dgvNhap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhap.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNhap.ThemeStyle.RowsStyle.Height = 24;
            this.dgvNhap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhap_CellClick);
            // 
            // FoodName
            // 
            this.FoodName.DataPropertyName = "FoodName";
            this.FoodName.HeaderText = "Tên món";
            this.FoodName.MinimumWidth = 6;
            this.FoodName.Name = "FoodName";
            // 
            // SumPrice
            // 
            this.SumPrice.DataPropertyName = "SumPrice";
            this.SumPrice.HeaderText = "Giá nhập";
            this.SumPrice.MinimumWidth = 6;
            this.SumPrice.Name = "SumPrice";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Tồn kho";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Quantum
            // 
            this.Quantum.DataPropertyName = "Quantum";
            this.Quantum.HeaderText = "Số lượng nhập";
            this.Quantum.MinimumWidth = 6;
            this.Quantum.Name = "Quantum";
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "Mã người nhập";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            // 
            // panelChitiet
            // 
            this.panelChitiet.Controls.Add(this.PanelChucnang);
            this.panelChitiet.Controls.Add(this.txtQuantum);
            this.panelChitiet.Controls.Add(this.txtUser);
            this.panelChitiet.Controls.Add(this.txtImportID);
            this.panelChitiet.Controls.Add(this.txtFoodID);
            this.panelChitiet.Controls.Add(this.txtCategoryID);
            this.panelChitiet.Controls.Add(this.lblSoluong);
            this.panelChitiet.Controls.Add(this.lblImportID);
            this.panelChitiet.Controls.Add(this.lblMaloai);
            this.panelChitiet.Controls.Add(this.lblUser);
            this.panelChitiet.Controls.Add(this.lblMamon);
            this.panelChitiet.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelChitiet.Location = new System.Drawing.Point(0, 0);
            this.panelChitiet.Name = "panelChitiet";
            this.panelChitiet.Size = new System.Drawing.Size(293, 402);
            this.panelChitiet.TabIndex = 5;
            // 
            // PanelChucnang
            // 
            this.PanelChucnang.Controls.Add(this.btnIn);
            this.PanelChucnang.Controls.Add(this.btnXacnhan);
            this.PanelChucnang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelChucnang.Location = new System.Drawing.Point(0, 345);
            this.PanelChucnang.Name = "PanelChucnang";
            this.PanelChucnang.Size = new System.Drawing.Size(293, 57);
            this.PanelChucnang.TabIndex = 22;
            // 
            // btnIn
            // 
            this.btnIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIn.FillColor = System.Drawing.Color.Black;
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.Location = new System.Drawing.Point(12, 4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(110, 47);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In đơn nhập";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXacnhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXacnhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXacnhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXacnhan.FillColor = System.Drawing.Color.Black;
            this.btnXacnhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacnhan.ForeColor = System.Drawing.Color.White;
            this.btnXacnhan.Location = new System.Drawing.Point(159, 4);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(110, 47);
            this.btnXacnhan.TabIndex = 0;
            this.btnXacnhan.Text = "Xác nhận nhập";
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // txtQuantum
            // 
            this.txtQuantum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantum.DefaultText = "";
            this.txtQuantum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantum.Location = new System.Drawing.Point(145, 231);
            this.txtQuantum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantum.Name = "txtQuantum";
            this.txtQuantum.PasswordChar = '\0';
            this.txtQuantum.PlaceholderText = "";
            this.txtQuantum.SelectedText = "";
            this.txtQuantum.Size = new System.Drawing.Size(113, 22);
            this.txtQuantum.TabIndex = 21;
            this.txtQuantum.Leave += new System.EventHandler(this.txtQuantum_Leave);
            // 
            // txtUser
            // 
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "";
            this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.Location = new System.Drawing.Point(144, 190);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PlaceholderText = "";
            this.txtUser.SelectedText = "";
            this.txtUser.Size = new System.Drawing.Size(113, 22);
            this.txtUser.TabIndex = 20;
            // 
            // txtImportID
            // 
            this.txtImportID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImportID.DefaultText = "";
            this.txtImportID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtImportID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtImportID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImportID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImportID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImportID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtImportID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImportID.Location = new System.Drawing.Point(145, 83);
            this.txtImportID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtImportID.Name = "txtImportID";
            this.txtImportID.PasswordChar = '\0';
            this.txtImportID.PlaceholderText = "";
            this.txtImportID.SelectedText = "";
            this.txtImportID.Size = new System.Drawing.Size(113, 22);
            this.txtImportID.TabIndex = 19;
            // 
            // txtFoodID
            // 
            this.txtFoodID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFoodID.DefaultText = "";
            this.txtFoodID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFoodID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFoodID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFoodID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFoodID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFoodID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFoodID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFoodID.Location = new System.Drawing.Point(145, 118);
            this.txtFoodID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.PasswordChar = '\0';
            this.txtFoodID.PlaceholderText = "";
            this.txtFoodID.SelectedText = "";
            this.txtFoodID.Size = new System.Drawing.Size(113, 22);
            this.txtFoodID.TabIndex = 18;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryID.DefaultText = "";
            this.txtCategoryID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCategoryID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCategoryID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCategoryID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryID.Location = new System.Drawing.Point(145, 153);
            this.txtCategoryID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.PasswordChar = '\0';
            this.txtCategoryID.PlaceholderText = "";
            this.txtCategoryID.SelectedText = "";
            this.txtCategoryID.Size = new System.Drawing.Size(113, 22);
            this.txtCategoryID.TabIndex = 17;
            // 
            // lblSoluong
            // 
            this.lblSoluong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoluong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluong.Location = new System.Drawing.Point(28, 231);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(63, 22);
            this.lblSoluong.TabIndex = 16;
            this.lblSoluong.Text = "Số lượng";
            // 
            // lblImportID
            // 
            this.lblImportID.BackColor = System.Drawing.Color.Transparent;
            this.lblImportID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportID.Location = new System.Drawing.Point(28, 83);
            this.lblImportID.Name = "lblImportID";
            this.lblImportID.Size = new System.Drawing.Size(54, 22);
            this.lblImportID.TabIndex = 15;
            this.lblImportID.Text = "Mã đơn";
            // 
            // lblMaloai
            // 
            this.lblMaloai.BackColor = System.Drawing.Color.Transparent;
            this.lblMaloai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaloai.Location = new System.Drawing.Point(28, 153);
            this.lblMaloai.Name = "lblMaloai";
            this.lblMaloai.Size = new System.Drawing.Size(53, 22);
            this.lblMaloai.TabIndex = 14;
            this.lblMaloai.Text = "Mã loại";
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(28, 190);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(82, 22);
            this.lblUser.TabIndex = 13;
            this.lblUser.Text = "Người nhập";
            // 
            // lblMamon
            // 
            this.lblMamon.BackColor = System.Drawing.Color.Transparent;
            this.lblMamon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMamon.Location = new System.Drawing.Point(28, 118);
            this.lblMamon.Name = "lblMamon";
            this.lblMamon.Size = new System.Drawing.Size(58, 22);
            this.lblMamon.TabIndex = 12;
            this.lblMamon.Text = "Mã món";
            // 
            // Paneltongtin
            // 
            this.Paneltongtin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Paneltongtin.Controls.Add(this.lblTongtien);
            this.Paneltongtin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Paneltongtin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Paneltongtin.Location = new System.Drawing.Point(0, 476);
            this.Paneltongtin.Name = "Paneltongtin";
            this.Paneltongtin.Size = new System.Drawing.Size(807, 55);
            this.Paneltongtin.TabIndex = 13;
            // 
            // lblTongtien
            // 
            this.lblTongtien.BackColor = System.Drawing.Color.Transparent;
            this.lblTongtien.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongtien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTongtien.Location = new System.Drawing.Point(525, 10);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(163, 33);
            this.lblTongtien.TabIndex = 8;
            this.lblTongtien.Text = "Tổng tiền: 0.00";
            // 
            // lblNhaphang
            // 
            this.lblNhaphang.BackColor = System.Drawing.Color.Transparent;
            this.lblNhaphang.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaphang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNhaphang.Location = new System.Drawing.Point(314, 3);
            this.lblNhaphang.Name = "lblNhaphang";
            this.lblNhaphang.Size = new System.Drawing.Size(121, 33);
            this.lblNhaphang.TabIndex = 7;
            this.lblNhaphang.Text = "Nhập hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.cbName);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.lblTenmon);
            this.panel1.Controls.Add(this.lblNhaphang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 74);
            this.panel1.TabIndex = 12;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Cơm",
            "Nước uống",
            "Snack",
            "Mì",
            "Kem"});
            this.cbCategory.Location = new System.Drawing.Point(350, 42);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(133, 25);
            this.cbCategory.TabIndex = 12;
            this.cbCategory.Leave += new System.EventHandler(this.cbCategory_Leave);
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(88, 43);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(133, 25);
            this.cbName.TabIndex = 11;
            this.cbName.Leave += new System.EventHandler(this.cbName_Leave);
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCategory.Location = new System.Drawing.Point(273, 43);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 22);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Thể loại";
            // 
            // lblTenmon
            // 
            this.lblTenmon.BackColor = System.Drawing.Color.Transparent;
            this.lblTenmon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenmon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTenmon.Location = new System.Drawing.Point(17, 43);
            this.lblTenmon.Name = "lblTenmon";
            this.lblTenmon.Size = new System.Drawing.Size(65, 22);
            this.lblTenmon.TabIndex = 10;
            this.lblTenmon.Text = "Tên món";
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 531);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.Paneltongtin);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdd";
            this.Text = "frmAdd";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhap)).EndInit();
            this.panelChitiet.ResumeLayout(false);
            this.panelChitiet.PerformLayout();
            this.PanelChucnang.ResumeLayout(false);
            this.Paneltongtin.ResumeLayout(false);
            this.Paneltongtin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel Paneltongtin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNhaphang;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTongtien;
        private Guna.UI2.WinForms.Guna2Panel panelChitiet;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaloai;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUser;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMamon;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNhap;
        private Guna.UI2.WinForms.Guna2Button btnIn;
        private Guna.UI2.WinForms.Guna2Button btnXacnhan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCategory;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenmon;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblImportID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoluong;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantum;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private Guna.UI2.WinForms.Guna2TextBox txtImportID;
        private Guna.UI2.WinForms.Guna2TextBox txtFoodID;
        private Guna.UI2.WinForms.Guna2TextBox txtCategoryID;
        private Guna.UI2.WinForms.Guna2Panel PanelChucnang;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
    }
}