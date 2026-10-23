using System;
using System.Windows.Forms;
using QuanLyBenhAn.Data;

namespace QuanLyBenhAn
{
    public partial class NhapDotKhamForm : Form
    {
        public NhapDotKhamForm()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHoSo.Text) || string.IsNullOrWhiteSpace(txtMaBacSi.Text))
            {
                MessageBox.Show("Mã hồ sơ và Mã bác sĩ không được để trống.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // BR04/BR05: hồ sơ phải hiệu lực mới cho nhập đợt khám
                var trangThai = Db.LayGiaTri(
                    "SELECT TrangThai FROM HoSoBenhAn WHERE MaHoSo=@MaHoSo",
                    Db.Tham("@MaHoSo", txtMaHoSo.Text.Trim()));

                if (trangThai == null)
                {
                    MessageBox.Show("Không tìm thấy hồ sơ (BR05).", "Không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (trangThai.ToString() != "Hieu luc")
                {
                    MessageBox.Show("Hồ sơ không ở trạng thái hiệu lực (BR04).", "Không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maDotKham = "DK" + DateTime.Now.ToString("yyMMddHHmmss");
                Db.ThucThi(
                    @"INSERT INTO DotKham(MaDotKham,MaHoSo,MaBacSi,MaPhongBan,MaNV,NgayGioKham,LoaiKham,TrieuChung,DienBienBenh,HieuQuaDieuTri,TrangThai)
                      VALUES(@MaDotKham,@MaHoSo,@MaBacSi,@MaPhongBan,@MaNV,@NgayGioKham,@LoaiKham,@TrieuChung,@DienBien,@HieuQua,N'Da ghi nhan')",
                    Db.Tham("@MaDotKham", maDotKham),
                    Db.Tham("@MaHoSo", txtMaHoSo.Text.Trim()),
                    Db.Tham("@MaBacSi", txtMaBacSi.Text.Trim()),
                    Db.Tham("@MaPhongBan", txtMaPhongBan.Text.Trim()),
                    Db.Tham("@MaNV", txtMaNV.Text.Trim()),
                    Db.Tham("@NgayGioKham", DateTime.Now),
                    Db.Tham("@LoaiKham", cboLoaiKham.Text),
                    Db.Tham("@TrieuChung", txtTrieuChung.Text.Trim()),
                    Db.Tham("@DienBien", txtDienBien.Text.Trim()),
                    Db.Tham("@HieuQua", txtHieuQua.Text.Trim()));

                MessageBox.Show("Lưu đợt khám thành công. Mã: " + maDotKham, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
