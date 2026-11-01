using System;
using System.Windows.Forms;
using QuanLyNhanSu.Services;

namespace QuanLyNhanSu.Forms
{
    public partial class TinhLuongForm : Form
    {
        private readonly LuongService _svc = new LuongService();

        public TinhLuongForm()
        {
            InitializeComponent();
            numThang.Value = DateTime.Now.Month;
            numNam.Value = DateTime.Now.Year;
            LoadData();
        }

        private void LoadData()
        {
            int thang = (int)numThang.Value;
            int nam = (int)numNam.Value;
            dgvData.DataSource = _svc.LayBangLuong(thang, nam);
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            try
            {
                int thang = (int)numThang.Value;
                int nam = (int)numNam.Value;

                if (_svc.TinhVaLuuLuong(thang, nam))
                {
                    MessageBox.Show($"Tính toán và tổng hợp bảng lương Tháng {thang}/{nam} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show($"Chưa có dữ liệu bảng chấm công cho Tháng {thang}/{nam}! Vui lòng nhập chấm công trước.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính lương: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
