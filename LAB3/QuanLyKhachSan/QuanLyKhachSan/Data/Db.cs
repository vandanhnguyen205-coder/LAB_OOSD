using System.Data;
using System.Data.SqlClient; // ✅ Phải có dòng này ở đầu file

namespace QuanLyKhachSan.Data
{
    public static class Db
    {
        private static readonly string _chuoiKetNoi =
            @"Data Source=LAPTOP-6UDNV190;Initial Catalog=QuanLyKhachSan;Integrated Security=True;TrustServerCertificate=True";

        // === ĐÚNG: Trả về kiểu SqlConnection ===
        public static SqlConnection MoKetNoi()
        {
            var conn = new SqlConnection(_chuoiKetNoi);
            conn.Open();
            return conn;
        }

        // ❌ SAI — nếu bạn đang viết như này:
        // public static IDisposable MoKetNoi() { ... }
        // → Xóa và viết đúng như trên
    }
}