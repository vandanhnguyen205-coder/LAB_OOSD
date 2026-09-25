using System;
using System.Windows.Forms;
using QuanLyKhachSan.Data;   // Gọi lớp kết nối
using QuanLyKhachSan.Forms;   // Gọi các Form con

namespace QuanLyKhachSan.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            KiemTraKetNoi();
        }

        // === Kiểm tra kết nối CSDL ===
        private void KiemTraKetNoi()
        {
            try
            {
                using (var conn = Db.MoKetNoi())
                {
                    lblTrangThai.Text = $"✅ Kết nối CSDL thành công | {conn.DataSource}";
                    lblTrangThai.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = $"❌ Kết nối thất bại: {ex.Message}";
                lblTrangThai.ForeColor = System.Drawing.Color.Red;
            }
        }

        // === 1. Danh Mục ===
        private void btnDanhMuc_Click(object s, EventArgs e)
        {
            using (var f = new FrmDanhMuc())
                f.ShowDialog(this);
        }

        // === 2. Phòng - Tiện Nghỉ ===
        private void btnPhong_Click_1(object sender, EventArgs e)
        {
            using (var f = new FrmPhongTienNghi())
                f.ShowDialog(this);
        }

        // === 3. Đặt - Nhận Phòng ===
        private void btnDatPhong_Click_1(object sender, EventArgs e)
        {
            using (var f = new FrmDatPhong())
                f.ShowDialog(this);
        }

        // === 4. Sử dụng Dịch Vụ ===
        private void btnSuDungDichVu_Click(object sender, EventArgs e)
        {
            using (var f = new FrmSuDungDichVu())
                f.ShowDialog(this);
        }

        // === 5. Trả Phòng - Thanh Toán ===
        private void btnTraPhong_Click_1(object sender, EventArgs e)
        {
            using (var f = new FrmTraPhong())
                f.ShowDialog(this);
        }

        // === 6. Thống Kê ===
        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            using (var f = new FrmThongKe())
                f.ShowDialog(this);
        }

        // === Nút Thoát ===
        private void btnThoat_Click(object s, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }
    }
}