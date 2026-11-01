using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan.Services
{
    public class TraPhongService
    {
        public DataTable TinhTienHoaDon(string soPhieuDat, int soNgayTinhTien)
        {
            string sql = @"
                SELECT 
                    pd.SoPhieuDat,
                    SUM(ctp.SoNguoi * p.DonGiaNgay * @SoNgay) AS TienPhong,
                    ISNULL((
                        SELECT SUM(ctdv.ThanhTien)
                        FROM PhieuSuDungDV psd
                        JOIN ChiTietPhieuSuDungDV ctdv ON psd.SoPhieuSDDV = ctdv.SoPhieuSDDV
                        WHERE psd.SoPhieuDat = pd.SoPhieuDat
                    ), 0) AS TienDichVu
                FROM PhieuDatPhong pd
                JOIN ChiTietDatPhong ctp ON pd.SoPhieuDat = ctp.SoPhieuDat
                JOIN Phong p ON ctp.SoPhong = p.SoPhong
                WHERE pd.SoPhieuDat = @SoPhieuDat
                GROUP BY pd.SoPhieuDat";

            return Db.Query(sql, 
                new SqlParameter("@SoPhieuDat", soPhieuDat),
                new SqlParameter("@SoNgay", soNgayTinhTien));
        }

        public bool ThanhToanVaTraPhong(string soPhieuDat, int soNgay, decimal tienPhong, decimal tienDV, 
                                       string hinhThucTT, decimal soTienNop, string maNV)
        {
            using (var cn = Db.OpenConnection())
            using (var tran = cn.BeginTransaction())
            {
                try
                {
                    string soHoaDon = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    string sqlHD = @"
                        INSERT INTO HoaDon(SoHoaDon, SoPhieuDat, NgayLap, MaNV, SoNgayTinhTien, TienPhong, TienDichVu, TrangThai)
                        VALUES(@SoHD, @SoPhieuDat, GETDATE(), @MaNV, @SoNgay, @TienPhong, @TienDV, N'Đã thanh toán');";

                    using (var cmdHD = new SqlCommand(sqlHD, cn, tran))
                    {
                        cmdHD.Parameters.AddWithValue("@SoHD", soHoaDon);
                        cmdHD.Parameters.AddWithValue("@SoPhieuDat", soPhieuDat);
                        cmdHD.Parameters.AddWithValue("@MaNV", maNV);
                        cmdHD.Parameters.AddWithValue("@SoNgay", soNgay);
                        cmdHD.Parameters.AddWithValue("@TienPhong", tienPhong);
                        cmdHD.Parameters.AddWithValue("@TienDV", tienDV);
                        cmdHD.ExecuteNonQuery();
                    }

                    string maTT = "TT" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    string sqlTT = @"
                        INSERT INTO ThanhToan(MaThanhToan, SoHoaDon, NgayThanhToan, HinhThuc, SoTien)
                        VALUES(@MaTT, @SoHD, GETDATE(), @HinhThuc, @SoTien);";

                    using (var cmdTT = new SqlCommand(sqlTT, cn, tran))
                    {
                        cmdTT.Parameters.AddWithValue("@MaTT", maTT);
                        cmdTT.Parameters.AddWithValue("@SoHD", soHoaDon);
                        cmdTT.Parameters.AddWithValue("@HinhThuc", hinhThucTT);
                        cmdTT.Parameters.AddWithValue("@SoTien", soTienNop);
                        cmdTT.ExecuteNonQuery();
                    }

                    string sqlUpdate = @"
                        UPDATE PhieuDatPhong SET TrangThai = N'Đã trả', NgayTraThucTe = GETDATE() WHERE SoPhieuDat = @SoPhieuDat;
                        UPDATE Phong SET TrangThai = N'Trống' WHERE SoPhong IN (SELECT SoPhong FROM ChiTietDatPhong WHERE SoPhieuDat = @SoPhieuDat);";

                    using (var cmdUp = new SqlCommand(sqlUpdate, cn, tran))
                    {
                        cmdUp.Parameters.AddWithValue("@SoPhieuDat", soPhieuDat);
                        cmdUp.ExecuteNonQuery();
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
