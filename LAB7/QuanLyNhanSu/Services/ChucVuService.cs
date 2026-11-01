using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;
using QuanLyNhanSu.Models;

namespace QuanLyNhanSu.Services
{
    public class ChucVuService
    {
        public DataTable LayTatCa() => Db.Query("SELECT * FROM ChucVu");

        public bool Them(ChucVu cv)
        {
            string sql = "INSERT INTO ChucVu VALUES(@Ma, @Ten)";
            return Db.Execute(sql,
                new SqlParameter("@Ma", cv.MaCV),
                new SqlParameter("@Ten", cv.TenCV)) > 0;
        }

        public bool Sua(ChucVu cv)
        {
            string sql = "UPDATE ChucVu SET TenCV=@Ten WHERE MaCV=@Ma";
            return Db.Execute(sql,
                new SqlParameter("@Ma", cv.MaCV),
                new SqlParameter("@Ten", cv.TenCV)) > 0;
        }

        public bool Xoa(string maCV)
        {
            return Db.Execute("DELETE FROM ChucVu WHERE MaCV=@Ma", new SqlParameter("@Ma", maCV)) > 0;
        }
    }
}
