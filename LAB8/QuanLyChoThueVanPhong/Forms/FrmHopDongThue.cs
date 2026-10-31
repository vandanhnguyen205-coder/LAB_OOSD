using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmHopDongThue : Form
    {
        private HopDongService _hopDongService = new HopDongService();
        private PhongService _phongService = new PhongService();

        public FrmHopDongThue()
        {
            InitializeComponent();
            LoadPhongTrong();
        }

        private void LoadPhongTrong()
        {
            try
            {
                cboPhongTrong.DataSource = _phongService.LayPhongTrong();
                cboPhongTrong.DisplayMember = "MaPhong";
                cboPhongTrong.ValueMember = "MaPhong";
            }
            catch { }
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            if (numThoiGian.Value < 6)
            {
                MessageBox.Show("Ràng buộc nghiệp vụ: Thời gian thuê phải từ 6 tháng trở lên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPhong = cboPhongTrong.SelectedValue != null ? cboPhongTrong.SelectedValue.ToString() : "P101";
            bool ketQua = _hopDongService.LapHopDongTransaction(
                txtSoHD.Text.Trim(),
                txtMaKhach.Text.Trim(),
                maPhong,
                dtpNgayBD.Value,
                (int)numThoiGian.Value,
                Convert.ToDecimal(txtDonGia.Text),
                Convert.ToDecimal(txtDienTich.Text),
                "NV01"
            );

            if (ketQua)
            {
                MessageBox.Show("Lập hợp đồng thuê văn phòng thành công và đã đổi trạng thái phòng!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhongTrong();
            }
            else
            {
                MessageBox.Show("Thất bại trong quá trình thực thi Transaction!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
