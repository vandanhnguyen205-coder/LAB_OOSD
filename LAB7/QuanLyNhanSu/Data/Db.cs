using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.Data
{
    public static class Db
    {
        private const string DefaultConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True";

        public static string ConnectionString
        {
            get
            {
                var setting = ConfigurationManager.ConnectionStrings["QuanLyNhanSuDB"];
                if (setting != null && !string.IsNullOrWhiteSpace(setting.ConnectionString))
                {
                    return setting.ConnectionString;
                }
                return DefaultConnectionString;
            }
        }

        public static SqlConnection OpenConnection()
        {
            var cn = new SqlConnection(ConnectionString);
            cn.Open();
            return cn;
        }

        public static DataTable Query(string sql, params SqlParameter[] ps)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            using (var da = new SqlDataAdapter(cmd))
            {
                if (ps != null && ps.Length > 0)
                {
                    cmd.Parameters.AddRange(ps);
                }
                var dt = new DataTable();
                da.Fill(dt);
                cmd.Parameters.Clear();
                return dt;
            }
        }

        public static int Execute(string sql, params SqlParameter[] ps)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (ps != null && ps.Length > 0)
                {
                    cmd.Parameters.AddRange(ps);
                }
                int result = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return result;
            }
        }

        public static object Scalar(string sql, params SqlParameter[] ps)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (ps != null && ps.Length > 0)
                {
                    cmd.Parameters.AddRange(ps);
                }
                object result = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return result;
            }
        }
    }
}
