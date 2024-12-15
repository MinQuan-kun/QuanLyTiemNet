using System;
using System.Windows.Forms;

namespace Do_anLaptrinhWinCK
{
    public partial class frmPayment : Form
    {
        public string PaymentMethod { get; private set; }

        public frmPayment()
        {
            InitializeComponent();
        }

        private void btnCk_Click(object sender, EventArgs e)
        {
            PaymentMethod = "Chuyển khoản";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTienmat_Click(object sender, EventArgs e)
        {
            PaymentMethod = "Tiền mặt";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
