namespace Do_anLaptrinhWinCK.All_Bill
{
    partial class Bills
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDk = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnInds = new System.Windows.Forms.Button();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblstas = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblbillID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTotalprice = new System.Windows.Forms.TextBox();
            this.lblSodu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtbillID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvbill = new System.Windows.Forms.DataGridView();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblDk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 46);
            this.panel1.TabIndex = 18;
            // 
            // lblDk
            // 
            this.lblDk.BackColor = System.Drawing.Color.Transparent;
            this.lblDk.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDk.Location = new System.Drawing.Point(279, 10);
            this.lblDk.Name = "lblDk";
            this.lblDk.Size = new System.Drawing.Size(208, 33);
            this.lblDk.TabIndex = 7;
            this.lblDk.Text = "Danh sách hóa đơn";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnInds);
            this.panel4.Controls.Add(this.btnXacnhan);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(583, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 93);
            this.panel4.TabIndex = 28;
            // 
            // btnInds
            // 
            this.btnInds.Location = new System.Drawing.Point(117, 6);
            this.btnInds.Name = "btnInds";
            this.btnInds.Size = new System.Drawing.Size(75, 41);
            this.btnInds.TabIndex = 13;
            this.btnInds.Text = "Inds";
            this.btnInds.UseVisualStyleBackColor = true;
            this.btnInds.Click += new System.EventHandler(this.btnInds_Click);
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.Location = new System.Drawing.Point(15, 6);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(75, 41);
            this.btnXacnhan.TabIndex = 27;
            this.btnXacnhan.Text = "Xác nhận";
            this.btnXacnhan.UseVisualStyleBackColor = true;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.cbType);
            this.panel2.Controls.Add(this.lblstas);
            this.panel2.Controls.Add(this.lblbillID);
            this.panel2.Controls.Add(this.txtTotalprice);
            this.panel2.Controls.Add(this.lblSodu);
            this.panel2.Controls.Add(this.txtbillID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 571);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 93);
            this.panel2.TabIndex = 19;
            // 
            // cbType
            // 
            this.cbType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Đang xử lý",
            "Hoàn thành",
            "Đã hủy"});
            this.cbType.Location = new System.Drawing.Point(229, 40);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(132, 24);
            this.cbType.TabIndex = 26;
            // 
            // lblstas
            // 
            this.lblstas.BackColor = System.Drawing.Color.Transparent;
            this.lblstas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblstas.Location = new System.Drawing.Point(229, 13);
            this.lblstas.Name = "lblstas";
            this.lblstas.Size = new System.Drawing.Size(70, 22);
            this.lblstas.TabIndex = 25;
            this.lblstas.Text = "Tình trạng";
            // 
            // lblbillID
            // 
            this.lblbillID.BackColor = System.Drawing.Color.Transparent;
            this.lblbillID.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbillID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblbillID.Location = new System.Drawing.Point(25, 15);
            this.lblbillID.Name = "lblbillID";
            this.lblbillID.Size = new System.Drawing.Size(31, 19);
            this.lblbillID.TabIndex = 22;
            this.lblbillID.Text = "BillID";
            // 
            // txtTotalprice
            // 
            this.txtTotalprice.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalprice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTotalprice.Location = new System.Drawing.Point(124, 40);
            this.txtTotalprice.Name = "txtTotalprice";
            this.txtTotalprice.Size = new System.Drawing.Size(75, 25);
            this.txtTotalprice.TabIndex = 18;
            // 
            // lblSodu
            // 
            this.lblSodu.BackColor = System.Drawing.Color.Transparent;
            this.lblSodu.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSodu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSodu.Location = new System.Drawing.Point(124, 16);
            this.lblSodu.Name = "lblSodu";
            this.lblSodu.Size = new System.Drawing.Size(58, 19);
            this.lblSodu.TabIndex = 17;
            this.lblSodu.Text = "Tổng tiền";
            // 
            // txtbillID
            // 
            this.txtbillID.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbillID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbillID.Location = new System.Drawing.Point(25, 40);
            this.txtbillID.Name = "txtbillID";
            this.txtbillID.Size = new System.Drawing.Size(75, 25);
            this.txtbillID.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvbill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 525);
            this.panel3.TabIndex = 20;
            // 
            // dgvbill
            // 
            this.dgvbill.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillID,
            this.UserID,
            this.TotalAmount,
            this.CreatedAt,
            this.Status});
            this.dgvbill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvbill.Location = new System.Drawing.Point(0, 0);
            this.dgvbill.Name = "dgvbill";
            this.dgvbill.RowHeadersWidth = 51;
            this.dgvbill.RowTemplate.Height = 24;
            this.dgvbill.Size = new System.Drawing.Size(804, 525);
            this.dgvbill.TabIndex = 0;
            this.dgvbill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbill_CellClick);
            // 
            // BillID
            // 
            this.BillID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.BillID.DataPropertyName = "BillID";
            this.BillID.HeaderText = "Mã đơn";
            this.BillID.MinimumWidth = 6;
            this.BillID.Name = "BillID";
            this.BillID.Width = 81;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "Mã khách ";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.Width = 125;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.HeaderText = "Tổng tiền";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Width = 125;
            // 
            // CreatedAt
            // 
            this.CreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.HeaderText = "Thời gian";
            this.CreatedAt.MinimumWidth = 6;
            this.CreatedAt.Name = "CreatedAt";
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng thái";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            // 
            // Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Bills";
            this.Size = new System.Drawing.Size(804, 664);
            this.Load += new System.EventHandler(this.Bills_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDk;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnInds;
        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbType;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblstas;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblbillID;
        private System.Windows.Forms.TextBox txtTotalprice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSodu;
        private System.Windows.Forms.TextBox txtbillID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvbill;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
