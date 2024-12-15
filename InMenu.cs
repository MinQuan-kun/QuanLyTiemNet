using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Do_anLaptrinhWinCK
{
    public partial class InMenu : Form
    {
        string strCon = @"Data Source=DESKTOP-O6VGHSO\SQLEXPRESS;Initial Catalog=QLTiemNet;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sqlCon = null;
        public InMenu()
        {
            InitializeComponent();
        }

        private void InMenu_Load(object sender, EventArgs e)
        {

            try
            {
                sqlCon = new SqlConnection(strCon);
                sqlCon.Open();

                string sql = "SELECT * FROM Menu";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlCon);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Menu");

                // Đặt Report Embedded Resource
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "Do_anLaptrinhWinCK.ReportMenu.rdlc";

                // Cấu hình DataSource cho report
                ReportDataSource ds2 = new ReportDataSource();
                ds2.Name = "MenuTable"; // Tên DataSet trong RDLC
                ds2.Value = ds.Tables["Menu"]; // Tên bảng dữ liệu trong DataSet
                this.reportViewer1.LocalReport.DataSources.Clear(); // Xóa các DataSource cũ
                this.reportViewer1.LocalReport.DataSources.Add(ds2);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}
