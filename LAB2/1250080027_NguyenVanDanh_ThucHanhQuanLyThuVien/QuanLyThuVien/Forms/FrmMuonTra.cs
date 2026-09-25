using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyThuVien.Services; // Gọi thư mục Services

namespace QuanLyThuVien.Forms
{
    public partial class FrmMuonTra : Form
    {
        // Khởi tạo đối tượng Service để gọi các xử lý nghiệp vụ
        private ThuVienService service = new ThuVienService();
        private DataTable selectedBooks = new DataTable();

        public FrmMuonTra()
        {
            InitializeComponent();
        }

        // Sự kiện Click nút "Lập Phiếu Mượn" sinh ra từ bước Double-click
        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            // 1. Lấy danh sách mã các đầu sách người dùng chọn mượn
            List<string> ds = new List<string>();
            if (selectedBooks != null)
            {
                foreach (DataRow r in selectedBooks.Rows)
                {
                    if (r.RowState != DataRowState.Deleted)
                        ds.Add(Convert.ToString(r["MaDauSach"]));
                }
            }

            // 2. Lấy giá trị từ các ô nhập trên giao diện Form
            string maDocGiaMuon = txtMaDocGia.Text;
            string maNhanVienMuon = txtMaNhanVien.Text;

            // 3. Gọi hàm LapPhieuMuon từ tầng Service đã viết ở Bước 6
            KetQuaXuLy kq = service.LapPhieuMuon(
                maDocGiaMuon,
                maNhanVienMuon,
                ds,
                dtNgayMuon.Value,
                dtHenTra.Value
            );

            // 4. Hiển thị hộp thông báo kết quả cho người dùng
            MessageBox.Show(
                kq.ThongBao,
                kq.ThanhCong ? "Thông báo" : "Lỗi",
                MessageBoxButtons.OK,
                kq.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning
            );

            // 5. Nếu lập phiếu thành công thì dọn dẹp form
            if (kq.ThanhCong)
            {
                selectedBooks.Rows.Clear();
                txtMaDocGia.Clear();
                lblTrangThai.Text = "Lập phiếu thành công!";
            }
        }

        private void FrmMuonTra_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}