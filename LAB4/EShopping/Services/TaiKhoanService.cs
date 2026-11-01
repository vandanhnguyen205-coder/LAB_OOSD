using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using eShopping.Data;
using eShopping.Models;

namespace eShopping.Services
{
    public class TaiKhoanService
    {
        public static KhachHang KhachHangDaDangNhap { get; set; } = null;

        public KetQuaThaoTac DangKy(KhachHang kh)
        {
            var kq = new KetQuaThaoTac();
            
            // KiemTraHopLe
            if (string.IsNullOrWhiteSpace(kh.HoTen)) kq.DsLoi["HoTen"] = "Họ tên không được trống!";
            if (string.IsNullOrWhiteSpace(kh.SoCMND_Passport)) kq.DsLoi["SoCMND"] = "Số CMND/Passport không được trống!";
            if (string.IsNullOrWhiteSpace(kh.TenDangNhap)) kq.DsLoi["TenDangNhap"] = "Tên đăng nhập không được trống!";
            if (string.IsNullOrWhiteSpace(kh.MatKhau)) kq.DsLoi["MatKhau"] = "Mật khẩu không được trống!";

            if (kq.DsLoi.Count > 0)
            {
                kq.ThanhCong = false;
                kq.ThongBao = "Dữ liệu nhập vào chưa hợp lệ!";
                return kq;
            }

            // TonTaiTenDangNhap
            int count = (int)Db.Scalar("SELECT COUNT(*) FROM KHACHHANG WHERE TenDangNhap = @User", new SqlParameter("@User", kh.TenDangNhap.Trim()));
            if (count > 0)
            {
                kq.ThanhCong = false;
                kq.ThongBao = "Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!";
                return kq;
            }

            // BamMatKhau
            string hashPassword = BamMatKhau(kh.MatKhau);

            string sql = @"INSERT INTO KHACHHANG(HoTen, NgaySinh, SoCMND_Passport, DiaChi, DienThoai, TenDangNhap, MatKhau, Email)
                           VALUES(@HoTen, @NgaySinh, @CMND, @DiaChi, @DienThoai, @User, @Pass, @Email)";

            Db.Execute(sql,
                new SqlParameter("@HoTen", kh.HoTen.Trim()),
                new SqlParameter("@NgaySinh", kh.NgaySinh),
                new SqlParameter("@CMND", kh.SoCMND_Passport.Trim()),
                new SqlParameter("@DiaChi", kh.DiaChi ?? ""),
                new SqlParameter("@DienThoai", kh.DienThoai ?? ""),
                new SqlParameter("@User", kh.TenDangNhap.Trim()),
                new SqlParameter("@Pass", hashPassword),
                new SqlParameter("@Email", string.IsNullOrEmpty(kh.Email) ? (object)DBNull.Value : kh.Email.Trim())
            );

            kq.ThanhCong = true;
            kq.ThongBao = "Đăng ký tài khoản thành công!";
            return kq;
        }

        public KetQuaThaoTac DangNhap(string username, string password)
        {
            var kq = new KetQuaThaoTac();
            string hashPassword = BamMatKhau(password);

            var dt = Db.Query("SELECT * FROM KHACHHANG WHERE TenDangNhap = @User AND MatKhau = @Pass",
                new SqlParameter("@User", username.Trim()),
                new SqlParameter("@Pass", hashPassword));

            if (dt.Rows.Count > 0)
            {
                var dr = dt.Rows[0];
                KhachHangDaDangNhap = new KhachHang
                {
                    MaKH = Convert.ToInt32(dr["MaKH"]),
                    HoTen = dr["HoTen"].ToString(),
                    TenDangNhap = dr["TenDangNhap"].ToString(),
                    Email = dr["Email"] == DBNull.Value ? null : dr["Email"].ToString()
                };

                kq.ThanhCong = true;
                kq.ThongBao = "Đăng nhập thành công!";
            }
            else
            {
                kq.ThanhCong = false;
                kq.ThongBao = "Tên đăng nhập hoặc mật khẩu không chính xác!";
            }

            return kq;
        }

        public static string BamMatKhau(string pass)
        {
            using (var md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(pass);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                var sb = new StringBuilder();
                foreach (byte b in hashBytes) sb.Append(b.ToString("X2"));
                return sb.ToString();
            }
        }
    }
}
