using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace Do_anLaptrinhWinCK.All_Customer
{
    public partial class Taikhoan : UserControl
    {
        public Taikhoan()
        {
            InitializeComponent();
        }

        private void Khachhang_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        private void loadDuLieu()
        {
            using (databaseDataContext db = new databaseDataContext())
            {
                dgvUsers.DataSource = db.Users
                    .OrderBy(m => m.UserID)
                    .Select(m => new
                    {
                        m.UserID,
                        m.Password,
                        m.Username,
                        m.CardID,
                        m.Point
                    }).ToList();
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = e.RowIndex;
            if (idrow < 0 || idrow >= dgvUsers.Rows.Count - (dgvUsers.AllowUserToAddRows ? 1 : 0))
                return;

            HienthiDuLieuDong(idrow);
        }
        private void HienthiDuLieuDong(int idrow)
        {
            databaseDataContext db = new databaseDataContext();
            int UserID = int.Parse(dgvUsers.Rows[idrow].Cells[0].Value.ToString());
            var user = db.Users.SingleOrDefault(p => p.UserID == UserID);
            if (user != null)
            {
                txtID.Text = user.UserID.ToString();
                txtUsername.Text = user.Username;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int? ID = string.IsNullOrWhiteSpace(txtID.Text) ? (int?)null : int.Parse(txtID.Text);
            string name = string.IsNullOrWhiteSpace(txtUsername.Text) ? null : txtUsername.Text;
            if (ID == null)
            {
                MessageBox.Show("Vui lòng nhập UserID để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
                return;
            }
            using (databaseDataContext db = new databaseDataContext())
            {
                var existingUser = db.Users.SingleOrDefault(u => u.UserID == ID);

                if (existingUser != null)
                {
                    db.SubmitChanges();
                    MessageBox.Show("Chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDuLieu();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy UserID để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int? ID = string.IsNullOrWhiteSpace(txtID.Text) ? (int?)null : int.Parse(txtID.Text);
            string name = string.IsNullOrWhiteSpace(txtUsername.Text) ? null : txtUsername.Text;

            databaseDataContext db = new databaseDataContext();
            var query = db.Users.AsQueryable();
            if (ID.HasValue)
            {
                query = query.Where(m => m.UserID == ID.Value);
            }
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(m => m.Username.Contains(name));
            }
            var results = query.ToList();
            if (results.Count > 0)
            {
                dgvUsers.DataSource = results.Select(m => new
                {
                    m.UserID,
                    m.Password,
                    m.Username,
                    m.CardID,
                    m.Point
                }).ToList();
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ID;
            if (!int.TryParse(txtID.Text, out ID))
            {
                MessageBox.Show("Mã tài khoản không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return;
            }
            databaseDataContext db = new databaseDataContext();
            var existingUser = db.Users.SingleOrDefault(u => u.UserID == ID);
            if (existingUser != null)
            {
                db.Users.DeleteOnSubmit(existingUser);
                db.SubmitChanges();
                loadDuLieu();
                MessageBox.Show("Xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mã tài khoản không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return;
            }
        }
        
    }
}
