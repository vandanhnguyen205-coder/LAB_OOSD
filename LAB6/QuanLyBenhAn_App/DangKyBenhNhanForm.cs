using System;
using System.Windows.Forms;
using QuanLyBenhAn.Data;

namespace QuanLyBenhAn
{
    public partial class DangKyBenhNhanForm : Form
    {
        public DangKyBenhNhanForm()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBN.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Mã BN và Họ tên không được để trống.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal lePhi;
            if (!decimal.TryParse(txtLePhi.Text, out lePhi))
            {
                MessageBox.Show("Lệ phí không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // BR03: chỉ cấp hồ sơ khi đã đóng lệ phí
            if (lePhi <= 0)
            {
                MessageBox.Show("Chưa đóng lệ phí, không thể cấp hồ sơ (BR03).", "Không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime ngaySinh;
            if (!DateTime.TryParse(txtNgaySinh.Text, out ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ (yyyy-MM-dd).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var cn = Db.TaoKetNoi())
                {
                    cn.Open();
                    using (var tran = cn.BeginTransaction())
                    {
                        try
                        {
                            var cmdBN = new System.Data.SqlClient.SqlCommand(
                                "INSERT INTO BenhNhan(MaBN,HoTen,NgaySinh,GioiTinh,SoDienThoai,DiaChi) VALUES(@MaBN,@HoTen,@NgaySinh,@GioiTinh,@SDT,@DiaChi)",
                                cn, tran);
                            cmdBN.Parameters.AddWithValue("@MaBN", txtMaBN.Text.Trim());
                            cmdBN.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());
                            cmdBN.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                            cmdBN.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                            cmdBN.Parameters.AddWithValue("@SDT", txtSoDienThoai.Text.Trim());
                            cmdBN.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                            cmdBN.ExecuteNonQuery();

                            string maHoSo = "HS" + DateTime.Now.ToString("yyMMddHHmmss");
                            var cmdHS = new System.Data.SqlClient.SqlCommand(
                                "INSERT INTO HoSoBenhAn(MaHoSo,MaBN,NgayLap,TrangThai) VALUES(@MaHoSo,@MaBN,@NgayLap,N'Hieu luc')",
                                cn, tran);
                            cmdHS.Parameters.AddWithValue("@MaHoSo", maHoSo);
                            cmdHS.Parameters.AddWithValue("@MaBN", txtMaBN.Text.Trim());
                            cmdHS.Parameters.AddWithValue("@NgayLap", DateTime.Now.Date);
                            cmdHS.ExecuteNonQuery();

                            tran.Commit();
                            MessageBox.Show("Cấp hồ sơ thành công. Mã hồ sơ: " + maHoSo, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                        }
                        catch
                        {
                            tran.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
