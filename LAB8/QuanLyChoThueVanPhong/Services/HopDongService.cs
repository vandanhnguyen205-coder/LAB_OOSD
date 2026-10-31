using System;
using System.Data.SqlClient;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class HopDongService
    {
        public bool LapHopDongTransaction(string soHD, string maKhach, string maPhong, DateTime ngayBD, int thoiGianThue, decimal donGia, decimal dienTich, string maNV)
        {
            if (thoiGianThue < 6) return false;

            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    decimal tongTienPhong = dienTich * donGia * thoiGianThue;

                    string queryHD = "INSERT INTO HopDongThue (SoHopDong, NgayLap, NgayBatDau, ThoiGianThue, TongTienPhong, TrangThai, MaKhach, MaNV) " +
                                     "VALUES (@SoHD, GETDATE(), @NgayBD, @ThoiGian, @TongTien, N'Hiệu lực', @MaKhach, @MaNV)";
                    SqlCommand cmdHD = new SqlCommand(queryHD, conn, transaction);
                    cmdHD.Parameters.AddWithValue("@SoHD", soHD);
                    cmdHD.Parameters.AddWithValue("@NgayBD", ngayBD);
                    cmdHD.Parameters.AddWithValue("@ThoiGian", thoiGianThue);
                    cmdHD.Parameters.AddWithValue("@TongTien", tongTienPhong);
                    cmdHD.Parameters.AddWithValue("@MaKhach", maKhach);
                    cmdHD.Parameters.AddWithValue("@MaNV", maNV);
                    cmdHD.ExecuteNonQuery();

                    string queryCT = "INSERT INTO ChiTietHopDong (SoHopDong, MaPhong, DienTich, DonGiaThue) VALUES (@SoHD, @MaPhong, @DienTich, @DonGia)";
                    SqlCommand cmdCT = new SqlCommand(queryCT, conn, transaction);
                    cmdCT.Parameters.AddWithValue("@SoHD", soHD);
                    cmdCT.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmdCT.Parameters.AddWithValue("@DienTich", dienTich);
                    cmdCT.Parameters.AddWithValue("@DonGia", donGia);
                    cmdCT.ExecuteNonQuery();

                    string queryPhong = "UPDATE Phong SET TrangThai = N'Đã thuê' WHERE MaPhong = @MaPhong";
                    SqlCommand cmdPhong = new SqlCommand(queryPhong, conn, transaction);
                    cmdPhong.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmdPhong.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }
    }
}
