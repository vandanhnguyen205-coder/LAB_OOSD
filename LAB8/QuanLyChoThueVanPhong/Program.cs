using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Forms;

namespace QuanLyChoThueVanPhong
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
