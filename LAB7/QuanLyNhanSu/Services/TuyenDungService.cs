using System;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;
using QuanLyNhanSu.Models;

namespace QuanLyNhanSu.Services
{
    public class TuyenDungService
    {
        // UC1.5: Thuc hien trong 1 Transaction
        public bool TuyenDungNhanVien(NhanVien nv, QuyetDinhTuyenDung qd)
        {
            if (qd.NgayKetThucThuViec < qd.NgayBatDauThuViec)
                throw new Exception("Ngày kết thúc thử việc phải >= Ngày bắt đầu thử việc!");

            using (var cn = Db.OpenConnection())
            using (var tran = cn.BeginTransaction())
            {
                try
                {
                    // 1. Them NhanVien
                    string sqlNV = "INSERT INTO NhanVien (MaNV, HoTen, NgaySinh, GioiTinh, DienThoai, DiaChi, TrangThai, MaPB) VALUES (@Ma, @Ten, @NS, @GT, @SDT, @DC, @TT, @MaPB)";
                    using (var cmd1 = new SqlCommand(sqlNV, cn, tran))
                    {
                        cmd1.Parameters.AddWithValue("@Ma", nv.MaNV);
                        cmd1.Parameters.AddWithValue("@Ten", nv.HoTen);
                        cmd1.Parameters.AddWithValue("@NS", nv.NgaySinh);
                        cmd1.Parameters.AddWithValue("@GT", nv.GioiTinh);
                        cmd1.Parameters.AddWithValue("@SDT", (object)nv.DienThoai ?? DBNull.Value);
                        cmd1.Parameters.AddWithValue("@DC", (object)nv.DiaChi ?? DBNull.Value);
                        cmd1.Parameters.AddWithValue("@TT", "Thử việc");
                        cmd1.Parameters.AddWithValue("@MaPB", nv.MaPB);
                        cmd1.ExecuteNonQuery();
                    }

                    // 2. Them QuyetDinhTuyenDung
                    string sqlQD = "INSERT INTO QuyetDinhTuyenDung (SoQD, NgayQD, NgayBatDauThuViec, NgayKetThucThuViec, LuongThuViec, DieuKhoan, MaNV, MaPB) VALUES (@SoQD, @NgayQD, @BD, @KT, @Luong, @DK, @MaNV, @MaPB)";
                    using (var cmd2 = new SqlCommand(sqlQD, cn, tran))
                    {
                        cmd2.Parameters.AddWithValue("@SoQD", qd.SoQD);
                        cmd2.Parameters.AddWithValue("@NgayQD", qd.NgayQD);
                        cmd2.Parameters.AddWithValue("@BD", qd.NgayBatDauThuViec);
                        cmd2.Parameters.AddWithValue("@KT", qd.NgayKetThucThuViec);
                        cmd2.Parameters.AddWithValue("@Luong", qd.LuongThuViec);
                        cmd2.Parameters.AddWithValue("@DK", (object)qd.DieuKhoan ?? DBNull.Value);
                        cmd2.Parameters.AddWithValue("@MaNV", nv.MaNV);
                        cmd2.Parameters.AddWithValue("@MaPB", nv.MaPB);
                        cmd2.ExecuteNonQuery();
                    }

                    tran.Commit();
                    return true;
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }
    }
}
