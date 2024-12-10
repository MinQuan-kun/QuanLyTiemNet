using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Do_anLaptrinhWinCK
{
    public partial class frmAdd : Form
    {
        public static int ID;
        public decimal Total = 0;
        public frmAdd()
        {
            InitializeComponent();
            LoadName();
        }
        private void frmAdd_Load(object sender, EventArgs e)
        {
            Default();
            Setup();
        }
        private void LoadName()
        {
            databaseDataContext db = new databaseDataContext();
            var Foodname = from menu in db.Menus
                            select menu.FoodName;
            cbName.Items.Clear();

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
        }

        private void Setup()
        {
            string username = frmMain.infor.Split(':').Last().Trim();
            using (databaseDataContext db = new databaseDataContext())
            {
                Admin user = db.Admins.SingleOrDefault(p => p.Username == username);
                ID = user.ID;
            }
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
            lblTongtien.Text = "Tổng tiền: " + Total.ToString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Code in danh sách
        }

        private void cbCategory_Leave(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            string Name = cbCategory.Text;
            Category selectCategory = db.Categories.FirstOrDefault(p => p.CategoryName == Name);
            int categoryID = selectCategory.CategoryID; // Lấy categoryID
            var result = from menu in db.Menus
                         where menu.CategoryID == categoryID
                         select new
                         {
                             menu.FoodName,
                             SumPrice = 0.00,
                             menu.Quantity,
                             Quantum = 0,
                             CustomerID = ID
                         };
            dgvNhap.DataSource = result.ToList();
        }

        private void cbName_Leave(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            string Name = cbName.Text;
            Menu SelectFood = db.Menus.FirstOrDefault(p => p.FoodName == Name);
            int foodID = SelectFood.FoodID; // Lấy foodID
            var result = from menu in db.Menus
                         where menu.FoodID == foodID
                         select new
                         {
                             menu.FoodName,
                             SumPrice = 0.00,
                             menu.Quantity,
                             Quantum = 0,
                             CustomerID = ID
                         };
            dgvNhap.DataSource = result.ToList();
        }

        private void dgvNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = e.RowIndex;
            if (idrow < 0 || idrow >= dgvNhap.Rows.Count)
                return;
            HienthiDuLieuDong(idrow);
        }
        private void HienthiDuLieuDong(int idrow)
        {
            databaseDataContext db = new databaseDataContext();
            string name = dgvNhap.Rows[idrow].Cells[0].Value.ToString();
            Menu m = db.Menus.Where(p => p.FoodName == name).FirstOrDefault();
            Category c = db.Categories.Where(p => p.CategoryID == m.CategoryID).FirstOrDefault();
            Admin a = db.Admins.Where(p => p.ID == ID).FirstOrDefault();
            txtCategoryID.Text = c.CategoryID.ToString();
            txtFoodID.Text = m.FoodID.ToString();
            txtUser.Text = a.Username.ToString();
            int? maxImportID = db.ImportTables.Max(p => (int?)p.ImportID);
            int newImportID = (maxImportID.HasValue ? maxImportID.Value + 1 : 1);
            txtImportID.Text = newImportID.ToString();
        }

        private void txtQuantum_Leave(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng chưa nhập gì thì thoát
            if (string.IsNullOrEmpty(txtQuantum.Text)) return;

            int quantity = 0;

            if (!int.TryParse(txtQuantum.Text, out quantity))
            {
                MessageBox.Show("Số lượng nhập không hợp lệ.");
                return;
            }

            int foodID = int.Parse(txtFoodID.Text);
            using (databaseDataContext db = new databaseDataContext())
            {
                Menu selectedFood = db.Menus.FirstOrDefault(p => p.FoodID == foodID);
                decimal sumPrice = selectedFood.Price * quantity;
                var result = from menu in db.Menus
                             where menu.FoodID == foodID
                             select new
                             {
                                 menu.FoodName,
                                 SumPrice = sumPrice,
                                 menu.Quantity,
                                 Quantum = quantity,
                                 CustomerID = ID
                             };
                dgvNhap.DataSource = result.ToList();
            }
        }
    }
}
