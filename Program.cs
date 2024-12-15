using System;
using System.Windows.Forms;

namespace Do_anLaptrinhWinCK
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin loginForm = new frmLogin();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                string userRole = loginForm.UserRole;

                if (userRole == "Admin" || userRole == "Nhân viên")
                {
                    Application.Run(new frmMain());
                }
                else if (userRole == "Người dùng")
                {
                    Application.Run(new frmUser());
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
