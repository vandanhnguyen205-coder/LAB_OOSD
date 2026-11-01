using System;
using System.Windows.Forms;
using eShopping.Services;

namespace eShopping.Forms
{
    public partial class DangNhapForm : Form
    {
        private readonly TaiKhoanService _taiKhoanService;

        public DangNhapForm()
        {
            InitializeComponent();
            _taiKhoanService = new TaiKhoanService();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var kq = _taiKhoanService.DangNhap(txtUsername.Text, txtPassword.Text);
            if (kq.ThanhCong)
            {
                MessageBox.Show(kq.ThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(kq.ThongBao, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDangKyForm_Click(object sender, EventArgs e)
        {
            using (var form = new DangKyForm())
            {
                form.ShowDialog(this);
            }
        }
    }
}
