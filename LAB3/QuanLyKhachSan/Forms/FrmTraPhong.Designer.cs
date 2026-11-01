namespace QuanLyKhachSan.Forms
{
    partial class FrmTraPhong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSoPhieuDat;
        private System.Windows.Forms.TextBox txtSoPhieuDat;
        private System.Windows.Forms.Label lblSoNgay;
        private System.Windows.Forms.NumericUpDown nudSoNgay;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label lblTienPhong;
        private System.Windows.Forms.TextBox txtTienPhong;
        private System.Windows.Forms.Label lblTienDV;
        private System.Windows.Forms.TextBox txtTienDV;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.ComboBox cboHinhThuc;
        private System.Windows.Forms.Button btnThanhToan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSoPhieuDat = new System.Windows.Forms.Label();
            this.txtSoPhieuDat = new System.Windows.Forms.TextBox();
            this.lblSoNgay = new System.Windows.Forms.Label();
            this.nudSoNgay = new System.Windows.Forms.NumericUpDown();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.lblTienPhong = new System.Windows.Forms.Label();
            this.txtTienPhong = new System.Windows.Forms.TextBox();
            this.lblTienDV = new System.Windows.Forms.Label();
            this.txtTienDV = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.cboHinhThuc = new System.Windows.Forms.ComboBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSoPhieuDat
            // 
            this.lblSoPhieuDat.Location = new System.Drawing.Point(30, 30);
            this.lblSoPhieuDat.Name = "lblSoPhieuDat";
            this.lblSoPhieuDat.Size = new System.Drawing.Size(100, 20);
            this.lblSoPhieuDat.Text = "Số Phiếu Đặt:";
            // 
            // txtSoPhieuDat
            // 
            this.txtSoPhieuDat.Location = new System.Drawing.Point(140, 27);
            this.txtSoPhieuDat.Name = "txtSoPhieuDat";
            this.txtSoPhieuDat.Size = new System.Drawing.Size(180, 20);
            // 
            // lblSoNgay
            // 
            this.lblSoNgay.Location = new System.Drawing.Point(30, 70);
            this.lblSoNgay.Name = "lblSoNgay";
            this.lblSoNgay.Size = new System.Drawing.Size(100, 20);
            this.lblSoNgay.Text = "Số Ngày Tính:";
            // 
            // nudSoNgay
            // 
            this.nudSoNgay.Location = new System.Drawing.Point(140, 68);
            this.nudSoNgay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoNgay.Name = "nudSoNgay";
            this.nudSoNgay.Size = new System.Drawing.Size(80, 20);
            this.nudSoNgay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(240, 65);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(80, 25);
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // lblTienPhong
            // 
            this.lblTienPhong.Location = new System.Drawing.Point(30, 120);
            this.lblTienPhong.Name = "lblTienPhong";
            this.lblTienPhong.Size = new System.Drawing.Size(100, 20);
            this.lblTienPhong.Text = "Tiền Phòng:";
            // 
            // txtTienPhong
            // 
            this.txtTienPhong.Location = new System.Drawing.Point(140, 117);
            this.txtTienPhong.Name = "txtTienPhong";
            this.txtTienPhong.ReadOnly = true;
            this.txtTienPhong.Size = new System.Drawing.Size(180, 20);
            // 
            // lblTienDV
            // 
            this.lblTienDV.Location = new System.Drawing.Point(30, 160);
            this.lblTienDV.Name = "lblTienDV";
            this.lblTienDV.Size = new System.Drawing.Size(100, 20);
            this.lblTienDV.Text = "Tiền Dịch Vụ:";
            // 
            // txtTienDV
            // 
            this.txtTienDV.Location = new System.Drawing.Point(140, 157);
            this.txtTienDV.Name = "txtTienDV";
            this.txtTienDV.ReadOnly = true;
            this.txtTienDV.Size = new System.Drawing.Size(180, 20);
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.Location = new System.Drawing.Point(30, 200);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(100, 20);
            this.lblTongTien.Text = "TỔNG TIỀN:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(140, 197);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(180, 25);
            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.Location = new System.Drawing.Point(30, 245);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(100, 20);
            this.lblHinhThuc.Text = "Hình Thức TT:";
            // 
            // cboHinhThuc
            // 
            this.cboHinhThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThuc.FormattingEnabled = true;
            this.cboHinhThuc.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản",
            "Thẻ",
            "Ví điện tử"});
            this.cboHinhThuc.Location = new System.Drawing.Point(140, 242);
            this.cboHinhThuc.Name = "cboHinhThuc";
            this.cboHinhThuc.Size = new System.Drawing.Size(180, 21);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.Location = new System.Drawing.Point(80, 300);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(200, 45);
            this.btnThanhToan.TabIndex = 8;
            this.btnThanhToan.Text = "THANH TOÁN & TRẢ PHÒNG";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // FrmTraPhong
            // 
            this.ClientSize = new System.Drawing.Size(360, 370);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.cboHinhThuc);
            this.Controls.Add(this.lblHinhThuc);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.txtTienDV);
            this.Controls.Add(this.lblTienDV);
            this.Controls.Add(this.txtTienPhong);
            this.Controls.Add(this.lblTienPhong);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.nudSoNgay);
            this.Controls.Add(this.lblSoNgay);
            this.Controls.Add(this.txtSoPhieuDat);
            this.Controls.Add(this.lblSoPhieuDat);
            this.Name = "FrmTraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trả Phòng & Thanh Toán";
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNgay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
