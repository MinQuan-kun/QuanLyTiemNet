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
    public partial class frmCheckMessages : Form
    {
        public frmCheckMessages()
        {
            InitializeComponent();
        }
        private void LoadAllMessages()
        {
            try
            {
                using (var db = new databaseDataContext())
                {
                    var allMessages = db.Messages
                        .Select(m => new
                        {
                            Người_Dùng = m.Username,
                            Thời_Gian = m.SentTime,
                            Nội_Dung = m.Mess,
                            Trạng_Thái = m.Stas
                        })
                        .OrderBy(m => m.Thời_Gian) // Sắp xếp theo thời gian
                        .ToList();
                    dgvAdminMessages.DataSource = allMessages;
                    dgvAdminMessages.Columns["Nội_Dung"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAdminMessages.Columns["Thời_Gian"].Width = 170;
                    dgvAdminMessages.Columns["Trạng_Thái"].Width = 100;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCheckMessages_Load(object sender, EventArgs e)
        {
            LoadAllMessages();
        }

        private void dgvAdminMessages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAdminMessages.Columns["Trạng_Thái"].Index && e.RowIndex >= 0)
            {
                string username = dgvAdminMessages.Rows[e.RowIndex].Cells["Người_Dùng"].Value.ToString();
                DateTime sentTime = (DateTime)dgvAdminMessages.Rows[e.RowIndex].Cells["Thời_Gian"].Value;

                try
                {
                    using (var db = new databaseDataContext())
                    {
                        var message = db.Messages.SingleOrDefault(m => m.Username == username && m.SentTime == sentTime);
                        if (message != null && message.Stas == "Chưa xem")
                        {
                            message.Stas = "Đã xem";
                            db.SubmitChanges();

                            MessageBox.Show("Trạng thái đã được cập nhật!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAllMessages();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
