using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Do_anLaptrinhWinCK
{
    public partial class frmOrder : Form
    {
        public static int ID;
        public static decimal total;
        public class FoodItem
        {
            public string FoodName { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public decimal TotalPrice { get; set; }
        }
        private BindingList<FoodItem> dgvIn = new BindingList<FoodItem>(); // danh sách các món tạm
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            loadDuLieu();
            Default();
            Setup();
        }
        private void Default()
        {
            txtTenmon.Enabled = false;
            txtprice.Enabled = false;
            txtSoluong.Enabled = false;
        }

        // Lấy mã người dùng
        public void Setup()
        {
            string username = frmUser.infor.Split(':').Last().Trim();
            using (databaseDataContext db = new databaseDataContext())
            {
                User user = db.Users.SingleOrDefault(p => p.Username == username);
                ID = user.UserID;
            }
        }

        private void loadDuLieu()
        {
            databaseDataContext db = new databaseDataContext();
            dgvorder.DataSource = db;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            PictureBox pictureBox = sender as PictureBox;

            if (pictureBox != null && pictureBox.Tag != null)
            {
                // Lấy thông tin món ăn từ Tag
                var item = pictureBox.Tag as Menu; // Lấy thông tin món ăn đã lưu trong Tag

                if (item != null)
                {
                    // Lấy dữ liệu chi tiết món ăn theo FoodID
                    var result = db.Menus
                                   .Where(menu => menu.FoodID == item.FoodID)
                                   .Select(menu => new
                                   {
                                       FoodName = menu.FoodName,
                                       Price = menu.Price,
                                       Quantity = 0, // Ban đầu là 0
                                       TotalPrice = 0.00 // Thành tiền ban đầu là 0.00
                                   }).ToList();

                    // Hiển thị dữ liệu lên dgvorder
                    dgvorder.DataSource = result;
                    txtTenmon.Text = item.FoodName;
                    txtprice.Text = item.Price.ToString();
                }
            }
            txtSoluong.Enabled = true;
        }


        private void LoadPictureBoxes(int? categoryID = null)
        {
            databaseDataContext db = new databaseDataContext();
            var query = db.Menus.AsQueryable();

            if (categoryID.HasValue)
            {
                query = query.Where(menu => menu.CategoryID == categoryID.Value);
            }

            var data = query.Select(menu => new
            {
                menu.FoodID,
                menu.CategoryID,
                menu.FoodName,
                menu.Image
            }).ToList();

            if (panelhinh.Controls.Count == 0 || !(panelhinh.Controls[0] is FlowLayoutPanel))
            {
                FlowLayoutPanel flowPanel = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true,
                    FlowDirection = FlowDirection.LeftToRight,
                    WrapContents = true,
                    Padding = new Padding(5)
                };
                panelhinh.Controls.Add(flowPanel);
            }

            FlowLayoutPanel currentFlowPanel = (FlowLayoutPanel)panelhinh.Controls[0];
            currentFlowPanel.Controls.Clear();

            foreach (var item in data)
            {
                PictureBox pictureBox = new PictureBox
                {
                    Width = 200,
                    Height = 200,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = db.Menus.FirstOrDefault(m => m.FoodID == item.FoodID) // Lưu đối tượng Menu vào Tag
                };

                // Đăng ký sự kiện Click cho PictureBox
                pictureBox.Click += new EventHandler(PictureBox_Click);

                if (item.Image != null && item.Image.Length > 0)
                {
                    try
                    {
                        using (var ms = new MemoryStream(item.Image.ToArray()))
                        {
                            pictureBox.Image = Image.FromStream(ms);
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Error loading image: {ex.Message}");
                        pictureBox.BackColor = Color.Gray;
                    }
                }
                else
                {
                    pictureBox.BackColor = Color.Gray;
                }

                currentFlowPanel.Controls.Add(pictureBox);
            }
        }


        private void btnSnack_Click(object sender, EventArgs e)
        {
            LoadPictureBoxes(3);
        }

        private void btnMi_Click(object sender, EventArgs e)
        {
            LoadPictureBoxes(4);
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            LoadPictureBoxes(1);
        }

        private void btnNuoc_Click(object sender, EventArgs e)
        {
            LoadPictureBoxes(2);
        }

        private void btnKem_Click(object sender, EventArgs e)
        {
            LoadPictureBoxes(5);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadPictureBoxes();
        }

        private void txtSoluong_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoluong.Text)) return;

            if (!int.TryParse(txtSoluong.Text, out int soluong) || soluong < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập số nguyên không âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluong.Focus();
                return;
            }

            string name = txtTenmon.Text;

            databaseDataContext db = new databaseDataContext();
            Menu selectedFood = db.Menus.FirstOrDefault(p => p.FoodName == name);
            if(selectedFood.Quantity < soluong || selectedFood.Quantity <= 0)
            {
                MessageBox.Show("Số lượng món hiện tại trong kho không đủ cung cấp!", "Thông báo", MessageBoxButtons.OK);
                return;
            } 
            else
            {
                decimal sumprice = selectedFood.Price * soluong;
                var newItem = new FoodItem
                {
                    FoodName = selectedFood.FoodName,
                    Price = selectedFood.Price,
                    Quantity = soluong,
                    TotalPrice = sumprice,
                };
                dgvIn.Add(newItem);
                // Cập nhật tổng tiền
                total += sumprice;
                lblTongtien.Text = "Tổng tiền: " + total.ToString() + " VNĐ";
                // Làm mới lại dgvorder
                dgvorder.DataSource = null;
                dgvorder.DataSource = dgvIn;
                dgvorder.Columns["FoodName"].HeaderText = "Tên món";
                dgvorder.Columns["Price"].HeaderText = "Đơn giá";
                dgvorder.Columns["Quantity"].HeaderText = "Số lượng";
                dgvorder.Columns["TotalPrice"].HeaderText = "Thành tiền";
                Default();
            }
        }

        private void HienthiDuLieuDong(int idrow)
        {
            databaseDataContext db = new databaseDataContext();
            string name = dgvorder.Rows[idrow].Cells[0].Value.ToString();
            Menu m = db.Menus.Where(p => p.FoodName == name).FirstOrDefault();
            txtTenmon.Text = m.FoodName;
            txtprice.Text = m.Price.ToString();
        }

        private void dgvorder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = e.RowIndex;
            if (idrow < 0 || idrow >= dgvorder.Rows.Count)
                return;
            HienthiDuLieuDong(idrow);
            databaseDataContext db = new databaseDataContext();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dgvorder.CurrentRow != null)
            {
                int selectedRowIndex = dgvorder.CurrentRow.Index;

                if (selectedRowIndex >= 0 && selectedRowIndex < dgvIn.Count)
                {
                    decimal itemTotalPrice = Convert.ToDecimal(dgvorder.Rows[selectedRowIndex].Cells["TotalPrice"].Value);
                    total -= itemTotalPrice; // Cập nhật lại tổng tiền khi xóa món

                    dgvIn.RemoveAt(selectedRowIndex);

                    // Làm mới các trường nhập liệu
                    txtprice.Text = "";
                    txtSoluong.Text = "";
                    txtTenmon.Text = "";
                }
                else
                {
                    MessageBox.Show("Dòng không hợp lệ để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Cập nhật lại tổng tiền
            lblTongtien.Text = "Tổng tiền: " + total.ToString() + " VNĐ";
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtprice.Text = "";
            txtSoluong.Text = "";
            txtTenmon.Text = "";
            dgvIn.Clear();
            dgvorder.DataSource = dgvIn;

            // Cập nhật lại tổng tiền
            total = 0;
            lblTongtien.Text = "Tổng tiền: " + total.ToString() + " VNĐ";
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            dgvorder.DataSource = dgvIn;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            if (dgvorder.Rows.Count == 0 || dgvorder.Rows.Cast<DataGridViewRow>().All(row => row.Cells["FoodName"].Value == null) || string.IsNullOrEmpty(txtSoluong.Text))
            {
                MessageBox.Show("Giỏ hàng của bạn không có món ăn nào! Vui lòng thêm món trước khi thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng lại nếu giỏ hàng trống
            }
            lblTongtien.Text = "Tổng tiền: " + total.ToString() + " VNĐ"; // Cập nhật lại tổng tiền

            databaseDataContext db = new databaseDataContext();
            frmPayment paymentForm = new frmPayment();
            if (paymentForm.ShowDialog() == DialogResult.OK)
            {
                string selectedMethod = paymentForm.PaymentMethod;
                // Thêm hóa đơn
                Bill b = new Bill
                {
                    UserID = ID,
                    Status = selectedMethod == "Tiền mặt" ? "Đang xử lý" : "Hoàn thành", // Kiểm tra phương thức thanh toán
                    CreatedAt = DateTime.Now,
                };
                db.Bills.InsertOnSubmit(b);
                db.SubmitChanges();
                if (selectedMethod == "Tiền mặt")
                {
                    MessageBox.Show("Bạn đã chọn thanh toán bằng Tiền mặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int? maxBillID = db.Bills.Max(p => (int?)p.BillID);
                    int newBillID = (maxBillID.HasValue ? maxBillID.Value + 1 : 1);
                    foreach (DataGridViewRow row in dgvorder.Rows)
                    {
                        if (row.Cells["FoodName"].Value != null &&
                            row.Cells["Price"].Value != null &&
                            row.Cells["Quantity"].Value != null &&
                            row.Cells["TotalPrice"].Value != null)
                        {
                            string foodName = row.Cells["FoodName"].Value.ToString();
                            int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                            decimal sumPrice = Convert.ToDecimal(row.Cells["TotalPrice"].Value);
                            Menu m = db.Menus.FirstOrDefault(p => p.FoodName == foodName);
                            BillDetail bd = new BillDetail
                            {
                                BillID = b.BillID,
                                UserID = ID,
                                FoodID = m.FoodID,
                                Quantity = quantity,
                                Price = m.Price,
                            };
                            db.BillDetails.InsertOnSubmit(bd);
                            db.SubmitChanges();
                        }
                        else
                        {
                            MessageBox.Show("Hiện tại chưa có món nào!", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    MessageBox.Show("Đơn hàng của bạn đang chờ thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Default();
                }
                else if (selectedMethod == "Chuyển khoản")
                {
                    MessageBox.Show("Bạn đã chọn thanh toán bằng Chuyển khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int? maxBillID = db.Bills.Max(p => (int?)p.BillID);
                    int newBillID = (maxBillID.HasValue ? maxBillID.Value + 1 : 1);
                    foreach (DataGridViewRow row in dgvorder.Rows)
                    {
                        if (row.Cells["FoodName"].Value != null &&
                            row.Cells["Price"].Value != null &&
                            row.Cells["Quantity"].Value != null &&
                            row.Cells["TotalPrice"].Value != null)
                        {
                            string foodName = row.Cells["FoodName"].Value.ToString();
                            int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                            decimal sumPrice = Convert.ToDecimal(row.Cells["TotalPrice"].Value);
                            Menu m = db.Menus.FirstOrDefault(p => p.FoodName == foodName);
                            BillDetail bd = new BillDetail
                            {
                                BillID = b.BillID,
                                UserID = ID,
                                FoodID = m.FoodID,
                                Quantity = quantity,
                                Price = m.Price,
                            };
                            m.Quantity -= bd.Quantity;
                            db.BillDetails.InsertOnSubmit(bd);
                            db.SubmitChanges();
                        }
                        else
                        {
                            MessageBox.Show("Hiện tại chưa có món nào!", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    MessageBox.Show("Đơn hàng của bạn cook, vui lòng đợi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Default();
                }
            }
            dgvIn.Clear();
            dgvorder.DataSource = dgvIn;
        }
    }
}