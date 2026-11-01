using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan.Services
{
    public class DichVuService
    {
        public DataTable LayDanhSachPhongDangO()
        {
            string sql = @"
                SELECT pd.SoPhieuDat, ct.SoPhong, kh.HoTen 
                FROM PhieuDatPhong pd
                JOIN ChiTietDatPhong ct ON pd.SoPhieuDat = ct.SoPhieuDat
                JOIN KhachHang kh ON pd.MaKhach = kh.MaKhach
                WHERE pd.TrangThai = N'Đang ở'";
            return Db.Query(sql);
        }

        public bool GhiNhanSuDungDichVu(string soPhieuDat, string soPhong, string maDV, int soLuong, string maNV)
        {
            DateTime ngayHienTai = DateTime.Now.Date;
            
            using (var cn = Db.OpenConnection())
            using (var tran = cn.BeginTransaction())
            {
                try
                {
                    string soPhieuSDDV = (string)new SqlCommand(
                        "SELECT SoPhieuSDDV FROM PhieuSuDungDV WHERE SoPhieuDat=@PDP AND SoPhong=@Phong AND NgaySuDung=@Ngay", 
                        cn, tran)
                        {
                            Parameters = {
                                new SqlParameter("@PDP", soPhieuDat),
                                new SqlParameter("@Phong", soPhong),
                                new SqlParameter("@Ngay", ngayHienTai)
                            }
                        }.ExecuteScalar();

                    if (string.IsNullOrEmpty(soPhieuSDDV))
                    {
                        soPhieuSDDV = "SDDV" + DateTime.Now.ToString("yyyyMMddHHmmss");
                        string sqlInsertPhieu = @"
                            INSERT INTO PhieuSuDungDV(SoPhieuSDDV, SoPhieuDat, SoPhong, NgaySuDung, MaNV)
                            VALUES(@SoPhieuSDDV, @PDP, @Phong, @Ngay, @MaNV)";
                        
                        using (var cmdP = new SqlCommand(sqlInsertPhieu, cn, tran))
                        {
                            cmdP.Parameters.AddWithValue("@SoPhieuSDDV", soPhieuSDDV);
                            cmdP.Parameters.AddWithValue("@PDP", soPhieuDat);
                            cmdP.Parameters.AddWithValue("@Phong", soPhong);
                            cmdP.Parameters.AddWithValue("@Ngay", ngayHienTai);
                            cmdP.Parameters.AddWithValue("@MaNV", maNV);
                            cmdP.ExecuteNonQuery();
                        }
                    }

                    decimal donGia = (decimal)new SqlCommand(
                        "SELECT DonGia FROM DichVu WHERE MaDV=@MaDV", cn, tran)
                        { Parameters = { new SqlParameter("@MaDV", maDV) } }.ExecuteScalar();

                    string sqlUpsertCT = @"
                        IF EXISTS (SELECT 1 FROM ChiTietPhieuSuDungDV WHERE SoPhieuSDDV=@SoPhieuSDDV AND MaDV=@MaDV)
                            UPDATE ChiTietPhieuSuDungDV 
                            SET SoLuong = SoLuong + @SoLuong 
                            WHERE SoPhieuSDDV=@SoPhieuSDDV AND MaDV=@MaDV
                        ELSE
                            INSERT INTO ChiTietPhieuSuDungDV(SoPhieuSDDV, MaDV, SoLuong, DonGia)
                            VALUES(@SoPhieuSDDV, @MaDV, @SoLuong, @DonGia)";

                    using (var cmdCT = new SqlCommand(sqlUpsertCT, cn, tran))
                    {
                        cmdCT.Parameters.AddWithValue("@SoPhieuSDDV", soPhieuSDDV);
                        cmdCT.Parameters.AddWithValue("@MaDV", maDV);
                        cmdCT.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmdCT.Parameters.AddWithValue("@DonGia", donGia);
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
