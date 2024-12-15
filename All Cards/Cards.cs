using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Do_anLaptrinhWinCK.All_Cards
{
    public partial class Cards : UserControl
    {
        public static double dBalance { get; set; } = 0;
        public Cards()
        {
            InitializeComponent();
        }
        private void frmCard_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        private void loadDuLieu()
        {
            using (databaseDataContext db = new databaseDataContext())
            {
                dgvCards.DataSource = db.Cards
                    .OrderBy(m => m.UserID)
                    .Select(m => new
                    {
                        m.UserID,
                        m.CardID,
                        m.CardType,
                        m.Balance,
                        m.Stas
                    }).ToList();
            }
        }
        private void dgvCards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idrow = e.RowIndex;
            if (idrow < 0 || idrow >= dgvCards.Rows.Count - (dgvCards.AllowUserToAddRows ? 1 : 0))
                return;

            HienthiDuLieuDong(idrow);
        }
        private void HienthiDuLieuDong(int idrow)
        {
            using (databaseDataContext db = new databaseDataContext())
            {
                int userID = int.Parse(dgvCards.Rows[idrow].Cells[0].Value.ToString());
                var card = db.Cards.SingleOrDefault(p => p.UserID == userID);

                if (card != null)
                {
                    txtUserID.Text = card.UserID.ToString();
                    txtBalance.Text = card.Balance.ToString();
                    cbType.Text = card.CardType.ToString();
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int? ID = string.IsNullOrWhiteSpace(txtUserID.Text) ? (int?)null : int.Parse(txtUserID.Text);
            decimal? sodu = string.IsNullOrWhiteSpace(txtBalance.Text) ? (decimal?)null : decimal.Parse(txtBalance.Text);
            string Type = string.IsNullOrWhiteSpace(cbType.Text) ? null : cbType.Text;
            databaseDataContext db = new databaseDataContext();
            var query = db.Cards.AsQueryable();

            if (ID.HasValue)
            {
                query = query.Where(m => m.UserID == ID.Value);
            }
            if (sodu.HasValue)
            {
                query = query.Where(m => m.Balance == sodu.Value);
            }
            if (!string.IsNullOrEmpty(Type))
            {
                query = query.Where(m => m.CardType.Contains(Type));
            }
            var results = query.ToList();
            if (results.Count > 0)
            {
                dgvCards.DataSource = results.Select(m => new
                {
                    m.UserID,
                    m.CardID,
                    m.CardType,
                    m.Balance,
                    m.Stas
                }).ToList();
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInds_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            int ID = int.Parse(txtUserID.Text);
            Card the = db.Cards.SingleOrDefault(c => c.UserID == ID);
            if (the != null)
            {
                the.Stas = "Đã khóa";
                db.SubmitChanges();
                loadDuLieu();
                MessageBox.Show("Khóa thẻ thành công!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnMothe_Click(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            int ID = int.Parse(txtUserID.Text);
            Card the = db.Cards.SingleOrDefault(c => c.UserID == ID);
            if (the != null)
            {
                the.Stas = "Đang hoạt động";
                db.SubmitChanges();
                loadDuLieu();
                MessageBox.Show("Mở thẻ thành công!", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
