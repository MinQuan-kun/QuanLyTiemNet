using System;
using System.Windows.Forms;

namespace Do_anLaptrinhWinCK
{
    internal static class Program
    {
        public static string UserRole = string.Empty;
        [STAThread] // để mở thư mục
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (true)
            {
                // Mở form đăng nhập
                frmLogin loginForm = new frmLogin();
                DialogResult result = loginForm.ShowDialog();
                // Kiểm tra kết quả đăng nhập
                if (result == DialogResult.OK)
                {
                    UserRole = loginForm.UserRole;
                    // Mở form chính dựa trên vai trò
                    if (UserRole == "Admin")
                    {
                        Application.Run(new frmMain());
                    }
                    else if (UserRole == "Người dùng")
                    {
                        Application.Run(new frmUser());
                    }
                }
                else
                {
                    Application.Exit();
                    break;
                }
            }
        }
    }
}

