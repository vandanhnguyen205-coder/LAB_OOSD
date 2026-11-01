using System;
using System.Windows.Forms;
using eShopping.Services;

namespace eShopping.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CapNhatTrangThaiUser();
        }

        public void CapNhatTrangThaiUser()
        {
            if (TaiKhoanService.KhachHangDaDangNhap != null)
            {
                lblUser.Text = "Xin chào: " + TaiKhoanService.KhachHangDaDangNhap.HoTen;
                btnDangNhap.Visible = false;
                btnDangKy.Visible = false;
                btnDangXuat.Visible = true;
            }
            else
            {
                lblUser.Text = "Chưa đăng nhập";
                btnDangNhap.Visible = true;
                btnDangKy.Visible = true;
                btnDangXuat.Visible = false;
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            using (var form = new DanhSachSPForm()) form.ShowDialog(this);
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            using (var form = new GioHangForm()) form.ShowDialog(this);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            using (var form = new DangNhapForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK) CapNhatTrangThaiUser();
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            using (var form = new DangKyForm()) form.ShowDialog(this);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            TaiKhoanService.KhachHangDaDangNhap = null;
            CapNhatTrangThaiUser();
            MessageBox.Show("Đã đăng xuất tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
