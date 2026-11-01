using System;
using System.Windows.Forms;
using eShopping.Models;
using eShopping.Services;

namespace eShopping.Forms
{
    public partial class DangKyForm : Form
    {
        private readonly TaiKhoanService _taiKhoanService;

        public DangKyForm()
        {
            InitializeComponent();
            _taiKhoanService = new TaiKhoanService();
        }

        private void btnXacNhanDangKy_Click(object sender, EventArgs e)
        {
            var kh = new KhachHang
            {
                HoTen = txtHoTen.Text,
                NgaySinh = dtpNgaySinh.Value,
                SoCMND_Passport = txtCMND.Text,
                DiaChi = txtDiaChi.Text,
                DienThoai = txtSDT.Text,
                TenDangNhap = txtUser.Text,
                MatKhau = txtPass.Text,
                Email = txtEmail.Text
            };

            var kq = _taiKhoanService.DangKy(kh);
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
