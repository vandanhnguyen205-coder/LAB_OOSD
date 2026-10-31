using System;
using System.Windows.Forms;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            FrmDanhMuc frm = new FrmDanhMuc();
            frm.ShowDialog();
        }

        private void btnQuanLyPhong_Click(object sender, EventArgs e)
        {
            FrmDanhMuc frm = new FrmDanhMuc();
            frm.ShowDialog();
        }

        private void btnHopDongThue_Click(object sender, EventArgs e)
        {
            FrmHopDongThue frm = new FrmHopDongThue();
            frm.ShowDialog();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            FrmDichVu frm = new FrmDichVu();
            frm.ShowDialog();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            FrmThanhToan frm = new FrmThanhToan();
            frm.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FrmThongKe frm = new FrmThongKe();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát hệ thống?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
