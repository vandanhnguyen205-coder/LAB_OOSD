using System;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmPhongTienNghi : Form
    {
        private readonly LapDatService _lapDatService;

        public FrmPhongTienNghi()
        {
            InitializeComponent();
            _lapDatService = new LapDatService();
            LoadData();
        }

        private void LoadData()
        {
            dgvLapDat.DataSource = _lapDatService.LayDanhSachPhieuLapDat();
        }

        private void btnLuuLapDat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTienNghi.Text) || string.IsNullOrWhiteSpace(txtSoPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã tiện nghi và Số phòng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool thanhCong = _lapDatService.LapDatThietBi(
                    txtMaTienNghi.Text.Trim(),
                    txtSoPhong.Text.Trim(),
                    dtpNgayLap.Value,
                    txtTinhTrang.Text.Trim(),
                    "NV02",
                    txtGhiChu.Text.Trim()
                );

                if (thanhCong)
                {
                    MessageBox.Show("Lập phiếu lắp đặt thiết bị thành công (Thỏa BR04: 1 thiết bị / phòng / ngày)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lập phiếu lắp đặt: " + ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
