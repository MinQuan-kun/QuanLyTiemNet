namespace Do_anLaptrinhWinCK.All_Cards
{
    partial class Cards
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
            this.btnTim = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.lbtype = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbluserID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblSodu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblDk = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCards = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMothe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(12, 24);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 41);
            this.btnTim.TabIndex = 15;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(93, 49);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(75, 41);
            this.btnBlock.TabIndex = 14;
            this.btnBlock.Text = "Khóa thẻ";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // lbtype
            // 
            this.lbtype.BackColor = System.Drawing.Color.Transparent;
            this.lbtype.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtype.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbtype.Location = new System.Drawing.Point(229, 13);
            this.lbtype.Name = "lbtype";
            this.lbtype.Size = new System.Drawing.Size(56, 22);
            this.lbtype.TabIndex = 25;
            this.lbtype.Text = "Loại thẻ";
            // 
            // lbluserID
            // 
            this.lbluserID.BackColor = System.Drawing.Color.Transparent;
            this.lbluserID.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbluserID.Location = new System.Drawing.Point(25, 15);
            this.lbluserID.Name = "lbluserID";
            this.lbluserID.Size = new System.Drawing.Size(42, 19);
            this.lbluserID.TabIndex = 22;
            this.lbluserID.Text = "UserID";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBalance.Location = new System.Drawing.Point(124, 40);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(75, 25);
            this.txtBalance.TabIndex = 18;
            // 
            // lblSodu
            // 
            this.lblSodu.BackColor = System.Drawing.Color.Transparent;
            this.lblSodu.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSodu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSodu.Location = new System.Drawing.Point(124, 16);
            this.lblSodu.Name = "lblSodu";
            this.lblSodu.Size = new System.Drawing.Size(38, 19);
            this.lblSodu.TabIndex = 17;
            this.lblSodu.Text = "Số dư";
            // 
            // cbType
            // 
            this.cbType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "VIP",
            "Thành viên"});
            this.cbType.Location = new System.Drawing.Point(229, 40);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(132, 24);
            this.cbType.TabIndex = 26;
            // 
            // lblDk
            // 
            this.lblDk.BackColor = System.Drawing.Color.Transparent;
            this.lblDk.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDk.Location = new System.Drawing.Point(314, 3);
            this.lblDk.Name = "lblDk";
            this.lblDk.Size = new System.Drawing.Size(154, 33);
            this.lblDk.TabIndex = 7;
            this.lblDk.Text = "Danh sách thẻ";
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUserID.Location = new System.Drawing.Point(25, 40);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(75, 25);
            this.txtUserID.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvCards);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 513);
            this.panel3.TabIndex = 17;
            // 
            // dgvCards
            // 
            this.dgvCards.AllowUserToAddRows = false;
            this.dgvCards.AllowUserToDeleteRows = false;
            this.dgvCards.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.CardID,
            this.CardType,
            this.Balance,
            this.Stas});
            this.dgvCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCards.Location = new System.Drawing.Point(0, 0);
            this.dgvCards.Name = "dgvCards";
            this.dgvCards.ReadOnly = true;
            this.dgvCards.RowHeadersWidth = 51;
            this.dgvCards.RowTemplate.Height = 24;
            this.dgvCards.Size = new System.Drawing.Size(804, 513);
            this.dgvCards.TabIndex = 8;
            this.dgvCards.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCards_CellClick);
            // 
            // UserID
            // 
            this.UserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Width = 60;
            // 
            // CardID
            // 
            this.CardID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CardID.DataPropertyName = "CardID";
            this.CardID.HeaderText = "CardID";
            this.CardID.MinimumWidth = 6;
            this.CardID.Name = "CardID";
            this.CardID.ReadOnly = true;
            this.CardID.Width = 70;
            // 
            // CardType
            // 
            this.CardType.DataPropertyName = "CardType";
            this.CardType.HeaderText = "Loại thẻ";
            this.CardType.MinimumWidth = 6;
            this.CardType.Name = "CardType";
            this.CardType.ReadOnly = true;
            this.CardType.Width = 125;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "Số dư";
            this.Balance.MinimumWidth = 6;
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.Width = 125;
            // 
            // Stas
            // 
            this.Stas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stas.DataPropertyName = "Stas";
            this.Stas.HeaderText = "Trạng thái";
            this.Stas.MinimumWidth = 6;
            this.Stas.Name = "Stas";
            this.Stas.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.cbType);
            this.panel2.Controls.Add(this.lbtype);
            this.panel2.Controls.Add(this.lbluserID);
            this.panel2.Controls.Add(this.txtBalance);
            this.panel2.Controls.Add(this.lblSodu);
            this.panel2.Controls.Add(this.txtUserID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 559);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 105);
            this.panel2.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMothe);
            this.panel4.Controls.Add(this.btnTim);
            this.panel4.Controls.Add(this.btnBlock);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(583, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 105);
            this.panel4.TabIndex = 28;
            // 
            // btnMothe
            // 
            this.btnMothe.Location = new System.Drawing.Point(93, 3);
            this.btnMothe.Name = "btnMothe";
            this.btnMothe.Size = new System.Drawing.Size(75, 41);
            this.btnMothe.TabIndex = 27;
            this.btnMothe.Text = "Mở thẻ";
            this.btnMothe.UseVisualStyleBackColor = true;
            this.btnMothe.Click += new System.EventHandler(this.btnMothe_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblDk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 46);
            this.panel1.TabIndex = 15;
            // 
            // Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Cards";
            this.Size = new System.Drawing.Size(804, 664);
            this.Load += new System.EventHandler(this.frmCard_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnBlock;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbtype;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbluserID;
        private System.Windows.Forms.TextBox txtBalance;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSodu;
        private System.Windows.Forms.ComboBox cbType;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDk;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dgvCards;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stas;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMothe;
    }
}
