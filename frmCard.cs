using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Do_anLaptrinhWinCK
{
    public partial class frmCard : Form
    {
        public frmCard()
        {
            InitializeComponent();
        }

        private void frmCard_Load(object sender, EventArgs e)
        {
            SetRoundedCorners(30);
        }
        private void SetRoundedCorners(int radius)
        {
            radius = Math.Min(radius, Math.Min(this.Width / 2, this.Height / 2));

            var path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);
        }
        private void btnDangky_Click(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            int Id = int.Parse(txtID.Text);
            var user = db.Users.SingleOrDefault(p => p.UserID == Id);
            if (user != null)
            {
                Card c = db.Cards.SingleOrDefault(Card => Card.UserID == Id);
                if (c == null)
                {
                    string Type = cbType.Text;
                    Card card = new Card
                    {
                        UserID = Id,
                        CardType = Type,
                        Stas = "Đang hoạt động",
                        Balance = 0
                    };
                    db.Cards.InsertOnSubmit(card);
                    db.SubmitChanges();
                    MessageBox.Show("Đăng ký thẻ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi! Người dùng này đã có thẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lỗi!Người dùng này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
