using System.Collections.Generic;
using eShopping.Models;

namespace eShopping.Services
{
    public class GioHangService
    {
        private static GioHang _gioHangHienTai = new GioHang();
        private readonly IProductSystemAdapter _productAdapter;

        public GioHangService()
        {
            _productAdapter = new ProductSystemAdapter();
        }

        public GioHang LayGioHangHienTai() => _gioHangHienTai;

        public KetQuaThaoTac ThemSanPham(string maSP, int soLuong)
        {
            var kq = new KetQuaThaoTac();

            if (!_productAdapter.KiemTraTonKho(maSP, soLuong))
            {
                kq.ThanhCong = false;
                kq.ThongBao = "Sản phẩm đã hết hàng hoặc số lượng tồn kho không đủ!";
                return kq;
            }

            var sp = _productAdapter.GetSanPham(maSP);
            var itemExist = _gioHangHienTai.DanhSachMuc.Find(m => m.MaSP == maSP);

            if (itemExist != null)
            {
                itemExist.SoLuong += soLuong;
            }
            else
            {
                _gioHangHienTai.DanhSachMuc.Add(new MucGioHang
                {
                    MaSP = sp.MaSP,
                    TenSP = sp.TenSP,
                    GiaBan = sp.GiaBan,
                    SoLuong = soLuong
                });
            }

            kq.ThanhCong = true;
            kq.ThongBao = "Đã thêm vào giỏ hàng thành công!";
            return kq;
        }

        public void CapNhatSoLuong(string maSP, int soLuongMoi)
        {
            var item = _gioHangHienTai.DanhSachMuc.Find(m => m.MaSP == maSP);
            if (item != null)
            {
                if (soLuongMoi <= 0) _gioHangHienTai.DanhSachMuc.Remove(item);
                else item.SoLuong = soLuongMoi;
            }
        }

        public void XoaMuc(string maSP)
        {
            _gioHangHienTai.DanhSachMuc.RemoveAll(m => m.MaSP == maSP);
        }

        public void LamTrongGioHang()
        {
            _gioHangHienTai.DanhSachMuc.Clear();
        }
    }
}
