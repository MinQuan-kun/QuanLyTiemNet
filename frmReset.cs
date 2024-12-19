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
    public partial class frmReset : Form
    {
        public frmReset()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string uname = txtUsername.Text;
            if (string.IsNullOrEmpty(uname))
            {
                MessageBox.Show("Hãy Nhập Username!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            else
            {
                using (var db = new databaseDataContext())
                {
                    var user = db.Users.SingleOrDefault(u => u.Username == uname);
                    if (user == null)
                    {
                        lblerror.Visible = true;
                        return;
                    }
                    string newPassword = "1";
                    MD5 md5 = MD5.Create();
                    byte[] inputBytes = Encoding.ASCII.GetBytes(newPassword + user.RandomKey);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);
                    user.Password = hashBytes;
                    db.SubmitChanges();
                    lblSuccess.Visible = true;
                }
            }
        }
    }
}
