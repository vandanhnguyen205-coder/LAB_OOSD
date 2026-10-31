using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyChoThueVanPhong.Data
{
    public class Db
    {
        private static readonly string ConnectionString = 
            ConfigurationManager.ConnectionStrings["QuanLyChoThueVanPhongDB"]?.ConnectionString 
            ?? @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyChoThueVanPhong;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
