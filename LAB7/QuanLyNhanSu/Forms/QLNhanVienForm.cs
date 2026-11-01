using System;
using System.Windows.Forms;
using QuanLyNhanSu.Models;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class QLNhanVienForm : Form
    {
        private readonly NhanVienService _svc = new NhanVienService();
        private readonly PhongBanService _pbSvc = new PhongBanService();

        public QLNhanVienForm()
        {
            InitializeComponent();
            cboGioiTinh.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            LoadPhongBan();
            LoadData();
        }

        private void LoadPhongBan()
        {
            cboPhongBan.DataSource = _pbSvc.LayTatCa();
            cboPhongBan.DisplayMember = "TenPB";
            cboPhongBan.ValueMember = "MaPB";
        }

        private void LoadData()
        {
            dgvData.DataSource = _svc.LayTatCa();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var nv = new NhanVien
            {
                MaNV = txtMaNV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = cboGioiTinh.SelectedItem.ToString(),
                DienThoai = txtSDT.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                TrangThai = cboTrangThai.SelectedItem.ToString(),
                MaPB = cboPhongBan.SelectedValue?.ToString()
            };
            if (_svc.Them(nv)) { MessageBox.Show("Thêm thành công!"); LoadData(); }
            else MessageBox.Show("Thêm thất bại!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var nv = new NhanVien
            {
                MaNV = txtMaNV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = cboGioiTinh.SelectedItem.ToString(),
                DienThoai = txtSDT.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                TrangThai = cboTrangThai.SelectedItem.ToString(),
                MaPB = cboPhongBan.SelectedValue?.ToString()
            };
            if (_svc.Sua(nv)) { MessageBox.Show("Cập nhật thành công!"); LoadData(); }
            else MessageBox.Show("Cập nhật thất bại!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_svc.Xoa(txtMaNV.Text.Trim())) { MessageBox.Show("Xóa thành công!"); LoadData(); }
            else MessageBox.Show("Xóa thất bại!");
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0) return;
            var r = dgvData.SelectedRows[0];
            txtMaNV.Text = r.Cells["MaNV"].Value?.ToString();
            txtHoTen.Text = r.Cells["HoTen"].Value?.ToString();
            if (r.Cells["NgaySinh"].Value != DBNull.Value && r.Cells["NgaySinh"].Value != null)
                dtpNgaySinh.Value = Convert.ToDateTime(r.Cells["NgaySinh"].Value);
            cboGioiTinh.SelectedItem = r.Cells["GioiTinh"].Value?.ToString() ?? "Nam";
            txtSDT.Text = r.Cells["DienThoai"].Value?.ToString();
            txtDiaChi.Text = r.Cells["DiaChi"].Value?.ToString();
            cboTrangThai.SelectedItem = r.Cells["TrangThai"].Value?.ToString() ?? "Chính thức";
            if (r.Cells["MaPB"].Value != DBNull.Value && r.Cells["MaPB"].Value != null)
                cboPhongBan.SelectedValue = r.Cells["MaPB"].Value.ToString();
        }
    }
}
