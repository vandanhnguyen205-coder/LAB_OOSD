using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBenhAn.Data
{
    public static class Db
    {
        private static string ConnStr => ConfigurationManager.ConnectionStrings["QuanLyBenhAnDb"].ConnectionString;

        public static SqlConnection TaoKetNoi()
        {
            return new SqlConnection(ConnStr);
        }

        public static bool KiemTraKetNoi()
        {
            try
            {
                using (var cn = TaoKetNoi())
                {
                    cn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static SqlParameter Tham(string ten, object giaTri)
        {
            return new SqlParameter(ten, giaTri ?? DBNull.Value);
        }

        public static DataTable LayBang(string sql, params SqlParameter[] ts)
        {
            var dt = new DataTable();
            using (var cn = TaoKetNoi())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (ts != null) cmd.Parameters.AddRange(ts);
                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public static int ThucThi(string sql, params SqlParameter[] ts)
        {
            using (var cn = TaoKetNoi())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (ts != null) cmd.Parameters.AddRange(ts);
                cn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static object LayGiaTri(string sql, params SqlParameter[] ts)
        {
            using (var cn = TaoKetNoi())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (ts != null) cmd.Parameters.AddRange(ts);
                cn.Open();
                return cmd.ExecuteScalar();
            }
        }
    }
}
