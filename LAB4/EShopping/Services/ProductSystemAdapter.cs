using System;
using System.Data;
using System.Data.SqlClient;
using eShopping.Data;
using eShopping.Models;

namespace eShopping.Services
{
    public interface IProductSystemAdapter
    {
        DataTable LayDanhSachNhom();
        DataTable LayDanhSachSanPham(string maNhom);
        SanPham GetSanPham(string maSP);
        bool KiemTraTonKho(string maSP, int soLuongYeuCau);
    }

    public class ProductSystemAdapter : IProductSystemAdapter
    {
        public DataTable LayDanhSachNhom()
        {
            return Db.Query("SELECT * FROM NHOMSANPHAM");
        }

        public DataTable LayDanhSachSanPham(string maNhom)
        {
            string sql = "SELECT * FROM SANPHAM WHERE 1=1";
            if (!string.IsNullOrEmpty(maNhom)) sql += " AND MaNhom = @MaNhom";
            return Db.Query(sql, new SqlParameter("@MaNhom", maNhom ?? ""));
        }

        public SanPham GetSanPham(string maSP)
        {
            var dt = Db.Query("SELECT * FROM SANPHAM WHERE MaSP = @MaSP", new SqlParameter("@MaSP", maSP));
            if (dt.Rows.Count == 0) return null;
            var dr = dt.Rows[0];
            return new SanPham
            {
                MaSP = dr["MaSP"].ToString(),
                MaNhom = dr["MaNhom"].ToString(),
                TenSP = dr["TenSP"].ToString(),
                NhaSanXuat = dr["NhaSanXuat"].ToString(),
                GiaBan = Convert.ToDecimal(dr["GiaBan"]),
                TinhTrang = Convert.ToBoolean(dr["TinhTrang"])
            };
        }

        public bool KiemTraTonKho(string maSP, int soLuongYeuCau)
        {
            var sp = GetSanPham(maSP);
            return sp != null && sp.TinhTrang && soLuongYeuCau > 0;
        }
    }
}
