using System;
using System.Windows.Forms;

namespace QuanLyNhanSu.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            using (var f = new QLPhongBanForm()) f.ShowDialog(this);
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            using (var f = new QLChucVuForm()) f.ShowDialog(this);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            using (var f = new QLNhanVienForm()) f.ShowDialog(this);
        }

        private void btnTuyenDung_Click(object sender, EventArgs e)
        {
            using (var f = new TuyenDungForm()) f.ShowDialog(this);
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            using (var f = new TinhLuongForm()) f.ShowDialog(this);
        }
    }
}
