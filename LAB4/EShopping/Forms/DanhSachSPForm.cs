using System;
using System.Data;
using System.Windows.Forms;
using eShopping.Services;

namespace eShopping.Forms
{
    public partial class DanhSachSPForm : Form
    {
        private readonly IProductSystemAdapter _productAdapter;
        private readonly GioHangService _gioHangService;

        public DanhSachSPForm()
        {
            InitializeComponent();
            _productAdapter = new ProductSystemAdapter();
            _gioHangService = new GioHangService();
            LoadNhomSP();
        }

        private void LoadNhomSP()
        {
            var dt = _productAdapter.LayDanhSachNhom();
            cboNhom.Items.Clear();
            cboNhom.Items.Add(new NhomComboItem { MaNhom = "", TenNhom = "-- Tất cả nhóm --" });
            foreach (DataRow dr in dt.Rows)
            {
                cboNhom.Items.Add(new NhomComboItem
                {
                    MaNhom = dr["MaNhom"].ToString(),
                    TenNhom = dr["TenNhom"].ToString()
                });
            }
            cboNhom.SelectedIndex = 0;
        }

        private void cboNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (NhomComboItem)cboNhom.SelectedItem;
            dgvSanPham.DataSource = _productAdapter.LayDanhSachSanPham(selected.MaNhom);
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count == 0) return;
            string maSP = dgvSanPham.SelectedRows[0].Cells["MaSP"].Value.ToString();
            using (var form = new ChiTietSPForm(maSP)) form.ShowDialog(this);
        }

        private void btnThemGio_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSP = dgvSanPham.SelectedRows[0].Cells["MaSP"].Value.ToString();
            int soLuong = (int)nudSoLuong.Value;

            var kq = _gioHangService.ThemSanPham(maSP, soLuong);
            if (kq.ThanhCong)
            {
                MessageBox.Show(kq.ThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(kq.ThongBao, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private class NhomComboItem
        {
            public string MaNhom { get; set; }
            public string TenNhom { get; set; }
            public override string ToString() => TenNhom;
        }
    }
}
