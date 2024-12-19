using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Do_anLaptrinhWinCK
{
    public partial class InMenu : Form
    {
        public InMenu()
        {
            InitializeComponent();
        }

        private void InMenu_Load(object sender, EventArgs e)
        {
            try
            {
                // Sử dụng LINQ để truy vấn bảng Menu
                using (var db = new databaseDataContext()) // Sử dụng DataContext
                {
                    // Lấy tất cả các bản ghi từ bảng Menu
                    var menuQuery = db.Menus.ToList(); // Thay thế cho câu lệnh SQL SELECT * FROM Menu

                    // Kiểm tra nếu có dữ liệu
                    if (menuQuery.Any())
                    {
                        // Cấu hình ReportViewer
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "Do_anLaptrinhWinCK.ReportMenu.rdlc";

                        // Tạo ReportDataSource
                        ReportDataSource ds2 = new ReportDataSource
                        {
                            Name = "MenuTable", // Tên DataSet trong RDLC
                            Value = menuQuery    // Dữ liệu từ LINQ query
                        };

                        // Xóa các DataSource cũ và thêm DataSource mới
                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(ds2);

                        // Refresh báo cáo
                        this.reportViewer1.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu trong bảng Menu.");
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