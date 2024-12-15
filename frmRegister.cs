using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Do_anLaptrinhWinCK
{
    public partial class frmDangky : Form
    {
        public frmDangky()
        {
            InitializeComponent();
        }


        private void frmDangky_Load(object sender, EventArgs e)
        {
            SetRoundedCorners(30);
        }
        private void SetRoundedCorners(int radius)
        {
            radius = Math.Min(radius, Math.Min(this.Width / 2, this.Height / 2));

            var path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Vui lòng điền username thông tin", "Thông báo");
                return;
            }
            // Kiểm tra username và email đã tồn tại chưa 
            databaseDataContext db = new databaseDataContext();
            User user = db.Users.FirstOrDefault(x => x.Username == txtUser.Text);
            if (user != null)
            {
                if (user.Username == txtUser.Text)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng chọn tên khác!", "Thông báo");
                    txtUser.Focus();
                }
                return;
            }
            else
            {
                // Tạo Randomkey
                string taikhoan = txtUser.Text;
                int matkhau = 1;
                Random rd = new Random();
                string key = rd.Next(1000, 9999).ToString();

                //Mã hóa mật khẩu 
                MD5 md5 = MD5.Create();
                byte[] inputBytes = Encoding.ASCII.GetBytes(matkhau + key);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Tạo và thêm dữ liệu đăng ký vào database
                User Us = new User();
                Us.Username = taikhoan;
                Us.Password = hashBytes;
                Us.RandomKey = key;
                db.Users.InsertOnSubmit(Us);
                db.SubmitChanges();
                MessageBox.Show("Đăng ký thành công!", "Thông báo");
            }
        }
    }
}
