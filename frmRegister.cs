using System;
using System.Data.SqlClient;
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

        private void btnDangky_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Vui lòng điền username thông tin", "Thông báo");
                return;
            }
            // Kiểm tra username và email đã tồn tại chưa 
            databaseDataContext db = new databaseDataContext();
            User user = db.Users.FirstOrDefault(x => x.Username == txtUsername.Text);
            Admin ad = db.Admins.FirstOrDefault(y => y.Username == txtUsername.Text);
            // Tránh trường hợp đặt tên giống admin
            if (ad != null)
            {
                lblerror.Visible = true;
                txtUsername.Focus();
            }
            else if (user != null)
            {
                if (user.Username == txtUsername.Text)
                {
                    lblerror2.Visible = true;
                    txtUsername.Focus();
                }
                return;
            }
            else
            {
                // Tạo Randomkey
                lblerror.Visible = false;
                lblerror2.Visible = false;
                string taikhoan = txtUsername.Text;
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
                lblsucces.Visible = true;
            }
        }
    }
}
