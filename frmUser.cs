using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Do_anLaptrinhWinCK
{
    public partial class frmUser : Form
    {
        public static int ID { get; set; }
        public static int cardID { get; set; }
        public static string infor = "Bạn chưa đăng nhập!";
        public frmUser()
        {
            InitializeComponent();
            customizeDesign();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmUser(string _infor)
        {
            InitializeComponent();
            customizeDesign();
            infor = _infor;
            lblInfor.Text = infor;
        }
        private void frmUser_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            UpdateLoginState();
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
            subpanelChucnang.Visible = false;
        }
        private void hideSubMenu()
        {
            if (subpanelHethong.Visible)
                subpanelHethong.Visible = false;
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

            if (isLoggedIn)
            {
                btnChucnang.Enabled = true;
            }
            else
            {
                btnChucnang.Enabled = false;
            }
        }
        //Hiện thị subMenu
        private void btnHethong_Click(object sender, EventArgs e)
        {
            showSubMenu(subpanelHethong);
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
                else if (control is frmCard)
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
                TopLevel = false,               // Cho phép nhúng form này vào một control khác
                FormBorderStyle = FormBorderStyle.None,
            };

            PanelMain.Controls.Add(loginForm);
            loginForm.Show();
            CenterFormInPanel(loginForm);
        }

        private void btnchangepass_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();

            frmChangepass pass = new frmChangepass
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
            };
            PanelMain.Controls.Add(pass);
            pass.Show();
            CenterFormInPanel(pass);
        }

        private void btnDatdoan_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();

            frmOrder ord = new frmOrder
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            PanelMain.Controls.Add(ord);
            ord.Show();
            CenterFormInPanel(ord);

        }
        private void btnNaptien_Click_1(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();

            NapTien napTien = new NapTien
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            PanelMain.Controls.Add(napTien);
            napTien.Show();
            CenterFormInPanel(napTien);
        }
    }
}
