using System;
using System.Windows.Forms;
using QuanLyBenhAn.Data;

namespace QuanLyBenhAn
{
    public partial class TraCuuHoSoForm : Form
    {
        public TraCuuHoSoForm()
        {
            InitializeComponent();
        }

        private void BtnTimHoSo_Click(object sender, EventArgs e)
        {
            string kw = "%" + txtTuKhoa.Text.Trim() + "%";
            try
            {
                var dt = Db.LayBang(
                    @"SELECT hs.MaHoSo, bn.MaBN, bn.HoTen, bn.SoDienThoai, hs.NgayLap, hs.TrangThai
                      FROM HoSoBenhAn hs JOIN BenhNhan bn ON hs.MaBN = bn.MaBN
                      WHERE bn.MaBN LIKE @kw OR bn.HoTen LIKE @kw OR bn.SoDienThoai LIKE @kw",
                    Db.Tham("@kw", kw));
                gridHoSo.DataSource = dt;
                gridLichSu.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridHoSo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string maHoSo = gridHoSo.Rows[e.RowIndex].Cells["MaHoSo"].Value.ToString();
            try
            {
                var dt = Db.LayBang(
                    @"SELECT MaDotKham, NgayGioKham, LoaiKham, TrieuChung, HieuQuaDieuTri, NgayXuatVien, TrangThai
                      FROM DotKham WHERE MaHoSo = @MaHoSo ORDER BY NgayGioKham DESC",
                    Db.Tham("@MaHoSo", maHoSo));
                gridLichSu.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
