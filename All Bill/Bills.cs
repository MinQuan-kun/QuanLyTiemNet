using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Do_anLaptrinhWinCK.All_Bill
{
    public partial class Bills : UserControl
    {
        public Bills()
        {
            InitializeComponent();
        }

        private void Bills_Load(object sender, EventArgs e)
        {
            loadDuLieu();
            dgvbill.CellFormatting += dgvbill_CellFormatting;
            dgvbill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvbill.MultiSelect = true;

            Default();
        }

        private void Default()
        {
            txtbillID.Enabled = false;
            txtTotalprice.Enabled = false;
            cbType.Enabled = false;
        }

        private void loadDuLieu()
        {
            using (databaseDataContext db = new databaseDataContext())
            {
                dgvbill.DataSource = db.Bills
                    .OrderBy(m => m.BillID)
                    .Select(m => new
                    {
                        m.BillID,
                        m.UserID,
                        m.TotalAmount,
                        m.CreatedAt,
                        m.Status,
                    }).ToList();
            }
        }

        private void dgvbill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = e.RowIndex;
            if (idrow < 0 || idrow >= dgvbill.Rows.Count - (dgvbill.AllowUserToAddRows ? 1 : 0))
                return;

            HienthiDuLieuDong(idrow);
        }

        private void HienthiDuLieuDong(int idrow)
        {
            using (databaseDataContext db = new databaseDataContext())
            {
                int billID = int.Parse(dgvbill.Rows[idrow].Cells[0].Value.ToString());
                var bill = db.Bills.SingleOrDefault(p => p.BillID == billID);

                if (bill != null)
                {
                    txtbillID.Text = bill.BillID.ToString();
                    txtTotalprice.Text = bill.TotalAmount.ToString();
                    cbType.Text = bill.Status.ToString();
                }
            }
        }
        private void btnInds_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgvbill.SelectedRows.Count > 0)
            {
                // Lấy danh sách BillID từ các dòng được chọn
                var selectedBillIDs = dgvbill.SelectedRows
                    .Cast<DataGridViewRow>()
                    .Select(row => int.Parse(row.Cells["BillID"].Value.ToString()))
                    .ToList();

                // Mở form InHoaDon và truyền danh sách BillID
                InHoaDon inHD = new InHoaDon(selectedBillIDs);
                inHD.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một hóa đơn để in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            int ID = int.Parse(txtbillID.Text);
            Bill bill = db.Bills.SingleOrDefault(c => c.BillID == ID);
            if(bill.Status == "Đang xử lý")
            {
                bill.Status = "Hoàn thành";
                db.SubmitChanges();
                loadDuLieu();
                MessageBox.Show("Đơn đặt đã thanh toán thành công!", "Thông báo", MessageBoxButtons.OK);
            }    
            else
            {
                MessageBox.Show("Không thể xác nhận đơn này!", "Thông báo", MessageBoxButtons.OK);
                return;
            }    
        }

        // Chỉnh màu cho từng đơn
        private void dgvbill_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvbill.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "Đang xử lý")
                {
                    e.CellStyle.BackColor = Color.Yellow;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else if (status == "Hoàn thành")
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (status == "Đã hủy")
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }
    }
}