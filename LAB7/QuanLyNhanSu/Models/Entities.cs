using System;

namespace QuanLyNhanSu.Models
{
    public class PhongBan
    {
        public string MaPB { get; set; }
        public string TenPB { get; set; }
        public string LoaiDonVi { get; set; }
    }

    public class ChucVu
    {
        public string MaCV { get; set; }
        public string TenCV { get; set; }
    }

    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string TrangThai { get; set; }
        public string MaPB { get; set; }
    }

    public class QuyetDinhTuyenDung
    {
        public string SoQD { get; set; }
        public DateTime NgayQD { get; set; }
        public DateTime NgayBatDauThuViec { get; set; }
        public DateTime NgayKetThucThuViec { get; set; }
        public decimal LuongThuViec { get; set; }
        public string DieuKhoan { get; set; }
        public string MaNV { get; set; }
        public string MaPB { get; set; }
    }

    public class BangLuongModel
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public decimal LuongCoBan { get; set; }
        public decimal PhuCap { get; set; }
        public decimal LuongNgayCong { get; set; }
        public decimal TienPhuTroi { get; set; }
        public decimal Thuong { get; set; }
        public decimal KhoanTruBH { get; set; }
        public decimal Phat { get; set; }
        public decimal ThucLinh { get; set; }
    }
}
