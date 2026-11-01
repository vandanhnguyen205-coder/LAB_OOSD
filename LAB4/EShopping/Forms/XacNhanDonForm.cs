using System;
using System.Windows.Forms;

namespace eShopping.Forms
{
    public partial class XacNhanDonForm : Form
    {
        public XacNhanDonForm(int maDon, bool emailSent)
        {
            InitializeComponent();
            lblMaDon.Text = "MÃ ĐƠN HÀNG: #" + maDon;
            lblStatusEmail.Text = emailSent 
                ? "✓ Đã gửi email xác nhận chi tiết đơn hàng đến tài khoản của bạn." 
                : "ℹ Không gửi email (Khách hàng chưa đăng ký email).";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
