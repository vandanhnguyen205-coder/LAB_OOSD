using System;
using System.Windows.Forms;
using QuanLyNhanSu.Models;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class QLPhongBanForm : Form
    {
        private readonly PhongBanService _svc = new PhongBanService();

        public QLPhongBanForm()
        {
            InitializeComponent();
            cboLoai.SelectedIndex = 0;
            LoadData();
        }

        private void LoadData()
        {
            dgvData.DataSource = _svc.LayTatCa();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var pb = new PhongBan { MaPB = txtMaPB.Text.Trim(), TenPB = txtTenPB.Text.Trim(), LoaiDonVi = cboLoai.SelectedItem.ToString() };
            if (_svc.Them(pb)) { MessageBox.Show("Thêm thành công!"); LoadData(); }
            else MessageBox.Show("Thêm thất bại!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var pb = new PhongBan { MaPB = txtMaPB.Text.Trim(), TenPB = txtTenPB.Text.Trim(), LoaiDonVi = cboLoai.SelectedItem.ToString() };
            if (_svc.Sua(pb)) { MessageBox.Show("Sửa thành công!"); LoadData(); }
            else MessageBox.Show("Sửa thất bại!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_svc.Xoa(txtMaPB.Text.Trim())) { MessageBox.Show("Xóa thành công!"); LoadData(); }
            else MessageBox.Show("Xóa thất bại!");
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0) return;
            var r = dgvData.SelectedRows[0];
            txtMaPB.Text = r.Cells["MaPB"].Value?.ToString();
            txtTenPB.Text = r.Cells["TenPB"].Value?.ToString();
            cboLoai.SelectedItem = r.Cells["LoaiDonVi"].Value?.ToString() ?? "Phòng";
        }
    }
}
