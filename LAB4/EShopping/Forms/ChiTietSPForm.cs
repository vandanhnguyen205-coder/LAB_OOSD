using System;
using System.Windows.Forms;
using eShopping.Services;

namespace eShopping.Forms
{
    public partial class ChiTietSPForm : Form
    {
        private readonly string _maSP;
        private readonly IProductSystemAdapter _productAdapter;
        private readonly GioHangService _gioHangService;

        public ChiTietSPForm(string maSP)
        {
            InitializeComponent();
            _maSP = maSP;
            _productAdapter = new ProductSystemAdapter();
            _gioHangService = new GioHangService();
            LoadChiTiet();
        }

        private void LoadChiTiet()
        {
            var sp = _productAdapter.GetSanPham(_maSP);
            if (sp != null)
            {
                lblMaSP.Text = "Mã SP: " + sp.MaSP;
                lblTenSP.Text = sp.TenSP;
                lblNSX.Text = "Nhà sản xuất: " + sp.NhaSanXuat;
                lblGia.Text = "Giá bán: " + sp.GiaBan.ToString("N0") + " VNĐ";
                lblTrangThai.Text = "Tình trạng: " + (sp.TinhTrang ? "Còn hàng" : "Hết hàng");
            }
        }

        private void btnThemGio_Click(object sender, EventArgs e)
        {
            var kq = _gioHangService.ThemSanPham(_maSP, (int)nudSoLuong.Value);
            if (kq.ThanhCong)
            {
                MessageBox.Show(kq.ThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(kq.ThongBao, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
