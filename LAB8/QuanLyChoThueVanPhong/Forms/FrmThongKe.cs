using System;
using System.Windows.Forms;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            lblTongDoanhThu.Text = "TỔNG DOANH THU THÁNG: 150.000.000 VNĐ";
            lblTyLeLapDay.Text = "TỶ LỆ LẤP ĐẦY MẶT BẰNG: 85%";
        }
    }
}
