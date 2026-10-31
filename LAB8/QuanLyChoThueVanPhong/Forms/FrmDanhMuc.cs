using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmDanhMuc : Form
    {
        private PhongService _phongService = new PhongService();

        public FrmDanhMuc()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvPhong.DataSource = _phongService.LayDanhSachPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
