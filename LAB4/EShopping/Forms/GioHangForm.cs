using System;
using System.Windows.Forms;
using eShopping.Services;

namespace eShopping.Forms
{
    public partial class GioHangForm : Form
    {
        private readonly GioHangService _gioHangService;

        public GioHangForm()
        {
            InitializeComponent();
            _gioHangService = new GioHangService();
            LoadGioHang();
        }

        private void LoadGioHang()
        {
            var gioHang = _gioHangService.LayGioHangHienTai();
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = gioHang.DanhSachMuc;
            lblTamTinh.Text = "Tạm tính: " + gioHang.TinhTamTinh().ToString("N0") + " VNĐ";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.SelectedRows.Count == 0) return;
            string maSP = dgvGioHang.SelectedRows[0].Cells["MaSP"].Value.ToString();
            _gioHangService.XoaMuc(maSP);
            LoadGioHang();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            var gioHang = _gioHangService.LayGioHangHienTai();
            if (gioHang.DanhSachMuc.Count == 0)
            {
                MessageBox.Show("Giỏ hàng của bạn đang trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bắt buộc Đăng nhập / Đăng ký nếu chưa đăng nhập
            if (TaiKhoanService.KhachHangDaDangNhap == null)
            {
                MessageBox.Show("Bạn cần đăng nhập hoặc đăng ký tài khoản trước khi đặt hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (var form = new DangNhapForm())
                {
                    if (form.ShowDialog(this) != DialogResult.OK) return;
                }
            }

            // Chuyển sang DatHangForm
            using (var form = new DatHangForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
