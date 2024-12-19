using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;



namespace Do_anLaptrinhWinCK.All_Computer
{
    public partial class ThucDon : UserControl
    {

        // Cờ đánh dấu cho các chức năng thêm, xóa, tìm, sửa, inds
        public bool them = false;
        public bool xoa = false;
        public bool tim = false;
        public bool sua = false;
        public ThucDon()
        {
            InitializeComponent();
        }

        private void ThucDon_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        // Hàm mặc định
        private void Default()
        {
            // vô hiệu các nút
            txtPrice.Enabled = false;
            txtCategoryID.Enabled = false;
            txtFoodID.Enabled = false;
            txtFoodName.Enabled = false;
            pcAdd.Enabled = false;
            // reset các dữ liệu đang có trên textbox và pic
            txtFoodID.Text = null;
            txtFoodName.Text = null;
            txtCategoryID.Text = null;
            pcAdd.Image = null;
            // mặc định các trạng thái cờ bằng false
            them = false;
            xoa = false;
            tim = false;
            sua = false;

        }

        //Hàm load dữ liệu
        private void loadDuLieu()
        {
            using (databaseDataContext db = new databaseDataContext())
            {
                dgvMenu.DataSource = db.Menus
                    .OrderBy(m => m.CategoryID)
                    .Select(m => new
                    {
                        m.FoodName,
                        m.FoodID,
                        m.CategoryID,
                        m.Quantity,
                        m.Price
                    }).ToList();
            }
            LoadPictureBoxes(); // Load toàn bộ ảnh menu
        }

        private void LoadPictureBoxes(int? categoryID = null)
        {
            databaseDataContext db = new databaseDataContext();
            var query = db.Menus.AsQueryable();

            // Nếu có mã loại
            if (categoryID.HasValue)
            {
                query = query.Where(menu => menu.CategoryID == categoryID.Value);
            }

            var data = query.Select(menu => new
            {
                menu.FoodID,
                menu.CategoryID,
                menu.FoodName,
                menu.Image,
                menu.Price,
                menu.Quantity
            }).ToList();
            dgvMenu.DataSource = data;
            //Ẩn cột Image trong DataGridView
            dgvMenu.Columns["Image"].Visible = false;
            if (panelHinh.Controls.Count == 0 || !(panelHinh.Controls[0] is FlowLayoutPanel))
            {
                FlowLayoutPanel flowPanel = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true,
                    FlowDirection = FlowDirection.LeftToRight,
                    WrapContents = true,
                    Padding = new Padding(5)
                };
                panelHinh.Controls.Add(flowPanel);
            }

            FlowLayoutPanel currentFlowPanel = (FlowLayoutPanel)panelHinh.Controls[0];
            currentFlowPanel.Controls.Clear();

            foreach (var item in data)
            {
                PictureBox pictureBox = new PictureBox
                {
                    //Thiết lập cấu hình cho picturebox
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
                    var ms = new MemoryStream(item.Image.ToArray());
                    pictureBox.Image = Image.FromStream(ms);
                }
                else
                {
                    // Mặc định chưa có ảnh thì cho ảnh tạm thời là nền xám
                    pictureBox.BackColor = Color.Gray;
                }

                currentFlowPanel.Controls.Add(pictureBox);
            }
            Default();
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
                                       CategoryID = menu.CategoryID,
                                       FoodID = menu.FoodID,
                                       FoodName = menu.FoodName,
                                       Price = menu.Price,
                                       Quantity = menu.Quantity,
                                   }).ToList();

                    // Hiển thị dữ liệu lên dgvMenu
                    dgvMenu.DataSource = result;
                    txtCategoryID.Text = item.CategoryID.ToString();
                    txtPrice.Text = item.Price.ToString();
                    txtFoodID.Text = item.FoodID.ToString();
                    txtFoodName.Text = item.FoodName.ToString();
                }
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pcAdd.Image = pictureBox.Image;

            }
        }


        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = e.RowIndex;
            if (idrow < 0 || idrow >= dgvMenu.Rows.Count)
                return;
            HienthiDuLieuDong(idrow);
        }

        //Hàm hiện thị dữ liệu mỗi dòng
        private void HienthiDuLieuDong(int idrow)
        {
            databaseDataContext db = new databaseDataContext();

            string name = dgvMenu.Rows[idrow].Cells[0].Value.ToString();
            Menu m = db.Menus.Where(p => p.FoodName == name).FirstOrDefault();
            if (m != null)
            {
                txtCategoryID.Text = m.CategoryID.ToString();
                txtPrice.Text = m.Price.ToString();
                txtFoodName.Text = m.FoodName;
                txtFoodID.Text = m.FoodID.ToString();
                if (m.Image != null && m.Image.Length > 0)
                {
                    byte[] imageData = m.Image.ToArray();
                    MemoryStream ms = new MemoryStream(imageData);

                    pcAdd.Image = Image.FromStream(ms);
                }
                else
                {
                    pcAdd.Image = null;
                }
            }
        }

        //Hàm hiện thị ảnh theo kết quả
        private void loadPictureBoxesTheoRes(List<Menu> menus)
        {
            if (menus == null || menus.Count == 0)
                return;
            if (panelHinh.Controls.Count == 0 || !(panelHinh.Controls[0] is FlowLayoutPanel))
            {
                FlowLayoutPanel flowPanel = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true,
                    FlowDirection = FlowDirection.LeftToRight,
                    WrapContents = true,
                    Padding = new Padding(5)
                };
                panelHinh.Controls.Add(flowPanel);
            }
            FlowLayoutPanel currentFlowPanel = (FlowLayoutPanel)panelHinh.Controls[0];
            currentFlowPanel.Controls.Clear();
            foreach (var menu in menus)
            {
                PictureBox pictureBox = new PictureBox
                {
                    Width = 200,
                    Height = 200,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.FixedSingle
                };
                if (menu.Image != null && menu.Image.Length > 0)
                {
                    var ms = new MemoryStream(menu.Image.ToArray());
                    pictureBox.Image = Image.FromStream(ms);
                }
                else
                {
                    pictureBox.BackColor = Color.Gray;
                }

                currentFlowPanel.Controls.Add(pictureBox);
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(pictureBox, menu.FoodName);
            }
            Default();
        }
        // Sử lý sự kiện nhấn nút cơm
        private void btnCom_Click(object sender, EventArgs e)
        {
            // Cơm
            LoadPictureBoxes(1);
        }
        // Sử lý sự kiện nhấn nút nước
        private void btnNuoc_Click(object sender, EventArgs e)
        {
            // Nước uống
            LoadPictureBoxes(2);
        }
        // Sử lý sự kiện nhấn nút snack
        private void btnSnack_Click(object sender, EventArgs e)
        {
            // Snack
            LoadPictureBoxes(3);
        }
        // Sử lý sự kiện nhấn nút mì
        private void btnMi_Click(object sender, EventArgs e)
        {

            // Mì
            LoadPictureBoxes(4);
        }
        // Sử lý sự kiện nhấn nút kem
        private void btnKem_Click(object sender, EventArgs e)
        {
            // Kem
            LoadPictureBoxes(5);
        }

        // Sử lý sự kiện nhấn nút tất cả
        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadPictureBoxes();
        }

        // Hàm sử lý ảnh
        private byte[] ConvertImageToByteArray(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }

        // Sử lý sự kiện nhấn nút inds
        private void btnInds_Click(object sender, EventArgs e)
        {
            btnOk.FillColor = System.Drawing.Color.Yellow;
            InMenu inMenu = new InMenu();
            inMenu.ShowDialog();
        }
        // Sử lý sự kiện nhấn nút sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            txtPrice.Enabled = true;
            txtCategoryID.Enabled = true;
            txtFoodID.Enabled = true;
            txtFoodName.Enabled = true;
            pcAdd.Enabled = true;
            btnOk.FillColor = System.Drawing.Color.LightGray;
            sua = true;
        }
        // Sử lý sự kiện nhấn nút tìm
        private void btnTim_Click(object sender, EventArgs e)
        {

            Default();
            txtPrice.Enabled = true;
            txtCategoryID.Enabled = true;
            txtFoodID.Enabled = true;
            txtFoodName.Enabled = true;
            btnOk.FillColor = System.Drawing.Color.Purple;
            tim = true;
        }
        // Sử lý sự kiện nhấn nút thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            Default();
            txtPrice.Enabled = true;
            txtFoodName.Enabled = true;
            txtCategoryID.Enabled = true;
            pcAdd.Enabled = true;
            btnOk.FillColor = System.Drawing.Color.Green;
            them = true;
        }
        // Sử lý sự kiện nhấn nút xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Default();
            txtFoodID.Enabled = true;
            btnOk.FillColor = System.Drawing.Color.Red;
            xoa = true;
        }
        // Sử lý sự kiện nhấn nút ok
        private void btnOK_Click(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            if (them == true)
            {
                int maloai;
                if (!int.TryParse(txtCategoryID.Text, out maloai))
                {
                    MessageBox.Show("Mã loại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCategoryID.Focus();
                    return;
                }

                string tenmon = txtFoodName.Text.Trim();
                if (string.IsNullOrEmpty(tenmon))
                {
                    MessageBox.Show("Tên món không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFoodName.Focus();
                    return;
                }

                decimal dongia;
                if (!decimal.TryParse(txtPrice.Text, out dongia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrice.Focus();
                    return;
                }

                // Kiểm tra mã loại tồn tại
                Category ct = db.Categories.SingleOrDefault(c => c.CategoryID == maloai);
                if (ct == null)
                {
                    MessageBox.Show("Mã loại không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCategoryID.Focus();
                    return;
                }

                // Kiểm tra và xử lý ảnh
                byte[] imageData = null;
                if (pcAdd.Image != null)
                {
                    imageData = ConvertImageToByteArray(pcAdd.Image);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ảnh trước khi thêm món ăn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thêm món mới
                int maxFoodID = db.Menus.Any() ? db.Menus.Max(m => m.FoodID) : 0;
                int newFoodID = maxFoodID + 1;

                Menu newMenu = new Menu
                {
                    FoodID = newFoodID,
                    CategoryID = maloai,
                    FoodName = tenmon,
                    Price = dongia,
                    Quantity = 0,
                    Image = imageData
                };

                db.Menus.InsertOnSubmit(newMenu);
                db.SubmitChanges();

                loadDuLieu();
                MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (xoa == true)
            {
                int mamon;
                if (!int.TryParse(txtFoodID.Text, out mamon))
                {
                    MessageBox.Show("Mã món không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFoodID.Focus();
                    return;
                }
                Menu m = db.Menus.Where(c => c.FoodID == mamon).SingleOrDefault();
                if (m == null)
                {
                    MessageBox.Show("Mã món không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFoodID.Focus();
                    return;
                }
                else
                {
                    db.Menus.DeleteOnSubmit(m);
                    db.SubmitChanges();
                    loadDuLieu();
                    MessageBox.Show("Xóa món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (tim == true)
            {
                int? maloai = string.IsNullOrWhiteSpace(txtCategoryID.Text) ? (int?)null : int.Parse(txtCategoryID.Text);
                int? mamon = string.IsNullOrWhiteSpace(txtFoodID.Text) ? (int?)null : int.Parse(txtFoodID.Text);
                string tenmon = string.IsNullOrWhiteSpace(txtFoodName.Text) ? null : txtFoodName.Text;
                decimal? dongia = string.IsNullOrWhiteSpace(txtPrice.Text) ? (decimal?)null : decimal.Parse(txtPrice.Text);
                var query = db.Menus.AsQueryable();

                if (maloai.HasValue)
                {
                    query = query.Where(m => m.CategoryID == maloai.Value);
                }
                if (mamon.HasValue)
                {
                    query = query.Where(m => m.FoodID == mamon.Value);
                }
                if (!string.IsNullOrEmpty(tenmon))
                {
                    query = query.Where(m => m.FoodName.Contains(tenmon));
                }
                if (dongia.HasValue)
                {
                    query = query.Where(m => m.Price == dongia.Value);
                }
                var results = query.ToList();
                if (results.Count > 0)
                {
                    dgvMenu.DataSource = results.Select(m => new
                    {
                        m.FoodID,
                        m.CategoryID,
                        m.FoodName,
                        m.Price,
                        m.Quantity
                    }).ToList();
                    loadPictureBoxesTheoRes(results);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (sua == true)
            {
                int mamon;
                if (!int.TryParse(txtFoodID.Text, out mamon))
                {
                    MessageBox.Show("Mã món không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFoodID.Focus();
                    return;
                }

                Menu existingMenu = db.Menus.SingleOrDefault(menu => menu.FoodID == mamon);
                if (existingMenu == null)
                {
                    MessageBox.Show("Không tìm thấy món ăn với mã món này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFoodID.Focus();
                    return;
                }

                int maloai;
                if (!int.TryParse(txtCategoryID.Text, out maloai))
                {
                    MessageBox.Show("Mã loại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCategoryID.Focus();
                    return;
                }

                decimal dongia;
                if (!decimal.TryParse(txtPrice.Text, out dongia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrice.Focus();
                    return;
                }

                string tenmon = txtFoodName.Text.Trim();
                if (string.IsNullOrEmpty(tenmon))
                {
                    MessageBox.Show("Tên món không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFoodName.Focus();
                    return;
                }

                // Cập nhật thông tin
                existingMenu.CategoryID = maloai;
                existingMenu.FoodName = tenmon;
                existingMenu.Price = dongia;

                // Cập nhật ảnh nếu có
                if (pcAdd.Image != null)
                {
                    existingMenu.Image = ConvertImageToByteArray(pcAdd.Image);
                }

                db.SubmitChanges();

                loadDuLieu();
                MessageBox.Show("Cập nhật thông tin món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Sử lý sự kiện nhấn vào thêm ảnh
        private void pcAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Chọn ảnh cho món ăn"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Hiển thị ảnh trong PictureBox
                    pcAdd.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}