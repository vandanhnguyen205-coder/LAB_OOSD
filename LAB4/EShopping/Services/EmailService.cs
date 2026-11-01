using System;

namespace eShopping.Services
{
    public class EmailService
    {
        public static bool GuiEmailXacNhan(int maDon, string emailKhach)
        {
            if (string.IsNullOrEmpty(emailKhach)) return false;

            try
            {
                // Giả lập gửi Email qua DV Email ngoài và ghi Log
                Console.WriteLine($"[DV EMAIL] Đã gửi email xác nhận đơn hàng #{maDon} thành công tới: {emailKhach}");
                return true;
            }
            catch (Exception ex)
            {
                // Ghi log lỗi gửi email (Không hủy đơn hàng)
                Console.WriteLine($"[DV EMAIL ERROR] Lỗi gửi email cho đơn #{maDon}: {ex.Message}");
                return false;
            }
        }
    }
}
