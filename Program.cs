using System;
using System.Linq;
using System.Windows.Forms;

namespace Do_anLaptrinhWinCK
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin loginForm = new frmLogin();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                if (frmMain.infor.StartsWith("Admin"))
                {
                    // Nếu là Admin, mở frmMain
                    Application.Run(new frmMain());
                }
                else if (frmMain.infor.StartsWith("Người dùng"))
                {
                    // Nếu là User, mở frmUser
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
