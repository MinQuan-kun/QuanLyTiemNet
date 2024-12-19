using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Do_anLaptrinhWinCK
{
    public partial class frmAdd : Form
    {
        public static int ID;
        public decimal Total = 0;
        private BindingList<FoodItem> dgvIn = new BindingList<FoodItem>(); // danh sách các món tạm
        public class FoodItem
        {
            public string FoodName { get; set; }
            public decimal SumPrice { get; set; }
            public int Quantity { get; set; }
            public int Quantum { get; set; }
            public int CustomerID { get; set; }
        }

        public frmAdd()
        {
            InitializeComponent();
            LoadName();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            Default();
            dateTimePickerMonth.Format = DateTimePickerFormat.Custom;
            dateTimePickerMonth.CustomFormat = "MM/yyyy"; // Chỉ hiển thị tháng và năm

            Setup();
        }

        //Cập nhật các món cho combobox cbName
        private void LoadName()
        {
            databaseDataContext db = new databaseDataContext();
            var Foodname = db.Menus.Select(menu => menu.FoodName);
            foreach (var item in Foodname)
            {
                cbName.Items.Add(item);
            }
        }

        private void Default()
        {
            txtCategoryID.Enabled = false;
            txtFoodID.Enabled = false;
            txtImportID.Enabled = false;
            txtUser.Enabled = false;
            txtQuantum.Enabled = false;
            btnXoa.Enabled = false;
        }

        // Lấy mã người quản lý
        private void Setup()
        {
            string username = frmMain.infor.Split(':').Last().Trim();
            using (databaseDataContext db = new databaseDataContext())
            {
                Admin user = db.Admins.SingleOrDefault(p => p.Username == username);
                ID = user.ID;
            }
        }

        private void cbCategory_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbCategory.Text)) return;

            databaseDataContext db = new databaseDataContext();
            string name = cbCategory.Text;

            var selectCategory = db.Categories.FirstOrDefault(p => p.CategoryName == name);
            if (selectCategory != null)
            {
                var admin = db.Admins.FirstOrDefault(p => p.ID == ID);

                txtCategoryID.Text = selectCategory.CategoryID.ToString();
                txtUser.Text = admin?.Username ?? "Không xác định";

                int categoryID = selectCategory.CategoryID;

                var result = db.Menus
                               .Where(menu => menu.CategoryID == categoryID)
                               .Select(menu => new
                               {
                                   menu.FoodName,
                                   SumPrice = 0.00,
                                   menu.Quantity,
                                   Quantum = 0,
                                   CustomerID = ID
                               }).ToList();

                dgvNhap.DataSource = result;
            }
            else
            {
                MessageBox.Show("Lỗi, tên thể loại này không tồn tại", "Thông báo", MessageBoxButtons.OK);
                cbCategory.Focus();
            }
        }

        private void cbName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbName.Text)) return;

            databaseDataContext db = new databaseDataContext();
            string name = cbName.Text;

            // Tìm món ăn theo tên
            var selectFood = db.Menus.FirstOrDefault(p => p.FoodName == name);
            if (selectFood != null)
            {
                // Tìm Admin theo ID
                var admin = db.Admins.FirstOrDefault(p => p.ID == ID);

                txtCategoryID.Text = selectFood.CategoryID.ToString();
                txtFoodID.Text = selectFood.FoodID.ToString();
                txtUser.Text = admin.Username;

                // Truy vấn món ăn theo tên
                var result = db.Menus
                               .Where(menu => menu.FoodName == name)
                               .Select(menu => new
                               {
                                   FoodName = menu.FoodName,
                                   SumPrice = 0, // Giá trị mặc định
                                   Quantity = menu.Quantity,
                                   Quantum = 0, // Giá trị mặc định
                                   CustomerID = ID // ID người dùng
                               }).ToList();

                dgvNhap.DataSource = result;
            }
            else
            {
                MessageBox.Show("Lỗi, tên món này không tồn tại", "Thông báo", MessageBoxButtons.OK);
                cbName.Focus();
            }
        }

        private void dgvNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = e.RowIndex;
            if (idrow < 0 || idrow >= dgvNhap.Rows.Count)
                return;
            HienthiDuLieuDong(idrow);
            txtQuantum.Enabled = true;
            btnXoa.Enabled = true;
        }
        private void HienthiDuLieuDong(int idrow)
        {
            databaseDataContext db = new databaseDataContext();
            string name = dgvNhap.Rows[idrow].Cells[0].Value.ToString();

            // Lấy thông tin món
            var menuInfo = db.Menus
                             .Where(m => m.FoodName == name)
                             .Select(m => new
                             {
                                 m.FoodID,
                                 m.CategoryID,
                                 CategoryName = m.Category.CategoryName
                             })
                             .FirstOrDefault();

            // Lấy thông tin admin
            var adminInfo = db.Admins
                              .Where(a => a.ID == ID)
                              .Select(a => a.Username)
                              .FirstOrDefault();

            // Lấy mã nhập hàng max
            int newImportID = db.ImportTables
                               .Max(p => (int?)p.ImportID) + 1 ?? 1;

            if (menuInfo != null)
            {
                txtCategoryID.Text = menuInfo.CategoryID.ToString();
                txtFoodID.Text = menuInfo.FoodID.ToString();
            }
            txtUser.Text = adminInfo ?? "Không xác định";
            txtImportID.Text = newImportID.ToString();
        }

        private void txtQuantum_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantum.Text)) return;
            else
            {
                int soluong = 0;

                // Kiểm tra xem số lượng nhập vào có hợp lệ không
                if (!int.TryParse(txtQuantum.Text, out soluong) || soluong <= 0)
                {
                    MessageBox.Show("Số lượng nhập không hợp lệ.");
                    return;
                }
                int foodID = int.Parse(txtFoodID.Text);
                databaseDataContext db = new databaseDataContext();
                Menu m = db.Menus.FirstOrDefault(p => p.FoodID == foodID);
                int? maxImportID = db.ImportTables.Max(p => (int?)p.ImportID);
                int newImportID = (maxImportID.HasValue ? maxImportID.Value + 1 : 1);
                decimal sumPrice = m.Price * soluong;
                var newItem = new FoodItem
                {
                    FoodName = m.FoodName,
                    SumPrice = sumPrice,
                    Quantity = m.Quantity,
                    Quantum = soluong,
                    CustomerID = ID,
                };
                dgvIn.Add(newItem);
                //Làm mới lại dgvNhap
                dgvNhap.DataSource = null;
                dgvNhap.DataSource = dgvIn;
                dgvNhap.Columns["FoodName"].HeaderText = "Tên món";
                dgvNhap.Columns["SumPrice"].HeaderText = "Giá nhập";
                dgvNhap.Columns["Quantity"].HeaderText = "Tồn kho";
                dgvNhap.Columns["Quantum"].HeaderText = "Số lượng nhập";
                dgvNhap.Columns["CustomerID"].HeaderText = "Mã người nhập";
                Default();
            }
        }

        private void Reset()
        {
            // Xóa dữ liệu trong các ComboBox
            cbName.Text = "";
            cbCategory.Text = "";

            // Xóa dữ liệu trong các TextBox
            txtFoodID.Text = "";
            txtCategoryID.Text = "";
            txtQuantum.Text = "";
            txtUser.Text = "";
            txtImportID.Text = "";

            // Xóa dữ liệu trong các danh sách lưu trữ
            dgvIn.Clear();
            // Làm mới DataGridView
            dgvNhap.DataSource = dgvIn;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCategory.Text = "";
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbName.Text = "";
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhap.SelectedRows.Count > 0)
            {
                // Lấy chỉ số của dòng được chọn
                int selectedRowIndex = dgvNhap.SelectedRows[0].Index;

                // Xóa món ăn khỏi danh sách dgvIn
                dgvIn.RemoveAt(selectedRowIndex);

                // Làm mới lại DataGridView
                dgvNhap.DataSource = null;
                dgvNhap.DataSource = dgvIn;

                // Cập nhật lại trạng thái các ô TextBox và ComboBox nếu cần thiết
                txtFoodID.Text = "";
                txtCategoryID.Text = "";
                txtQuantum.Text = "";
                txtUser.Text = "";
                txtImportID.Text = "";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món ăn để xóa.");
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Code in danh sách
            DonHang inDH = new DonHang();
            inDH.selectedDate = dateTimePickerMonth.Value;
            // Gọi lại hàm DonHang_Load để lọc dữ liệu theo tháng và năm
            inDH.DonHang_Load(sender, e);
            inDH.ShowDialog();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            int? maxImportID = db.ImportTables.Max(p => (int?)p.ImportID);
            int newImportID = (maxImportID.HasValue ? maxImportID.Value + 1 : 1);

            foreach (DataGridViewRow row in dgvNhap.Rows)
            {
                if (row.Cells["FoodName"].Value != null && row.Cells["Quantum"].Value != null && row.Cells["SumPrice"].Value != null)
                {
                    string foodName = row.Cells["FoodName"].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells["Quantum"].Value);
                    decimal sumPrice = Convert.ToDecimal(row.Cells["SumPrice"].Value);

                    Menu selectedFood = db.Menus.FirstOrDefault(p => p.FoodName == foodName);
                    ImportTable newImport = new ImportTable
                    {
                        ImportID = newImportID,
                        FoodID = selectedFood.FoodID,
                        CategoryID = selectedFood.CategoryID.GetValueOrDefault(),
                        Quantum = quantity,
                        SumPrice = sumPrice,
                        ImportDate = DateTime.Now,
                        CustomerID = ID
                    };
                    Total += newImport.Quantum * selectedFood.Price;
                    db.ImportTables.InsertOnSubmit(newImport);
                }
            }

            db.SubmitChanges();
            MessageBox.Show("Cập nhật số lượng hàng thành công!");
            lblTongtien.Text = "Tổng tiền: " + Total.ToString() + "VNĐ";
            Reset();
            Default();
        }
    }
}
