using System;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmThongKe : Form
    {
        private readonly ThongKeService _thongKeService;

        public FrmThongKe()
        {
            InitializeComponent();
            _thongKeService = new ThongKeService();
            dtpTuNgay.Value = DateTime.Now.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Now;
        }

        private void btnXemThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDoanhThu.DataSource = _thongKeService.ThongKeDoanhThu(dtpTuNgay.Value, dtpDenNgay.Value);
                dgvTanSuatDV.DataSource = _thongKeService.ThongKeTanSuatDichVu(dtpTuNgay.Value, dtpDenNgay.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy báo cáo thống kê: " + ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
