using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Do_anLaptrinhWinCK
{
    public partial class frmChangepass : Form
    {
        public static int ID;
        public frmChangepass()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmChangepass_Load(object sender, EventArgs e)
        {
            lblerror.Visible = false;
            Setup();
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

        private Point mouseOffset;
        private bool isMouseDown = false;

        private void frmChangepass_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        private void frmChangepass_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(mouseOffset.X, mouseOffset.Y);
                this.Location = mousePosition;
            }
        }

        private void frmChangepass_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void Setup()
        {
            string username = frmUser.infor.Split(':').Last().Trim();
            using (databaseDataContext db = new databaseDataContext())
            {
                User user = db.Users.SingleOrDefault(p => p.Username == username);
                ID = user.UserID;
            }
        }
        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            string pass1 = txtpass1.Text;
            string pass2 = txtpass2.Text;
            if (pass1 == pass2)
            {
                databaseDataContext db = new databaseDataContext();
                User u = db.Users.FirstOrDefault(x => x.UserID == ID);
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
                lblerror.Visible = true;
            }
        }
    }
}
