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
    public partial class NapTien : Form
    {
        public NapTien()
        {
            InitializeComponent();
        }

        private void NapTien_Load(object sender, EventArgs e)
        {
            // Hiển thị số dư và điểm hiện tại của người dùng
            using (databaseDataContext db = new databaseDataContext())
            {
                var user = db.Users.SingleOrDefault(u => u.UserID == frmUser.ID);
                var card = db.Cards.SingleOrDefault(c => c.UserID == frmUser.ID);
                if (user != null && card != null)
                {
                    lblBalance.Text = $"Số dư hiện tại: {card.Balance} VND";
                    lblPoint.Text = $"Điểm hiện tại: {user.Point} điểm";
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem số tiền đã được nhập chưa
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Vui lòng nhập số tiền nạp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy số tiền từ TextBox
            decimal amountToAdd;
            if (!decimal.TryParse(txtAmount.Text, out amountToAdd) || amountToAdd <= 0)
            {
                MessageBox.Show("Số tiền không hợp lệ! Vui lòng nhập số tiền dương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (databaseDataContext db = new databaseDataContext())
            {
                // Sử dụng ID người dùng để tìm thông tin
                var user = db.Users.SingleOrDefault(u => u.UserID == frmUser.ID);
                var card = db.Cards.SingleOrDefault(c => c.UserID == frmUser.ID);

                if (user != null && card != null)
                {
                    // Kiểm tra trạng thái thẻ trước khi nạp tiền
                    if (card.Stas == "Đã khóa")
                    {
                        MessageBox.Show("Thẻ đang bị khóa, không thể nạp tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Cập nhật số dư
                    card.Balance += amountToAdd;
                    db.SubmitChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                    // Tính điểm thưởng: Mỗi 10,000 VND được 20 điểm
                    int pointsToAdd = (int)(amountToAdd / 10000) * 20;

                    // Cập nhật điểm
                    user.Point += pointsToAdd;

                    // Hiển thị thông báo thành công
                    MessageBox.Show($"Nạp tiền thành công! Bạn nhận được {pointsToAdd} điểm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật giao diện
                    lblBalance.Text = $"Số dư: {card.Balance} VND";
                    lblPoint.Text = $"Điểm: {user.Point}";

                    // Xóa TextBox sau khi nạp tiền
                    txtAmount.Clear();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin người dùng hoặc thẻ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
