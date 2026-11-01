using System;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDichVu : Form
    {
        private readonly DichVuService _dichVuService;

        // Lớp đại diện cho từng item trong ComboBox
        private class DichVuItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public override string ToString() => Text;
        }

        public FrmDichVu()
        {
            InitializeComponent();
            _dichVuService = new DichVuService();
            LoadData();
        }

        private void LoadData()
        {
            dgvPhongDangO.DataSource = _dichVuService.LayDanhSachPhongDangO();
            cboDichVu.Items.Clear();
            cboDichVu.Items.Add(new DichVuItem { Text = "Ăn sáng (120k)", Value = "DV01" });
            cboDichVu.Items.Add(new DichVuItem { Text = "Tắm hơi (250k)", Value = "DV02" });
            cboDichVu.Items.Add(new DichVuItem { Text = "Karaoke (300k)", Value = "DV03" });
            if (cboDichVu.Items.Count > 0) cboDichVu.SelectedIndex = 0;
        }

        private void btnLuuDV_Click(object sender, EventArgs e)
        {
            if (dgvPhongDangO.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng đang ở!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string soPhieuDat = dgvPhongDangO.SelectedRows[0].Cells["SoPhieuDat"].Value.ToString();
            string soPhong = dgvPhongDangO.SelectedRows[0].Cells["SoPhong"].Value.ToString();

            var selectedDV = (DichVuItem)cboDichVu.SelectedItem;
            string maDV = selectedDV.Value;
            int soLuong = (int)nudSoLuong.Value;

            try
            {
                bool thanhCong = _dichVuService.GhiNhanSuDungDichVu(soPhieuDat, soPhong, maDV, soLuong, "NV02");
                if (thanhCong)
                {
                    MessageBox.Show("Ghi nhận dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhận dịch vụ: " + ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}