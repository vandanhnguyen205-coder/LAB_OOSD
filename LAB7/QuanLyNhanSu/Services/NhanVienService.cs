using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Data;
using QuanLyNhanSu.Models;

namespace QuanLyNhanSu.Services
{
    public class NhanVienService
    {
        public DataTable LayTatCa()
        {
            string sql = @"SELECT nv.MaNV, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.DienThoai, nv.DiaChi, nv.TrangThai, 
                                  nv.MaPB, pb.TenPB
                           FROM NhanVien nv
                           LEFT JOIN PhongBan pb ON nv.MaPB = pb.MaPB";
            return Db.Query(sql);
        }

        public bool Them(NhanVien nv)
        {
            string sql = "INSERT INTO NhanVien VALUES(@Ma, @Ten, @NS, @GT, @SDT, @DC, @TT, @MaPB)";
            return Db.Execute(sql,
                new SqlParameter("@Ma", nv.MaNV),
                new SqlParameter("@Ten", nv.HoTen),
                new SqlParameter("@NS", nv.NgaySinh),
                new SqlParameter("@GT", nv.GioiTinh),
                new SqlParameter("@SDT", (object)nv.DienThoai ?? DBNull.Value),
                new SqlParameter("@DC", (object)nv.DiaChi ?? DBNull.Value),
                new SqlParameter("@TT", nv.TrangThai),
                new SqlParameter("@MaPB", (object)nv.MaPB ?? DBNull.Value)) > 0;
        }

        public bool Sua(NhanVien nv)
        {
            string sql = "UPDATE NhanVien SET HoTen=@Ten, NgaySinh=@NS, GioiTinh=@GT, DienThoai=@SDT, DiaChi=@DC, TrangThai=@TT, MaPB=@MaPB WHERE MaNV=@Ma";
            return Db.Execute(sql,
                new SqlParameter("@Ma", nv.MaNV),
                new SqlParameter("@Ten", nv.HoTen),
                new SqlParameter("@NS", nv.NgaySinh),
                new SqlParameter("@GT", nv.GioiTinh),
                new SqlParameter("@SDT", (object)nv.DienThoai ?? DBNull.Value),
                new SqlParameter("@DC", (object)nv.DiaChi ?? DBNull.Value),
                new SqlParameter("@TT", nv.TrangThai),
                new SqlParameter("@MaPB", (object)nv.MaPB ?? DBNull.Value)) > 0;
        }

        public bool Xoa(string maNV)
        {
            return Db.Execute("DELETE FROM NhanVien WHERE MaNV=@Ma", new SqlParameter("@Ma", maNV)) > 0;
        }
    }
}
