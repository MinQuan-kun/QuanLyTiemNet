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
                    lblerror.Visible = false;
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
                    lblsucces.Visible = true;
                }
                else
                {
                    lblerror.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Lỗi!Người dùng này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
