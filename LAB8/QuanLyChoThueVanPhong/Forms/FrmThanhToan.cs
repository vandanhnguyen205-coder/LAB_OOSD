using System;
using System.Windows.Forms;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmThanhToan : Form
    {
        public FrmThanhToan()
        {
            InitializeComponent();
            cboHinhThuc.SelectedIndex = 0;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ghi nhận thanh toán hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
