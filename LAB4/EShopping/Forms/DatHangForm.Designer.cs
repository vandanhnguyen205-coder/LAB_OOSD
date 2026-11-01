namespace eShopping.Forms
{
    partial class DatHangForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox gbNguoiNhan;
        private System.Windows.Forms.Label lblTenNN; private System.Windows.Forms.TextBox txtTenNguoiNhan;
        private System.Windows.Forms.Label lblDiaChiNN; private System.Windows.Forms.TextBox txtDiaChiNguoiNhan;
        private System.Windows.Forms.Label lblSDTNN; private System.Windows.Forms.TextBox txtSDTNguoiNhan;

        private System.Windows.Forms.GroupBox gbGiaoHang;
        private System.Windows.Forms.Label lblPhieu; private System.Windows.Forms.ComboBox cboLoaiPhieu;
        private System.Windows.Forms.Label lblKV; private System.Windows.Forms.ComboBox cboKhuVuc;

        private System.Windows.Forms.GroupBox gbThanhToan;
        private System.Windows.Forms.Label lblLoaiThe; private System.Windows.Forms.ComboBox cboLoaiThe;
        private System.Windows.Forms.Label lblSoThe; private System.Windows.Forms.TextBox txtSoThe;
        private System.Windows.Forms.Label lblTenChuThe; private System.Windows.Forms.TextBox txtTenChuThe;
        private System.Windows.Forms.Label lblNgayHH; private System.Windows.Forms.DateTimePicker dtpNgayHH;
        private System.Windows.Forms.Label lblCSV; private System.Windows.Forms.TextBox txtCSV;

        private System.Windows.Forms.Label lblTamTinh;
        private System.Windows.Forms.Label lblPhiGiao;
        private System.Windows.Forms.Label lblLePhiThe;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnXacNhanDat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.gbNguoiNhan = new System.Windows.Forms.GroupBox();
            this.lblTenNN = new System.Windows.Forms.Label(); this.txtTenNguoiNhan = new System.Windows.Forms.TextBox();
            this.lblDiaChiNN = new System.Windows.Forms.Label(); this.txtDiaChiNguoiNhan = new System.Windows.Forms.TextBox();
            this.lblSDTNN = new System.Windows.Forms.Label(); this.txtSDTNguoiNhan = new System.Windows.Forms.TextBox();

            this.gbGiaoHang = new System.Windows.Forms.GroupBox();
            this.lblPhieu = new System.Windows.Forms.Label(); this.cboLoaiPhieu = new System.Windows.Forms.ComboBox();
            this.lblKV = new System.Windows.Forms.Label(); this.cboKhuVuc = new System.Windows.Forms.ComboBox();

            this.gbThanhToan = new System.Windows.Forms.GroupBox();
            this.lblLoaiThe = new System.Windows.Forms.Label(); this.cboLoaiThe = new System.Windows.Forms.ComboBox();
            this.lblSoThe = new System.Windows.Forms.Label(); this.txtSoThe = new System.Windows.Forms.TextBox();
            this.lblTenChuThe = new System.Windows.Forms.Label(); this.txtTenChuThe = new System.Windows.Forms.TextBox();
            this.lblNgayHH = new System.Windows.Forms.Label(); this.dtpNgayHH = new System.Windows.Forms.DateTimePicker();
            this.lblCSV = new System.Windows.Forms.Label(); this.txtCSV = new System.Windows.Forms.TextBox();

            this.lblTamTinh = new System.Windows.Forms.Label();
            this.lblPhiGiao = new System.Windows.Forms.Label();
            this.lblLePhiThe = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnXacNhanDat = new System.Windows.Forms.Button();

            this.gbNguoiNhan.SuspendLayout(); this.gbGiaoHang.SuspendLayout(); this.gbThanhToan.SuspendLayout();
            this.SuspendLayout();

            // gbNguoiNhan
            this.gbNguoiNhan.Text = "1. Thông Tin Người Nhận";
            this.gbNguoiNhan.Location = new System.Drawing.Point(12, 12);
            this.gbNguoiNhan.Size = new System.Drawing.Size(360, 130);
            this.lblTenNN.Text = "Họ tên:"; this.lblTenNN.Location = new System.Drawing.Point(15, 25);
            this.txtTenNguoiNhan.Location = new System.Drawing.Point(100, 22); this.txtTenNguoiNhan.Size = new System.Drawing.Size(240, 20);
            this.lblDiaChiNN.Text = "Địa chỉ:"; this.lblDiaChiNN.Location = new System.Drawing.Point(15, 60);
            this.txtDiaChiNguoiNhan.Location = new System.Drawing.Point(100, 57); this.txtDiaChiNguoiNhan.Size = new System.Drawing.Size(240, 20);
            this.lblSDTNN.Text = "Điện thoại:"; this.lblSDTNN.Location = new System.Drawing.Point(15, 95);
            this.txtSDTNguoiNhan.Location = new System.Drawing.Point(100, 92); this.txtSDTNguoiNhan.Size = new System.Drawing.Size(240, 20);
            this.gbNguoiNhan.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTenNN, this.txtTenNguoiNhan, this.lblDiaChiNN, this.txtDiaChiNguoiNhan, this.lblSDTNN, this.txtSDTNguoiNhan });

            // gbGiaoHang
            this.gbGiaoHang.Text = "2. Loại Phiếu & Khu Vực";
            this.gbGiaoHang.Location = new System.Drawing.Point(390, 12);
            this.gbGiaoHang.Size = new System.Drawing.Size(360, 130);
            this.lblPhieu.Text = "Loại phiếu:"; this.lblPhieu.Location = new System.Drawing.Point(15, 30);
            this.cboLoaiPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cboLoaiPhieu.Location = new System.Drawing.Point(100, 27); this.cboLoaiPhieu.Size = new System.Drawing.Size(240, 21); this.cboLoaiPhieu.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectedIndexChanged);
            this.lblKV.Text = "Khu vực giao:"; this.lblKV.Location = new System.Drawing.Point(15, 75);
            this.cboKhuVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cboKhuVuc.Location = new System.Drawing.Point(100, 72); this.cboKhuVuc.Size = new System.Drawing.Size(240, 21); this.cboKhuVuc.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectedIndexChanged);
            this.gbGiaoHang.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblPhieu, this.cboLoaiPhieu, this.lblKV, this.cboKhuVuc });

            // gbThanhToan
            this.gbThanhToan.Text = "3. Thẻ Tín Dụng Thanh Toán";
            this.gbThanhToan.Location = new System.Drawing.Point(12, 155);
            this.gbThanhToan.Size = new System.Drawing.Size(738, 140);
            this.lblLoaiThe.Text = "Loại thẻ:"; this.lblLoaiThe.Location = new System.Drawing.Point(15, 30);
            this.cboLoaiThe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cboLoaiThe.Location = new System.Drawing.Point(100, 27); this.cboLoaiThe.Size = new System.Drawing.Size(240, 21); this.cboLoaiThe.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectedIndexChanged);
            this.lblSoThe.Text = "Số thẻ:"; this.lblSoThe.Location = new System.Drawing.Point(380, 30);
            this.txtSoThe.Location = new System.Drawing.Point(470, 27); this.txtSoThe.Size = new System.Drawing.Size(240, 20);
            this.lblTenChuThe.Text = "Tên chủ thẻ:"; this.lblTenChuThe.Location = new System.Drawing.Point(15, 65);
            this.txtTenChuThe.Location = new System.Drawing.Point(100, 62); this.txtTenChuThe.Size = new System.Drawing.Size(240, 20);
            this.lblNgayHH.Text = "Ngày hết hạn:"; this.lblNgayHH.Location = new System.Drawing.Point(380, 65);
            this.dtpNgayHH.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpNgayHH.Location = new System.Drawing.Point(470, 62); this.dtpNgayHH.Size = new System.Drawing.Size(120, 20);
            this.lblCSV.Text = "Mã CSV:"; this.lblCSV.Location = new System.Drawing.Point(15, 100);
            this.txtCSV.Location = new System.Drawing.Point(100, 97); this.txtCSV.Size = new System.Drawing.Size(80, 20);
            this.gbThanhToan.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblLoaiThe, this.cboLoaiThe, this.lblSoThe, this.txtSoThe, this.lblTenChuThe, this.txtTenChuThe, this.lblNgayHH, this.dtpNgayHH, this.lblCSV, this.txtCSV });

            // Tổng hợp
            this.lblTamTinh.Location = new System.Drawing.Point(20, 310); this.lblTamTinh.Size = new System.Drawing.Size(240, 20);
            this.lblPhiGiao.Location = new System.Drawing.Point(260, 310); this.lblPhiGiao.Size = new System.Drawing.Size(240, 20);
            this.lblLePhiThe.Location = new System.Drawing.Point(500, 310); this.lblLePhiThe.Size = new System.Drawing.Size(240, 20);

            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(20, 345); this.lblTongTien.Size = new System.Drawing.Size(450, 30);

            this.btnXacNhanDat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXacNhanDat.Location = new System.Drawing.Point(510, 340);
            this.btnXacNhanDat.Size = new System.Drawing.Size(240, 45);
            this.btnXacNhanDat.Text = "XÁC NHẬN ĐẶT HÀNG";
            this.btnXacNhanDat.Click += new System.EventHandler(this.btnXacNhanDat_Click);

            this.ClientSize = new System.Drawing.Size(764, 400);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.gbNguoiNhan, this.gbGiaoHang, this.gbThanhToan, this.lblTamTinh, this.lblPhiGiao, this.lblLePhiThe, this.lblTongTien, this.btnXacNhanDat });
            this.Name = "DatHangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đặt Hàng & Tính Tiền";
            this.gbNguoiNhan.ResumeLayout(false); this.gbNguoiNhan.PerformLayout();
            this.gbGiaoHang.ResumeLayout(false);
            this.gbThanhToan.ResumeLayout(false); this.gbThanhToan.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
