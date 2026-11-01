using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan.Services
{
    public class LapDatService
    {
        public DataTable LayDanhSachPhieuLapDat()
        {
            string sql = @"
                SELECT pld.SoPhieuLapDat, pld.MaTienNghi, tn.MaLoaiTN, pld.SoPhong, pld.NgayLap, pld.TinhTrang, nv.HoTen AS NhanVienLap
                FROM PhieuLapDat pld
                JOIN TienNghi tn ON pld.MaTienNghi = tn.MaTienNghi
                JOIN NhanVien nv ON pld.MaNV = nv.MaNV";
            return Db.Query(sql);
        }

        public bool LapDatThietBi(string maTienNghi, string soPhong, DateTime ngayLap, string tinhTrang, string maNV, string ghiChu)
        {
            string soPhieu = "PLD" + DateTime.Now.ToString("yyyyMMddHHmmss");
            string sql = @"
                INSERT INTO PhieuLapDat(SoPhieuLapDat, MaTienNghi, SoPhong, NgayLap, TinhTrang, MaNV, GhiChu)
                VALUES(@SoPhieu, @MaTN, @SoPhong, @NgayLap, @TinhTrang, @MaNV, @GhiChu)";
            
            int rows = Db.Execute(sql,
                new SqlParameter("@SoPhieu", soPhieu),
                new SqlParameter("@MaTN", maTienNghi),
                new SqlParameter("@SoPhong", soPhong),
                new SqlParameter("@NgayLap", ngayLap.Date),
                new SqlParameter("@TinhTrang", tinhTrang),
                new SqlParameter("@MaNV", maNV),
                new SqlParameter("@GhiChu", ghiChu ?? (object)DBNull.Value));

            return rows > 0;
        }
    }
}
