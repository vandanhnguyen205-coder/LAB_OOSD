using System;
using System.Collections.Generic;

namespace eShopping.Models
{
    public class KetQuaThaoTac
    {
        public bool ThanhCong { get; set; }
        public string ThongBao { get; set; }
        public Dictionary<string, string> DsLoi { get; set; } = new Dictionary<string, string>();
    }

    public class KhachHang
    {
        public int MaKH { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SoCMND_Passport { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
    }

    public class NhomSanPham
    {
        public string MaNhom { get; set; }
        public string TenNhom { get; set; }
    }

    public class SanPham
    {
        public string MaSP { get; set; }
        public string MaNhom { get; set; }
        public string TenSP { get; set; }
        public string NhaSanXuat { get; set; }
        public string HinhAnh { get; set; }
        public string MoTa { get; set; }
        public string ThongSoKyThuat { get; set; }
        public decimal GiaBan { get; set; }
        public bool TinhTrang { get; set; }
    }

    public class MucGioHang
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien => GiaBan * SoLuong;
    }

    public class GioHang
    {
        public int MaGioHang { get; set; }
        public int MaKH { get; set; }
        public List<MucGioHang> DanhSachMuc { get; set; } = new List<MucGioHang>();

        public decimal TinhTamTinh()
        {
            decimal tong = 0;
            foreach (var item in DanhSachMuc) tong += item.ThanhTien;
            return tong;
        }
    }

    public class LoaiPhieu
    {
        public int MaLoaiPhieu { get; set; }
        public string TenLoai { get; set; }
        public decimal DonGia { get; set; }
        public string ThoiGianXuLy { get; set; }
        public decimal? NguongMienPhi { get; set; }
    }

    public class KhuVucGiao
    {
        public int MaKV { get; set; }
        public string TenKV { get; set; }
        public decimal PhiGiao { get; set; }
    }

    public class LoaiThe
    {
        public int MaLoaiThe { get; set; }
        public string TenLoai { get; set; }
        public int DoDaiSoThe { get; set; }
        public int DoDaiCSV { get; set; }
        public decimal LePhi { get; set; }
    }
}
