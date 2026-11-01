using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan.Services
{
    public class DatPhongService
    {
        public DataTable LayDanhSachPhongTrong(DateTime ngayNhan, DateTime ngayTra, int soKhach)
        {
            string sql = @"
                SELECT p.SoPhong, k.TenKhuVuc, p.SoNguoiToiDa, p.DonGiaNgay 
                FROM Phong p
                JOIN KhuVuc k ON p.MaKhuVuc = k.MaKhuVuc
                WHERE p.SoNguoiToiDa >= @SoKhach
                AND p.SoPhong NOT IN (
                    SELECT ctd.SoPhong 
                    FROM ChiTietDatPhong ctd
                    JOIN PhieuDatPhong pd ON ctd.SoPhieuDat = pd.SoPhieuDat
                    WHERE pd.TrangThai IN (N'Đã đặt', N'Đang ở')
                    AND NOT (pd.NgayTraDuKien <= @NgayNhan OR pd.NgayNhan >= @NgayTra)
                )";

            return Db.Query(sql,
                new SqlParameter("@NgayNhan", ngayNhan.Date),
                new SqlParameter("@NgayTra", ngayTra.Date),
                new SqlParameter("@SoKhach", soKhach));
        }

        public bool TaoPhieuDatPhong(string maKhach, string hoTen, string cmnd, string quocTich, 
                                    string sdt, string soPhong, DateTime ngayNhan, DateTime ngayTra, 
                                    int soKhach, decimal tienCoc, string maNV)
        {
            using (var cn = Db.OpenConnection())
            using (var tran = cn.BeginTransaction())
            {
                try
                {
                    string sqlKhach = @"
                        IF NOT EXISTS (SELECT 1 FROM KhachHang WHERE MaKhach = @MaKhach)
                            INSERT INTO KhachHang(MaKhach, HoTen, SoCMND, QuocTich, SoDienThoai) 
                            VALUES(@MaKhach, @HoTen, @CMND, @QuocTich, @SDT);";
                    
                    using (var cmdK = new SqlCommand(sqlKhach, cn, tran))
                    {
                        cmdK.Parameters.AddWithValue("@MaKhach", maKhach);
                        cmdK.Parameters.AddWithValue("@HoTen", hoTen);
                        cmdK.Parameters.AddWithValue("@CMND", cmnd);
                        cmdK.Parameters.AddWithValue("@QuocTich", quocTich);
                        cmdK.Parameters.AddWithValue("@SDT", sdt ?? (object)DBNull.Value);
                        cmdK.ExecuteNonQuery();
                    }

                    string soPhieuDat = "PDP" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    string sqlPhieu = @"
                        INSERT INTO PhieuDatPhong(SoPhieuDat, MaKhach, MaNVLeTan, NgayLap, NgayNhan, NgayTraDuKien, TienCoc, KenhDat, TrangThai)
                        VALUES(@SoPhieuDat, @MaKhach, @MaNV, GETDATE(), @NgayNhan, @NgayTra, @TienCoc, N'Trực tiếp', N'Đã đặt');";

                    using (var cmdP = new SqlCommand(sqlPhieu, cn, tran))
                    {
                        cmdP.Parameters.AddWithValue("@SoPhieuDat", soPhieuDat);
                        cmdP.Parameters.AddWithValue("@MaKhach", maKhach);
                        cmdP.Parameters.AddWithValue("@MaNV", maNV);
                        cmdP.Parameters.AddWithValue("@NgayNhan", ngayNhan.Date);
                        cmdP.Parameters.AddWithValue("@NgayTra", ngayTra.Date);
                        cmdP.Parameters.AddWithValue("@TienCoc", tienCoc);
                        cmdP.ExecuteNonQuery();
                    }

                    string sqlCT = @"
                        INSERT INTO ChiTietDatPhong(SoPhieuDat, SoPhong, SoNguoi)
                        VALUES(@SoPhieuDat, @SoPhong, @SoNguoi);";

                    using (var cmdCT = new SqlCommand(sqlCT, cn, tran))
                    {
                        cmdCT.Parameters.AddWithValue("@SoPhieuDat", soPhieuDat);
                        cmdCT.Parameters.AddWithValue("@SoPhong", soPhong);
                        cmdCT.Parameters.AddWithValue("@SoNguoi", soKhach);
                        cmdCT.ExecuteNonQuery();
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
