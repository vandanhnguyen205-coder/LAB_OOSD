using System;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDatPhong : Form
    {
        private readonly DatPhongService _datPhongService;

        public FrmDatPhong()
        {
            InitializeComponent();
            _datPhongService = new DatPhongService();
        }

        private void btnTimPhong_Click(object sender, EventArgs e)
        {
            if (dtpNgayTra.Value.Date <= dtpNgayNhan.Value.Date)
            {
                MessageBox.Show("Ngày trả dự kiến phải lớn hơn ngày nhận phòng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dt = _datPhongService.LayDanhSachPhongTrong(dtpNgayNhan.Value, dtpNgayTra.Value, (int)nudSoKhach.Value);
            dgvPhongTrong.DataSource = dt;
        }

        private void btnLuuDatPhong_Click(object sender, EventArgs e)
        {
            if (dgvPhongTrong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 phòng trống từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaKhach.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtCMND.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ Mã khách, Họ tên và CCCD/CMND!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string soPhong = dgvPhongTrong.SelectedRows[0].Cells["SoPhong"].Value.ToString();
            decimal.TryParse(txtCoc.Text, out decimal tienCoc);

            try
            {
                bool thanhCong = _datPhongService.TaoPhieuDatPhong(
                    txtMaKhach.Text.Trim(),
                    txtHoTen.Text.Trim(),
                    txtCMND.Text.Trim(),
                    txtQuocTich.Text.Trim(),
                    null,
                    soPhong,
                    dtpNgayNhan.Value,
                    dtpNgayTra.Value,
                    (int)nudSoKhach.Value,
                    tienCoc,
                    "NV01"
                );

                if (thanhCong)
                {
                    MessageBox.Show("Tạo phiếu đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lập phiếu đặt: " + ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
