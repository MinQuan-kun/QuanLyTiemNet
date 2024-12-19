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
        private List<int> BillIDs;
        public InHoaDon(List<int> billIDs)
        {
            InitializeComponent();
            this.BillIDs = billIDs;
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                // Using LINQ to query the Bill table
                databaseDataContext db = new databaseDataContext();

                // Query to fetch bills by BillID using LINQ
                var billQuery = db.Bills
                                  .Where(b => this.BillIDs.Contains(b.BillID))
                                  .ToList();

                // Cấu hình ReportViewer
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "Do_anLaptrinhWinCK.ReportHoaDon.rdlc";

                // Create ReportDataSource
                ReportDataSource ds2 = new ReportDataSource
                {
                    Name = "HoaDonTable",
                    Value = billQuery
                };

                // Clear existing data sources and add the new one
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(ds2);

                // Refresh the report
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}