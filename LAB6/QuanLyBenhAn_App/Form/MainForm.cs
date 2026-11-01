using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBenhAn.Data;

namespace QuanLyBenhAn
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bool ok = Db.KiemTraKetNoi();
            lblStatus.Text = ok ? "Kết nối CSDL: OK" : "Kết nối CSDL: LỖI (kiểm tra App.config)";
            lblStatus.ForeColor = ok ? Color.Green : Color.Red;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            new DangKyBenhNhanForm().ShowDialog();
        }

        private void btnNhapDotKham_Click(object sender, EventArgs e)
        {
            new NhapDotKhamForm().ShowDialog();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            new TraCuuHoSoForm().ShowDialog();
        }
    }
}
