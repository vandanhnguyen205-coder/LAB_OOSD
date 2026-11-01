using System;
using System.Data;
using QuanLyKhachSan.Data;

namespace QuanLyKhachSan.Services
{
    public class DanhMucService
    {
        public DataTable LayDanhSachKhuVuc() => Db.Query("SELECT * FROM KhuVuc");
        public DataTable LayDanhSachPhong() => Db.Query("SELECT p.*, k.TenKhuVuc FROM Phong p JOIN KhuVuc k ON p.MaKhuVuc = k.MaKhuVuc");
        public DataTable LayDanhSachDichVu() => Db.Query("SELECT * FROM DichVu");
        public DataTable LayDanhSachLoaiTienNghi() => Db.Query("SELECT * FROM LoaiTienNghi");
        public DataTable LayDanhSachTienNghi() => Db.Query("SELECT tn.*, ltn.TenLoaiTN FROM TienNghi tn JOIN LoaiTienNghi ltn ON tn.MaLoaiTN = ltn.MaLoaiTN");
    }
}
