using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Do_anLaptrinhWinCK
{
    public partial class DonHang : Form
    {
        private bool isNoDataShow = false;
        public int SelectedMonth { get; set; }
        public int SelectedYear { get; set; }
        public int SelectedDay { get; set; }
        public DateTime selectedDate { get; set; }
        public DonHang()
        {
            InitializeComponent();
        }

        public void DonHang_Load(object sender, EventArgs e)
        {
            try
            {
                // Nếu đã hiển thị thông báo rồi thì không làm gì nữa
                if (isNoDataShow) return;

                // Lấy giá trị tháng và năm từ thuộc tính đã được truyền vào
                int year = SelectedYear;
                int month = SelectedMonth;

                using (var db = new databaseDataContext())
                {
                    var importQuery = db.ImportTables
                        .Where(import => import.ImportDate.HasValue && import.ImportDate.Value.Date == selectedDate.Date)
                        .Select(m => new
                        {
                            m.ImportID,
                            m.FoodID,
                            m.CategoryID,
                            m.Quantum,
                            m.SumPrice,
                            m.ImportDate,
                        })
                        .ToList();

                    if (importQuery.Any())
                    {
                        // Nếu có dữ liệu, tiếp tục cấu hình và hiển thị báo cáo
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "Do_anLaptrinhWinCK.ReportDonHang.rdlc";

                        // Cấu hình DataSource cho report
                        ReportDataSource ds2 = new ReportDataSource
                        {
                            Name = "DonHangTable", // Tên DataSet trong RDLC
                            Value = importQuery   // DataTable được tạo từ LINQ
                        };

                        this.reportViewer1.LocalReport.DataSources.Clear(); // Xóa các DataSource cũ
                        this.reportViewer1.LocalReport.DataSources.Add(ds2);

                        this.reportViewer1.RefreshReport();
                    }
                    else
                    {
                        // Nếu không có dữ liệu, thông báo và không hiển thị báo cáo
                        MessageBox.Show("Không có dữ liệu trong bảng Menu.");
                        isNoDataShow = true;  // Đánh dấu là đã thông báo
                        this.reportViewer1.LocalReport.DataSources.Clear();  // Xóa các DataSource cũ nếu không có dữ liệu
                        this.reportViewer1.RefreshReport();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}