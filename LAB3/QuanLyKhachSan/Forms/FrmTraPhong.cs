using System;
using System.Data;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmTraPhong : Form
    {
        private readonly TraPhongService _traPhongService;

        public FrmTraPhong()
        {
            InitializeComponent();
            _traPhongService = new TraPhongService();
            cboHinhThuc.SelectedIndex = 0;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoPhieuDat.Text))
            {
                MessageBox.Show("Vui lòng nhập Số phiếu đặt!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = _traPhongService.TinhTienHoaDon(txtSoPhieuDat.Text.Trim(), (int)nudSoNgay.Value);
                if (dt.Rows.Count > 0)
                {
                    decimal tienPhong = Convert.ToDecimal(dt.Rows[0]["TienPhong"]);
                    decimal tienDV = Convert.ToDecimal(dt.Rows[0]["TienDichVu"]);
                    decimal tongTien = tienPhong + tienDV;

                    txtTienPhong.Text = tienPhong.ToString("N0");
                    txtTienDV.Text = tienDV.ToString("N0");
                    txtTongTien.Text = tongTien.ToString("N0");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu đặt phòng hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính tiền: " + ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTongTien.Text))
            {
                MessageBox.Show("Vui lòng bấm 'Tính Tiền' trước khi thanh toán!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tienPhong = decimal.Parse(txtTienPhong.Text);
            decimal tienDV = decimal.Parse(txtTienDV.Text);
            decimal tongTien = decimal.Parse(txtTongTien.Text);

            try
            {
                bool thanhCong = _traPhongService.ThanhToanVaTraPhong(
                    txtSoPhieuDat.Text.Trim(),
                    (int)nudSoNgay.Value,
                    tienPhong,
                    tienDV,
                    cboHinhThuc.SelectedItem.ToString(),
                    tongTien,
                    "NV03"
                );

                if (thanhCong)
                {
                    MessageBox.Show("Thanh toán thành công & Đã trả phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thanh toán: " + ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
