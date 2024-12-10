using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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
            if ( txtUser.Text == "" || txtPass.Text == "" || txtConfimpass.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo");
                return;
            }
            if (txtPass.Text != txtConfimpass.Text)
            {
                MessageBox.Show("Vui lòng điền chính xác mật khẩu", "Thông báo");
                txtPass.Focus();
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
                string matkhau = txtPass.Text;
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
                Us.ResetMk = false;
                Us.Status = true;
                db.Users.InsertOnSubmit(Us);
                db.SubmitChanges();
                MessageBox.Show("Đăng ký thành công!", "Thông báo");
            }  
        }
    }
}
