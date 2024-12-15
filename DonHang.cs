using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Do_anLaptrinhWinCK
{
    public partial class DonHang : Form
    {
        string strCon = @"Data Source=DESKTOP-O6VGHSO\SQLEXPRESS;Initial Catalog=QLTiemNet;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sqlCon = null;
        public int SelectedMonth { get; set; }
        public int SelectedYear { get; set; }

        public DonHang()
        {
            InitializeComponent();
        }

        public void DonHang_Load(object sender, EventArgs e)
        {
            try
            {
                sqlCon = new SqlConnection(strCon);
                sqlCon.Open();

                // Lấy giá trị tháng và năm từ thuộc tính đã được truyền vào
                int year = SelectedYear;
                int month = SelectedMonth;

                // Cập nhật câu truy vấn SQL để lọc theo tháng và năm của ImportDate
                string sql = "SELECT * FROM ImportTable WHERE YEAR(ImportDate) = @Year AND MONTH(ImportDate) = @Month";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlCon);
                adapter.SelectCommand.Parameters.AddWithValue("@Year", year);
                adapter.SelectCommand.Parameters.AddWithValue("@Month", month);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "ImportTable");

                // Đặt Report Embedded Resource
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "Do_anLaptrinhWinCK.ReportDonHang.rdlc";

                // Cấu hình DataSource cho report
                ReportDataSource ds2 = new ReportDataSource();
                ds2.Name = "DonHangTable"; // Tên DataSet trong RDLC
                ds2.Value = ds.Tables["ImportTable"]; // Tên bảng dữ liệu trong DataSet
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
