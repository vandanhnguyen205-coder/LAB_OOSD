using System;
using System.Windows.Forms;
using QuanLyNhanSu.Models;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class QLChucVuForm : Form
    {
        private readonly ChucVuService _svc = new ChucVuService();

        public QLChucVuForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvData.DataSource = _svc.LayTatCa();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var cv = new ChucVu { MaCV = txtMaCV.Text.Trim(), TenCV = txtTenCV.Text.Trim() };
            if (_svc.Them(cv)) { MessageBox.Show("Thêm thành công!"); LoadData(); }
            else MessageBox.Show("Thêm thất bại!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var cv = new ChucVu { MaCV = txtMaCV.Text.Trim(), TenCV = txtTenCV.Text.Trim() };
            if (_svc.Sua(cv)) { MessageBox.Show("Sửa thành công!"); LoadData(); }
            else MessageBox.Show("Sửa thất bại!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_svc.Xoa(txtMaCV.Text.Trim())) { MessageBox.Show("Xóa thành công!"); LoadData(); }
            else MessageBox.Show("Xóa thất bại!");
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count == 0) return;
            var r = dgvData.SelectedRows[0];
            txtMaCV.Text = r.Cells["MaCV"].Value?.ToString();
            txtTenCV.Text = r.Cells["TenCV"].Value?.ToString();
        }
    }
}
