using System;
using System.Windows.Forms;
using QuanLyThuVien.Forms; // Khai báo đường dẫn đến thư mục Forms

namespace QuanLyThuVien
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Đặt FrmMuonTra làm Form khởi chạy khi bấm F5
            Application.Run(new FrmMuonTra());
        }
    }
}