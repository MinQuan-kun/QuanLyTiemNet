using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
