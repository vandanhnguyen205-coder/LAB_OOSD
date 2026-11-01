using System;
using System.Windows.Forms;
using QuanLyNhanSu.Models;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class TuyenDungForm : Form
    {
        private readonly TuyenDungService _svc = new TuyenDungService();
        private readonly PhongBanService _pbSvc = new PhongBanService();

        public TuyenDungForm()
        {
            InitializeComponent();
            cboGioiTinh.SelectedIndex = 0;
            LoadPhongBan();
        }

        private void LoadPhongBan()
        {
            cboPhongBan.DataSource = _pbSvc.LayTatCa();
            cboPhongBan.DisplayMember = "TenPB";
            cboPhongBan.ValueMember = "MaPB";
        }

        private void btnKyDuyet_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra ràng buộc UC1.2: Ngày kết thúc >= Ngày bắt đầu
                if (dtpKetThuc.Value < dtpBatDau.Value)
                {
                    MessageBox.Show("Ràng buộc lỗi: Ngày kết thúc thử việc phải lớn hơn hoặc bằng Ngày bắt đầu!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var nv = new NhanVien
                {
                    MaNV = txtMaNV.Text.Trim(),
                    HoTen = txtHoTen.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value,
                    GioiTinh = cboGioiTinh.SelectedItem.ToString(),
                    DienThoai = txtSDT.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    MaPB = cboPhongBan.SelectedValue?.ToString()
                };

                var qd = new QuyetDinhTuyenDung
                {
                    SoQD = txtSoQD.Text.Trim(),
                    NgayQD = dtpNgayQD.Value,
                    NgayBatDauThuViec = dtpBatDau.Value,
                    NgayKetThucThuViec = dtpKetThuc.Value,
                    LuongThuViec = numLuongThuViec.Value,
                    DieuKhoan = txtDieuKhoan.Text.Trim(),
                    MaNV = nv.MaNV,
                    MaPB = nv.MaPB
                };

                // Gọi Service lưu đồng thời Nhân viên + Quyết định trong 1 Transaction
                if (_svc.TuyenDungNhanVien(nv, qd))
                {
                    MessageBox.Show("Ký duyệt và lập Quyết định tuyển dụng thành công! (Transaction đã Commit)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao tác thất bại! Đã Rollback Transaction. Chi tiết lỗi: " + ex.Message, "Lỗi Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
