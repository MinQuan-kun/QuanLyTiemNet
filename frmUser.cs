using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
        private decimal currentBalance;
        private int remainingSeconds;
        private DateTime startTime;  // Lưu thời gian bắt đầu
        private TimeSpan elapsedTime;  // Lưu thời gian đã trôi qua
        private Timer playTimer; // Timer để giảm giờ chơi
        private const decimal COST_PER_SECOND = 2.78m;
        public frmUser()
        {
            InitializeComponent();
            customizeDesign();
            this.StartPosition = FormStartPosition.CenterScreen;
            playTimer = new Timer();
            playTimer.Interval = 1000;  // Thiết lập thời gian quay lại mỗi 1000 ms (1 giây)
            playTimer.Tick += timer2_Tick;  // Gán sự kiện Tick để xử lý khi timer hết thời gian
            playTimer.Start();  // Bắt đầu timer
            LoadCardInfo();
        }

        private void LoadCardInfo()
        {
            using (var db = new databaseDataContext())
            {
                var card = db.Cards.FirstOrDefault(c => c.UserID == ID && c.Stas == "đang hoạt động");

                if (card != null)
                {
                    currentBalance = (decimal)card.Balance;
                    remainingSeconds = (int)(currentBalance / COST_PER_SECOND);  // Tính số giây còn lại

                    startTime = DateTime.Now;  // Lưu thời gian bắt đầu
                    elapsedTime = TimeSpan.Zero;  // Thời gian đã trôi qua bằng 0 khi bắt đầu

                    // Chuyển số giây còn lại thành giờ, phút, giây
                    TimeSpan remainingTime = TimeSpan.FromSeconds(remainingSeconds);
                    string formattedTime = remainingTime.ToString(@"hh\:mm\:ss");
                    lblPlayTime.Text = $"Thời gian chơi còn lại: {formattedTime}";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thẻ của bạn hoặc thẻ đã bị khóa.");
                }
            }
        }
        private void UpdateBalanceInDatabase(decimal newBalance)
        {
            using (var db = new databaseDataContext())
            {
                var card = db.Cards.FirstOrDefault(c => c.UserID == ID && c.Stas == "đang hoạt động");

                if (card != null)
                {
                    card.Balance = newBalance;  // Cập nhật số dư mới

                    // Lưu thay đổi vào cơ sở dữ liệu
                    db.SubmitChanges();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thẻ của bạn hoặc thẻ đã bị khóa.");
                }
            }
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            elapsedTime = DateTime.Now - startTime;  // Tính thời gian đã trôi qua

            // Nếu số giây còn lại và số dư đủ, giảm thời gian và số dư
            if (remainingSeconds > 0 && currentBalance >= COST_PER_SECOND)
            {
                remainingSeconds--;  // Giảm số giây
                currentBalance -= COST_PER_SECOND;  // Trừ số dư theo giây

                // Cập nhật thời gian còn lại theo định dạng hh:mm:ss
                TimeSpan remainingTime = TimeSpan.FromSeconds(remainingSeconds);  // Chuyển số giây còn lại thành TimeSpan
                string formattedTime = remainingTime.ToString(@"hh\:mm\:ss");  // Định dạng: giờ:phút:giây
                lblPlayTime.Text = $"Thời gian chơi còn lại: {formattedTime}";

                // Cập nhật cơ sở dữ liệu
                UpdateBalanceInDatabase(currentBalance);

                // Dừng khi hết thời gian hoặc số dư không đủ
                if (remainingSeconds == 0 || currentBalance < COST_PER_SECOND)
                {
                    playTimer.Stop();  // Dừng Timer
                    lblPlayTime.Text = "Thời gian chơi đã hết!";
                    MessageBox.Show("Thẻ của bạn đã hết thời gian hoặc số dư không đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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

                frmLogin loginForm = new frmLogin();
                loginForm.Show();
                this.Close();
            }
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

        private void btnNhantin_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();

            frmMessage nhanTin = new frmMessage
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            PanelMain.Controls.Add(nhanTin);
            nhanTin.Show();
            CenterFormInPanel(nhanTin);
        }

        private void btnNaptien_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();

            NapTien nap = new NapTien
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            PanelMain.Controls.Add(nap);
            nap.Show();
            CenterFormInPanel(nap);
        }
    }
}
