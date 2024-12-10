using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_anLaptrinhWinCK.All_Cards
{
    public partial class Cards : UserControl
    {
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
                dgvCards.DataSource = db.Users
                    .OrderBy(m => m.UserID)
                    .Select(m => new
                    {
                        m.UserID,
                        m.CardID,
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
                var user = db.Users.SingleOrDefault(p => p.UserID == userID);

                if (user != null)
                {
                    txtUserID.Text = user.UserID.ToString();
                }
            }
        }

        private void btnDk_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void btnInds_Click(object sender, EventArgs e)
        {

        }

        private void btnBlock_Click(object sender, EventArgs e)
        {

        }
    }
}
