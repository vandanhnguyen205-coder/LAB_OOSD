using System;
using System.Windows.Forms;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmDichVu : Form
    {
        public FrmDichVu()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu ghi nhận chỉ số dịch vụ điện nước thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
