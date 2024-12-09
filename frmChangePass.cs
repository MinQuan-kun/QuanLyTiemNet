using Do_anLaptrinhWinCK.All_Customer;
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
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Do_anLaptrinhWinCK
{
    public partial class frmConfirm : Form
    {
        public frmConfirm()
        {
            InitializeComponent();
        }

        private void btnminisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btnXacnhan3_Click(object sender, EventArgs e)
        {
            string pass1 = txtMk.Text;
            string pass2 = txtMk2.Text;
            string name = txtUser.Text;
            if (pass1 == pass2)
            {
                databaseDataContext db = new databaseDataContext();
                User u = db.Users.FirstOrDefault(x => x.Username == txtUser.Text);

                MD5 md5 = MD5.Create();
                byte[] inputBytes = Encoding.ASCII.GetBytes(pass1 + u.RandomKey);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                u.Password = hashBytes;
                db.SubmitChanges();
                MessageBox.Show("Cập nhật mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật mật khẩu thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMk.Focus();
            }    
        }
    }
}
