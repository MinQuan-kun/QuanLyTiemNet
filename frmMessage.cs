using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_anLaptrinhWinCK
{
    public partial class frmMessage : Form
    {
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Button btnSend;
        private TextBox txtMessage;
        private DataGridView dgvUserMessages;
        private Panel panel2;

        public frmMessage()
        {
            InitializeComponent();
        }

        private void LoadUserMessages()
        {
            try
            {
                using (var db = new databaseDataContext())
                {
                    string username = frmUser.infor.Split(':').Last().Trim();
                    var userMessages = db.Messages
                        .Where(m => m.Username == username) // currentUsername là tên người dùng đăng nhập
                        .Select(m => new
                        {
                            Thời_Gian = m.SentTime,
                            Nội_Dung = m.Mess,
                            Trạng_Thái = m.Stas
                        })
                        .OrderByDescending(m => m.Thời_Gian) // Sắp xếp theo thời gian
                        .ToList();
                    dgvUserMessages.DataSource = userMessages;
                    dgvUserMessages.Columns["Nội_Dung"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvUserMessages.Columns["Thời_Gian"].Width = 170;
                    dgvUserMessages.Columns["Trạng_Thái"].Width = 100;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string messageContent = txtMessage.Text.Trim();

            if (string.IsNullOrEmpty(messageContent))
            {
                MessageBox.Show("Nội dung tin nhắn không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new databaseDataContext())
                {
                    var newMessage = new Message
                    {
                        Username = frmUser.infor.Split(':').Last().Trim(), // Lấy từ thông tin đăng nhập
                        SentTime = DateTime.Now,    // Lưu thời gian hiện tại
                        Mess = messageContent,
                        Stas = "Chưa xem"          // Trạng thái mặc định
                    };

                    db.Messages.InsertOnSubmit(newMessage);
                    db.SubmitChanges();

                    MessageBox.Show("Tin nhắn đã được gửi!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMessage.Clear();
                    LoadUserMessages(); // Tải lại danh sách tin nhắn
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMessage_Load(object sender, EventArgs e)
        {
            LoadUserMessages();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvUserMessages = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserMessages)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 531);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvUserMessages);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(807, 374);
            this.panel4.TabIndex = 2;
            // 
            // dgvUserMessages
            // 
            this.dgvUserMessages.AllowUserToAddRows = false;
            this.dgvUserMessages.AllowUserToDeleteRows = false;
            this.dgvUserMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUserMessages.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUserMessages.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUserMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserMessages.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserMessages.Location = new System.Drawing.Point(0, 0);
            this.dgvUserMessages.Name = "dgvUserMessages";
            this.dgvUserMessages.ReadOnly = true;
            this.dgvUserMessages.RowHeadersWidth = 51;
            this.dgvUserMessages.RowTemplate.Height = 24;
            this.dgvUserMessages.Size = new System.Drawing.Size(807, 374);
            this.dgvUserMessages.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 57);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.txtMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 100);
            this.panel2.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(665, 31);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(81, 35);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(38, 22);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(599, 56);
            this.txtMessage.TabIndex = 0;
            // 
            // frmMessage
            // 
            this.ClientSize = new System.Drawing.Size(807, 531);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMessage";
            this.Load += new System.EventHandler(this.frmMessage_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserMessages)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
