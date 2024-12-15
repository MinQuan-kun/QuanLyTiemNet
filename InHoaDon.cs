using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Do_anLaptrinhWinCK
{
    public partial class InHoaDon : Form
    {
        string strCon = @"Data Source=DESKTOP-O6VGHSO\SQLEXPRESS;Initial Catalog=QLTiemNet;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sqlCon = null;

        private List <int> BillIDs;
        public InHoaDon(List <int> billIDs)
        {
            InitializeComponent();
            this.BillIDs = billIDs;
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                sqlCon = new SqlConnection(strCon);
                sqlCon.Open();

                // Truy vấn chỉ lấy hóa đơn với BillID
                string sql = "SELECT * FROM Bill WHERE BillID IN (" + string.Join(",",this.BillIDs) + ")";

                SqlDataAdapter adapter = new SqlDataAdapter(sql,sqlCon);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Bill");

                // Cấu hình ReportViewer
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "Do_anLaptrinhWinCK.ReportHoaDon.rdlc";
                ReportDataSource ds2 = new ReportDataSource
                {
                    Name = "HoaDonTable",
                    Value = ds.Tables["Bill"]
                };
                this.reportViewer1.LocalReport.DataSources.Clear();
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
