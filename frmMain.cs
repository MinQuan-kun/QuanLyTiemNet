using Do_anLaptrinhWinCK;
using Do_anLaptrinhWinCK.All_Computer;
using Do_anLaptrinhWinCK.All_Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_anLaptrinhWinCK
{
    public partial class frmMain : Form
    {
        public static string infor = "Bạn chưa đăng nhập!";
        public frmMain()
        {
            InitializeComponent();
            customizeDesign();
        }

        public frmMain(string _infor)
        {
            InitializeComponent();
            customizeDesign();
            infor = _infor;
            lblInfor.Text = infor;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            UpdateLoginState();
            ThucDon.Visible = false;
            Taikhoan.Visible = false;
            btnMenu.PerformClick();
            PanelMain.Resize += PanelMain_Resize;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss ");
        }
        private void btnminisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnfullsize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(950, 600);
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void customizeDesign()
        {
            subpanelHethong.Visible = false;
            subpanelDanhmuc.Visible = false;
            subpanelChucnang.Visible = false;
            ThucDon.Visible = false;
        }

        private void hideSubMenu()
        {
            if (subpanelHethong.Visible)
                subpanelHethong.Visible = false;
            if (subpanelDanhmuc.Visible)
                subpanelDanhmuc.Visible = false;
            if (subpanelChucnang.Visible)
                subpanelChucnang.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void UpdateLoginState()
        {
            lblInfor.Text = infor;
            bool isLoggedIn = infor != "Bạn chưa đăng nhập!";
            btnDangxuat.Enabled = isLoggedIn;
            Logout.Enabled = isLoggedIn;
            btnDangNhap.Enabled = !isLoggedIn;
            Login.Enabled = !isLoggedIn;
            register.Enabled = !isLoggedIn;

            if (isLoggedIn)
            {
                // Lấy username từ chuỗi infor
                string username = infor.Split(':').Last().Trim();
                using (databaseDataContext db = new databaseDataContext())
                {
                    // Tìm người dùng trong cơ sở dữ liệu
                    Admin user = db.Admins.SingleOrDefault(p => p.Username == username);
                    if (user != null)
                    {
                        if (user.Role == false)
                        {
                            btnChucnang.Enabled = true;
                            btnDanhmuc.Enabled = true;
                        }
                        else
                        {
                            // Nhân viên
                            btnChucnang.Enabled = true;
                            btnTaikhoan.Visible = false;
                        }
                    }
                }
            }
            else
            {
                btnChucnang.Enabled = false;
                btnDanhmuc.Enabled = false;
            }
        }

        //Hiện thị subMenu
        private void btnHethong_Click(object sender, EventArgs e)
        {
            showSubMenu(subpanelHethong);
        }
        private void btnDanhmuc_Click(object sender, EventArgs e)
        {
            showSubMenu(subpanelDanhmuc);
        }
        private void btnChucnang_Click(object sender, EventArgs e)
        {
            showSubMenu(subpanelChucnang);
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                infor = "Bạn chưa đăng nhập!";
                UpdateLoginState();

                PanelMain.Controls.Clear();

                frmLogin loginForm = new frmLogin
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                };

                loginForm.LoginSuccess += LoginForm_LoginSuccess;
                PanelMain.Controls.Add(loginForm);
                loginForm.Show();
                CenterFormInPanel(loginForm);
            }
        }

        // Xử lý sự kiện khi đăng nhập lại thành công
        private void LoginForm_LoginSuccess(object sender, string username)
        {
            infor = $"Đăng nhập thành công: {username}";
            UpdateLoginState();
            PanelMain.Controls.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Hàm căn giữa form trong PanelMain
        private void CenterFormInPanel(Form form)
        {
            int x = (PanelMain.Width - form.Width) / 2;
            int y = (PanelMain.Height - form.Height) / 2;
            form.Location = new Point(x, y);
        }

        // Đảm bảo khi kích thước PanelMain thay đổi, form vẫn ở giữa
        private void PanelMain_Resize(object sender, EventArgs e)
        {
            foreach (Control control in PanelMain.Controls)
            {
                if (control is frmLogin)
                {
                    CenterFormInPanel((Form)control);
                }
                else if (control is frmDangky)
                {
                    CenterFormInPanel((Form)control);
                }
            }
        }
        private void btnDangky_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();

            frmDangky dangky = new frmDangky
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
            };
            PanelMain.Controls.Add(dangky);
            dangky.Show();

            CenterFormInPanel(dangky);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();

            frmLogin loginForm = new frmLogin
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
            };

            PanelMain.Controls.Add(loginForm);
            loginForm.Show();

            CenterFormInPanel(loginForm);
        }


        private void btnDangkythe_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            frmCard cardForm = new frmCard
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
            };
            PanelMain.Controls.Add(cardForm);
            cardForm.Show();

            CenterFormInPanel(cardForm);
        }
        private void btnDatmay_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            var menuControl = new ThucDon(); 
            menuControl.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(menuControl);
            menuControl.BringToFront();
        }
        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            var taikhoan = new Taikhoan();
            taikhoan.Dock = DockStyle.Fill;
            PanelMain.Controls.Add(taikhoan);
            taikhoan.BringToFront();
        }
    }
}