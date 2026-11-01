using System;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            using (var form = new FrmDatPhong()) form.ShowDialog(this);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            using (var form = new FrmDichVu()) form.ShowDialog(this);
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            using (var form = new FrmTraPhong()) form.ShowDialog(this);
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            using (var form = new FrmDanhMuc()) form.ShowDialog(this);
        }

        private void btnLapDat_Click(object sender, EventArgs e)
        {
            using (var form = new FrmPhongTienNghi()) form.ShowDialog(this);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            using (var form = new FrmThongKe()) form.ShowDialog(this);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
