using System.Data;
using System.Data.SqlClient;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class PhongService
    {
        public DataTable LayDanhSachPhong()
        {
            string query = "SELECT P.MaPhong, P.DienTich, P.HuongPhong, P.DonGiaM2, P.TrangThai, T.TenTang " +
                           "FROM Phong P JOIN Tang T ON P.MaTang = T.MaTang";
            return Db.ExecuteQuery(query);
        }

        public DataTable LayPhongTrong()
        {
            string query = "SELECT MaPhong, DienTich, DonGiaM2 FROM Phong WHERE TrangThai = N'Trống'";
            return Db.ExecuteQuery(query);
        }
    }
}
