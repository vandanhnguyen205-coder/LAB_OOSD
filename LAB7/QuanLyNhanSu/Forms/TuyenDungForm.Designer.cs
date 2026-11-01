namespace QuanLyNhanSu.Forms
{
    partial class TuyenDungForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox gbNhanVien;
        private System.Windows.Forms.Label lblMaNV; private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblHoTen; private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh; private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh; private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblSDT; private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblDiaChi; private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblPhongBan; private System.Windows.Forms.ComboBox cboPhongBan;

        private System.Windows.Forms.GroupBox gbQuyetDinh;
        private System.Windows.Forms.Label lblSoQD; private System.Windows.Forms.TextBox txtSoQD;
        private System.Windows.Forms.Label lblNgayQD; private System.Windows.Forms.DateTimePicker dtpNgayQD;
        private System.Windows.Forms.Label lblBatDau; private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.Label lblKetThuc; private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.Label lblLuong; private System.Windows.Forms.NumericUpDown numLuongThuViec;
        private System.Windows.Forms.Label lblDieuKhoan; private System.Windows.Forms.TextBox txtDieuKhoan;

        private System.Windows.Forms.Button btnKyDuyet;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.gbNhanVien = new System.Windows.Forms.GroupBox();
            this.lblMaNV = new System.Windows.Forms.Label(); this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label(); this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label(); this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label(); this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblSDT = new System.Windows.Forms.Label(); this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label(); this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblPhongBan = new System.Windows.Forms.Label(); this.cboPhongBan = new System.Windows.Forms.ComboBox();

            this.gbQuyetDinh = new System.Windows.Forms.GroupBox();
            this.lblSoQD = new System.Windows.Forms.Label(); this.txtSoQD = new System.Windows.Forms.TextBox();
            this.lblNgayQD = new System.Windows.Forms.Label(); this.dtpNgayQD = new System.Windows.Forms.DateTimePicker();
            this.lblBatDau = new System.Windows.Forms.Label(); this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblKetThuc = new System.Windows.Forms.Label(); this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblLuong = new System.Windows.Forms.Label(); this.numLuongThuViec = new System.Windows.Forms.NumericUpDown();
            this.lblDieuKhoan = new System.Windows.Forms.Label(); this.txtDieuKhoan = new System.Windows.Forms.TextBox();

            this.btnKyDuyet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLuongThuViec)).BeginInit();
            this.gbNhanVien.SuspendLayout(); this.gbQuyetDinh.SuspendLayout();
            this.SuspendLayout();

            // gbNhanVien
            this.gbNhanVien.Text = "1. Thông tin Ứng viên mới";
            this.gbNhanVien.Location = new System.Drawing.Point(20, 15); this.gbNhanVien.Size = new System.Drawing.Size(640, 130);

            this.lblMaNV.Text = "Mã Ứng viên:"; this.lblMaNV.Location = new System.Drawing.Point(15, 25); this.lblMaNV.Size = new System.Drawing.Size(80, 20);
            this.txtMaNV.Location = new System.Drawing.Point(100, 25); this.txtMaNV.Size = new System.Drawing.Size(120, 20);

            this.lblHoTen.Text = "Họ tên:"; this.lblHoTen.Location = new System.Drawing.Point(240, 25); this.lblHoTen.Size = new System.Drawing.Size(60, 20);
            this.txtHoTen.Location = new System.Drawing.Point(310, 25); this.txtHoTen.Size = new System.Drawing.Size(150, 20);

            this.lblNgaySinh.Text = "Ngày sinh:"; this.lblNgaySinh.Location = new System.Drawing.Point(475, 25); this.lblNgaySinh.Size = new System.Drawing.Size(60, 20);
            this.dtpNgaySinh.Location = new System.Drawing.Point(535, 25); this.dtpNgaySinh.Size = new System.Drawing.Size(90, 20); this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblGioiTinh.Text = "Giới tính:"; this.lblGioiTinh.Location = new System.Drawing.Point(15, 60); this.lblGioiTinh.Size = new System.Drawing.Size(60, 20);
            this.cboGioiTinh.Location = new System.Drawing.Point(100, 60); this.cboGioiTinh.Size = new System.Drawing.Size(80, 21);
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });

            this.lblSDT.Text = "Điện thoại:"; this.lblSDT.Location = new System.Drawing.Point(240, 60); this.lblSDT.Size = new System.Drawing.Size(65, 20);
            this.txtSDT.Location = new System.Drawing.Point(310, 60); this.txtSDT.Size = new System.Drawing.Size(150, 20);

            this.lblPhongBan.Text = "Phòng ban:"; this.lblPhongBan.Location = new System.Drawing.Point(475, 60); this.lblPhongBan.Size = new System.Drawing.Size(65, 20);
            this.cboPhongBan.Location = new System.Drawing.Point(535, 60); this.cboPhongBan.Size = new System.Drawing.Size(90, 21);
            this.cboPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblDiaChi.Text = "Địa chỉ:"; this.lblDiaChi.Location = new System.Drawing.Point(15, 95); this.lblDiaChi.Size = new System.Drawing.Size(60, 20);
            this.txtDiaChi.Location = new System.Drawing.Point(100, 95); this.txtDiaChi.Size = new System.Drawing.Size(525, 20);

            this.gbNhanVien.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblMaNV, this.txtMaNV, this.lblHoTen, this.txtHoTen, this.lblNgaySinh, this.dtpNgaySinh,
                this.lblGioiTinh, this.cboGioiTinh, this.lblSDT, this.txtSDT, this.lblPhongBan, this.cboPhongBan,
                this.lblDiaChi, this.txtDiaChi
            });

            // gbQuyetDinh
            this.gbQuyetDinh.Text = "2. Quyết định Tuyển dụng & Điều khoản thử việc";
            this.gbQuyetDinh.Location = new System.Drawing.Point(20, 155); this.gbQuyetDinh.Size = new System.Drawing.Size(640, 130);

            this.lblSoQD.Text = "Số Quyết định:"; this.lblSoQD.Location = new System.Drawing.Point(15, 25); this.lblSoQD.Size = new System.Drawing.Size(80, 20);
            this.txtSoQD.Location = new System.Drawing.Point(100, 25); this.txtSoQD.Size = new System.Drawing.Size(120, 20);

            this.lblNgayQD.Text = "Ngày QĐ:"; this.lblNgayQD.Location = new System.Drawing.Point(240, 25); this.lblNgayQD.Size = new System.Drawing.Size(60, 20);
            this.dtpNgayQD.Location = new System.Drawing.Point(310, 25); this.dtpNgayQD.Size = new System.Drawing.Size(110, 20); this.dtpNgayQD.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblLuong.Text = "Lương thử việc:"; this.lblLuong.Location = new System.Drawing.Point(435, 25); this.lblLuong.Size = new System.Drawing.Size(90, 20);
            this.numLuongThuViec.Location = new System.Drawing.Point(525, 25); this.numLuongThuViec.Size = new System.Drawing.Size(100, 20);
            this.numLuongThuViec.Maximum = 1000000000; this.numLuongThuViec.Value = 6000000;

            this.lblBatDau.Text = "Ngày bắt đầu:"; this.lblBatDau.Location = new System.Drawing.Point(15, 60); this.lblBatDau.Size = new System.Drawing.Size(80, 20);
            this.dtpBatDau.Location = new System.Drawing.Point(100, 60); this.dtpBatDau.Size = new System.Drawing.Size(120, 20); this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblKetThuc.Text = "Ngày kết thúc:"; this.lblKetThuc.Location = new System.Drawing.Point(240, 60); this.lblKetThuc.Size = new System.Drawing.Size(80, 20);
            this.dtpKetThuc.Location = new System.Drawing.Point(320, 60); this.dtpKetThuc.Size = new System.Drawing.Size(100, 20); this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblDieuKhoan.Text = "Điều khoản hợp đồng:"; this.lblDieuKhoan.Location = new System.Drawing.Point(15, 95); this.lblDieuKhoan.Size = new System.Drawing.Size(120, 20);
            this.txtDieuKhoan.Location = new System.Drawing.Point(140, 95); this.txtDieuKhoan.Size = new System.Drawing.Size(485, 20);
            this.txtDieuKhoan.Text = "Thử việc 02 tháng, hưởng 85% lương cơ bản theo quy định công ty.";

            this.gbQuyetDinh.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblSoQD, this.txtSoQD, this.lblNgayQD, this.dtpNgayQD, this.lblLuong, this.numLuongThuViec,
                this.lblBatDau, this.dtpBatDau, this.lblKetThuc, this.dtpKetThuc, this.lblDieuKhoan, this.txtDieuKhoan
            });

            // btnKyDuyet
            this.btnKyDuyet.Location = new System.Drawing.Point(220, 300);
            this.btnKyDuyet.Size = new System.Drawing.Size(250, 40);
            this.btnKyDuyet.Text = "GIÁM ĐỐC KÝ DUYỆT (TRANSACTION)";
            this.btnKyDuyet.Click += new System.EventHandler(this.btnKyDuyet_Click);

            this.ClientSize = new System.Drawing.Size(680, 355);
            this.Controls.Add(this.gbNhanVien);
            this.Controls.Add(this.gbQuyetDinh);
            this.Controls.Add(this.btnKyDuyet);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lập Quyết Đinh Tuyển Dụng & Thử Việc";
            ((System.ComponentModel.ISupportInitialize)(this.numLuongThuViec)).EndInit();
            this.gbNhanVien.ResumeLayout(false); this.gbNhanVien.PerformLayout();
            this.gbQuyetDinh.ResumeLayout(false); this.gbQuyetDinh.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
