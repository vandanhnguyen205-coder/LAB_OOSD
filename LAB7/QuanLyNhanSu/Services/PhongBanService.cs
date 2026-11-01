using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;
using QuanLyNhanSu.Models;

namespace QuanLyNhanSu.Services
{
    public class PhongBanService
    {
        public DataTable LayTatCa() => Db.Query("SELECT * FROM PhongBan");

        public bool Them(PhongBan pb)
        {
            string sql = "INSERT INTO PhongBan VALUES(@Ma, @Ten, @Loai)";
            return Db.Execute(sql,
                new SqlParameter("@Ma", pb.MaPB),
                new SqlParameter("@Ten", pb.TenPB),
                new SqlParameter("@Loai", pb.LoaiDonVi)) > 0;
        }

        public bool Sua(PhongBan pb)
        {
            string sql = "UPDATE PhongBan SET TenPB=@Ten, LoaiDonVi=@Loai WHERE MaPB=@Ma";
            return Db.Execute(sql,
                new SqlParameter("@Ma", pb.MaPB),
                new SqlParameter("@Ten", pb.TenPB),
                new SqlParameter("@Loai", pb.LoaiDonVi)) > 0;
        }

        public bool Xoa(string maPB)
        {
            return Db.Execute("DELETE FROM PhongBan WHERE MaPB=@Ma", new SqlParameter("@Ma", maPB)) > 0;
        }
    }
}
