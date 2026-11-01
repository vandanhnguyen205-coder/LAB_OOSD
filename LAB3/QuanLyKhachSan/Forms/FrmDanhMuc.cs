using System;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDanhMuc : Form
    {
        private readonly DanhMucService _danhmucService;

        public FrmDanhMuc()
        {
            InitializeComponent();
            _danhmucService = new DanhMucService();
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            dgvKhuVuc.DataSource = _danhmucService.LayDanhSachKhuVuc();
            dgvPhong.DataSource = _danhmucService.LayDanhSachPhong();
            dgvDichVu.DataSource = _danhmucService.LayDanhSachDichVu();
            dgvTienNghi.DataSource = _danhmucService.LayDanhSachTienNghi();
        }
    }
}
