using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan.Services
{
    public class ThongKeService
    {
        public DataTable ThongKeDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            string sql = @"
                SELECT 
                    CONVERT(date, NgayLap) AS Ngay,
                    COUNT(SoHoaDon) AS SoHoaDon,
                    SUM(TienPhong) AS TongTienPhong,
                    SUM(TienDichVu) AS TongTienDV,
                    SUM(TongTien) AS TongDoanhThu
                FROM HoaDon
                WHERE TrangThai = N'Đã thanh toán'
                AND CONVERT(date, NgayLap) BETWEEN @TuNgay AND @DenNgay
                GROUP BY CONVERT(date, NgayLap)
                ORDER BY Ngay ASC";

            return Db.Query(sql, 
                new SqlParameter("@TuNgay", tuNgay.Date),
                new SqlParameter("@DenNgay", denNgay.Date));
        }

        public DataTable ThongKeTanSuatDichVu(DateTime tuNgay, DateTime denNgay)
        {
            string sql = @"
                SELECT 
                    dv.TenDV,
                    dv.DonViTinh,
                    SUM(ctdv.SoLuong) AS TongSoLuong,
                    SUM(ctdv.ThanhTien) AS TongDoanhThuDV
                FROM ChiTietPhieuSuDungDV ctdv
                JOIN PhieuSuDungDV psd ON ctdv.SoPhieuSDDV = psd.SoPhieuSDDV
                JOIN DichVu dv ON ctdv.MaDV = dv.MaDV
                WHERE psd.NgaySuDung BETWEEN @TuNgay AND @DenNgay
                GROUP BY dv.TenDV, dv.DonViTinh
                ORDER BY TongSoLuong DESC";

            return Db.Query(sql,
                new SqlParameter("@TuNgay", tuNgay.Date),
                new SqlParameter("@DenNgay", denNgay.Date));
        }
    }
}
