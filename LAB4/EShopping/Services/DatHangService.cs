using System;
using System.Data;
using System.Data.SqlClient;
using eShopping.Data;
using eShopping.Models;

namespace eShopping.Services
{
    public class DatHangService
    {
        public DataTable LayDanhSachLoaiPhieu() => Db.Query("SELECT * FROM LOAIPHIEU");
        public DataTable LayDanhSachKhuVuc() => Db.Query("SELECT * FROM KHUVUCGIAO");
        public DataTable LayDanhSachLoaiThe() => Db.Query("SELECT * FROM LOAITHE");

        public decimal TinhPhiGiaoHang(int maLoaiPhieu, int maKV, decimal tamTinhGioHang)
        {
            var dtPhieu = Db.Query("SELECT * FROM LOAIPHIEU WHERE MaLoaiPhieu = @ID", new SqlParameter("@ID", maLoaiPhieu));
            var dtKV = Db.Query("SELECT * FROM KHUVUCGIAO WHERE MaKV = @ID", new SqlParameter("@ID", maKV));

            if (dtPhieu.Rows.Count == 0 || dtKV.Rows.Count == 0) return 0;

            decimal donGiaPhieu = Convert.ToDecimal(dtPhieu.Rows[0]["DonGia"]);
            decimal phiKV = Convert.ToDecimal(dtKV.Rows[0]["PhiGiao"]);
            object nguongObj = dtPhieu.Rows[0]["NguongMienPhi"];

            // Kiểm tra ngưỡng miễn phí giao hàng
            if (nguongObj != DBNull.Value)
            {
                decimal nguongMienPhi = Convert.ToDecimal(nguongObj);
                if (tamTinhGioHang >= nguongMienPhi) return 0; // Miễn phí hoàn toàn
            }

            return phiKV + donGiaPhieu;
        }

        public KetQuaThaoTac KiemTraTheTinDung(int maLoaiThe, string soThe, string csv, DateTime ngayHetHan, out decimal lePhiThe)
        {
            var kq = new KetQuaThaoTac();
            lePhiThe = 0;

            var dtThe = Db.Query("SELECT * FROM LOAITHE WHERE MaLoaiThe = @ID", new SqlParameter("@ID", maLoaiThe));
            if (dtThe.Rows.Count == 0)
            {
                kq.ThanhCong = false;
                kq.ThongBao = "Loại thẻ không hợp lệ!";
                return kq;
            }

            int doDaiSoThe = Convert.ToInt32(dtThe.Rows[0]["DoDaiSoThe"]);
            int doDaiCSV = Convert.ToInt32(dtThe.Rows[0]["DoDaiCSV"]);
            lePhiThe = Convert.ToDecimal(dtThe.Rows[0]["LePhi"]);

            // Check cục bộ
            if (soThe.Length != doDaiSoThe)
            {
                kq.ThanhCong = false;
                kq.ThongBao = $"Số thẻ không hợp lệ (yêu cầu {doDaiSoThe} chữ số)!";
                return kq;
            }
            if (csv.Length != doDaiCSV)
            {
                kq.ThanhCong = false;
                kq.ThongBao = $"Mã CSV không hợp lệ (yêu cầu {doDaiCSV} chữ số)!";
                return kq;
            }
            if (ngayHetHan.Date < DateTime.Now.Date)
            {
                kq.ThanhCong = false;
                kq.ThongBao = "Thẻ đã hết hạn sử dụng!";
                return kq;
            }

            // Gọi Dịch vụ Thanh toán trực tuyến giả lập
            kq.ThanhCong = true;
            kq.ThongBao = "Xác thực thẻ tín dụng thành công!";
            return kq;
        }

        public int TaoDonHang(int maKH, int maLoaiPhieu, int maKV, int maLoaiThe, string soThe, DateTime ngayHetHan, 
                            string tenChuThe, string hoTenNguoiNhan, string diaChiNguoiNhan, string sdtNguoiNhan, 
                            decimal phiGiao, decimal lePhiThe, GioHang gioHang)
        {
            using (var cn = Db.OpenConnection())
            using (var tran = cn.BeginTransaction())
            {
                try
                {
                    // 1. Lưu Người nhận
                    string sqlNN = "INSERT INTO NGUOINHAN(HoTen, DiaChi, DienThoai) VALUES(@HoTen, @DiaChi, @SDT); SELECT SCOPE_IDENTITY();";
                    int maNguoiNhan = 0;
                    using (var cmd = new SqlCommand(sqlNN, cn, tran))
                    {
                        cmd.Parameters.AddWithValue("@HoTen", hoTenNguoiNhan);
                        cmd.Parameters.AddWithValue("@DiaChi", diaChiNguoiNhan);
                        cmd.Parameters.AddWithValue("@SDT", sdtNguoiNhan);
                        maNguoiNhan = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 2. Lưu Thẻ tín dụng (chỉ lưu 4 số cuối)
                    string soCuoi4 = soThe.Substring(soThe.Length - 4);
                    string sqlThe = "INSERT INTO THETINDUNG(MaLoaiThe, SoCuoi4, NgayHetHan, TenChuThe) VALUES(@MaLoai, @SoCuoi4, @NgayHH, @Ten); SELECT SCOPE_IDENTITY();";
                    int maThe = 0;
                    using (var cmd = new SqlCommand(sqlThe, cn, tran))
                    {
                        cmd.Parameters.AddWithValue("@MaLoai", maLoaiThe);
                        cmd.Parameters.AddWithValue("@SoCuoi4", soCuoi4);
                        cmd.Parameters.AddWithValue("@NgayHH", ngayHetHan);
                        cmd.Parameters.AddWithValue("@Ten", tenChuThe);
                        maThe = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 3. Tạo Đơn đặt hàng
                    decimal tongTriGia = gioHang.TinhTamTinh() + phiGiao + lePhiThe;
                    string sqlDon = @"INSERT INTO DONDATHANG(MaKH, MaLoaiPhieu, MaKV, MaThe, MaNguoiNhan, ThoiDiemDat, PhiGiao, LePhiThe, TongTriGia, TrangThai)
                                      VALUES(@MaKH, @MaPhieu, @MaKV, @MaThe, @MaNN, GETDATE(), @PhiGiao, @LePhiThe, @Tong, N'DaXacNhan'); SELECT SCOPE_IDENTITY();";
                    int maDon = 0;
                    using (var cmd = new SqlCommand(sqlDon, cn, tran))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", maKH);
                        cmd.Parameters.AddWithValue("@MaPhieu", maLoaiPhieu);
                        cmd.Parameters.AddWithValue("@MaKV", maKV);
                        cmd.Parameters.AddWithValue("@MaThe", maThe);
                        cmd.Parameters.AddWithValue("@MaNN", maNguoiNhan);
                        cmd.Parameters.AddWithValue("@PhiGiao", phiGiao);
                        cmd.Parameters.AddWithValue("@LePhiThe", lePhiThe);
                        cmd.Parameters.AddWithValue("@Tong", tongTriGia);
                        maDon = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 4. Lưu Chi tiết đơn hàng
                    string sqlCT = "INSERT INTO CHITIETDONHANG(MaDon, MaSP, SoLuong, DonGia) VALUES(@MaDon, @MaSP, @SL, @DonGia)";
                    foreach (var item in gioHang.DanhSachMuc)
                    {
                        using (var cmd = new SqlCommand(sqlCT, cn, tran))
                        {
                            cmd.Parameters.AddWithValue("@MaDon", maDon);
                            cmd.Parameters.AddWithValue("@MaSP", item.MaSP);
                            cmd.Parameters.AddWithValue("@SL", item.SoLuong);
                            cmd.Parameters.AddWithValue("@DonGia", item.GiaBan);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    tran.Commit();
                    return maDon;
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }
    }
}
