using System;
using System.Data;
using System.Windows.Forms;
using eShopping.Services;

namespace eShopping.Forms
{
    public partial class DatHangForm : Form
    {
        private readonly DatHangService _datHangService;
        private readonly GioHangService _gioHangService;

        public DatHangForm()
        {
            InitializeComponent();
            _datHangService = new DatHangService();
            _gioHangService = new GioHangService();
            LoadData();
        }

        private void LoadData()
        {
            cboLoaiPhieu.DataSource = _datHangService.LayDanhSachLoaiPhieu();
            cboLoaiPhieu.DisplayMember = "TenLoai";
            cboLoaiPhieu.ValueMember = "MaLoaiPhieu";

            cboKhuVuc.DataSource = _datHangService.LayDanhSachKhuVuc();
            cboKhuVuc.DisplayMember = "TenKV";
            cboKhuVuc.ValueMember = "MaKV";

            cboLoaiThe.DataSource = _datHangService.LayDanhSachLoaiThe();
            cboLoaiThe.DisplayMember = "TenLoai";
            cboLoaiThe.ValueMember = "MaLoaiThe";

            if (TaiKhoanService.KhachHangDaDangNhap != null)
            {
                txtTenNguoiNhan.Text = TaiKhoanService.KhachHangDaDangNhap.HoTen;
            }

            CapNhatTongTien();
        }

        private void CapNhatTongTien()
        {
            if (cboLoaiPhieu.SelectedValue == null || cboKhuVuc.SelectedValue == null || cboLoaiThe.SelectedValue == null) return;

            int maPhieu = Convert.ToInt32(cboLoaiPhieu.SelectedValue);
            int maKV = Convert.ToInt32(cboKhuVuc.SelectedValue);
            int maThe = Convert.ToInt32(cboLoaiThe.SelectedValue);

            var gioHang = _gioHangService.LayGioHangHienTai();
            decimal tamTinh = gioHang.TinhTamTinh();
            decimal phiGiao = _datHangService.TinhPhiGiaoHang(maPhieu, maKV, tamTinh);

            var dtThe = _datHangService.LayDanhSachLoaiThe();
            decimal lePhiThe = 0;
            foreach (DataRow dr in dtThe.Rows)
            {
                if (Convert.ToInt32(dr["MaLoaiThe"]) == maThe)
                {
                    lePhiThe = Convert.ToDecimal(dr["LePhi"]);
                    break;
                }
            }

            decimal tongTriGia = tamTinh + phiGiao + lePhiThe;

            lblTamTinh.Text = "Tiền hàng: " + tamTinh.ToString("N0") + " VNĐ";
            lblPhiGiao.Text = "Phí giao: " + phiGiao.ToString("N0") + " VNĐ";
            lblLePhiThe.Text = "Lệ phí thẻ: " + lePhiThe.ToString("N0") + " VNĐ";
            lblTongTien.Text = "TỔNG THANH TOÁN: " + tongTriGia.ToString("N0") + " VNĐ";
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e) => CapNhatTongTien();

        private void btnXacNhanDat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNguoiNhan.Text) || string.IsNullOrWhiteSpace(txtDiaChiNguoiNhan.Text) || string.IsNullOrWhiteSpace(txtSDTNguoiNhan.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin người nhận hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maPhieu = Convert.ToInt32(cboLoaiPhieu.SelectedValue);
            int maKV = Convert.ToInt32(cboKhuVuc.SelectedValue);
            int maThe = Convert.ToInt32(cboLoaiThe.SelectedValue);

            // Kiểm tra thẻ tín dụng
            var kqThe = _datHangService.KiemTraTheTinDung(maThe, txtSoThe.Text.Trim(), txtCSV.Text.Trim(), dtpNgayHH.Value, out decimal lePhiThe);
            if (!kqThe.ThanhCong)
            {
                MessageBox.Show(kqThe.ThongBao, "Lỗi thanh toán thẻ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var gioHang = _gioHangService.LayGioHangHienTai();
            decimal phiGiao = _datHangService.TinhPhiGiaoHang(maPhieu, maKV, gioHang.TinhTamTinh());

            try
            {
                int maDon = _datHangService.TaoDonHang(
                    TaiKhoanService.KhachHangDaDangNhap.MaKH,
                    maPhieu, maKV, maThe,
                    txtSoThe.Text.Trim(), dtpNgayHH.Value, txtTenChuThe.Text.Trim(),
                    txtTenNguoiNhan.Text.Trim(), txtDiaChiNguoiNhan.Text.Trim(), txtSDTNguoiNhan.Text.Trim(),
                    phiGiao, lePhiThe, gioHang
                );

                // Gửi email xác nhận (nếu có email)
                bool emailSent = EmailService.GuiEmailXacNhan(maDon, TaiKhoanService.KhachHangDaDangNhap.Email);

                // Xóa trống giỏ hàng sau khi đặt thành công
                _gioHangService.LamTrongGioHang();

                using (var form = new XacNhanDonForm(maDon, emailSent))
                {
                    form.ShowDialog(this);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lập đơn hàng: " + ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
