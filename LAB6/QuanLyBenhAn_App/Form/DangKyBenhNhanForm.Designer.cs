namespace QuanLyBenhAn
{
    partial class DangKyBenhNhanForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label lblMaBN;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblLePhi;
        private System.Windows.Forms.TextBox txtLePhi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;

        private void InitializeComponent()
        {
            this.lblMaBN = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblLePhi = new System.Windows.Forms.Label();
            this.txtLePhi = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblMaBN
            //
            this.lblMaBN.Location = new System.Drawing.Point(20, 20);
            this.lblMaBN.Name = "lblMaBN";
            this.lblMaBN.Size = new System.Drawing.Size(100, 20);
            this.lblMaBN.Text = "Mã BN:";
            //
            // txtMaBN
            //
            this.txtMaBN.Location = new System.Drawing.Point(130, 20);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(200, 24);
            //
            // lblHoTen
            //
            this.lblHoTen.Location = new System.Drawing.Point(20, 55);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(100, 20);
            this.lblHoTen.Text = "Họ tên:";
            //
            // txtHoTen
            //
            this.txtHoTen.Location = new System.Drawing.Point(130, 55);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 24);
            //
            // lblNgaySinh
            //
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 90);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.lblNgaySinh.Text = "Ngày sinh (yyyy-MM-dd):";
            //
            // txtNgaySinh
            //
            this.txtNgaySinh.Location = new System.Drawing.Point(130, 90);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(200, 24);
            //
            // lblGioiTinh
            //
            this.lblGioiTinh.Location = new System.Drawing.Point(20, 125);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(100, 20);
            this.lblGioiTinh.Text = "Giới tính:";
            //
            // cboGioiTinh
            //
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            this.cboGioiTinh.Location = new System.Drawing.Point(130, 125);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(200, 24);
            //
            // lblSoDienThoai
            //
            this.lblSoDienThoai.Location = new System.Drawing.Point(20, 160);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(100, 20);
            this.lblSoDienThoai.Text = "SĐT:";
            //
            // txtSoDienThoai
            //
            this.txtSoDienThoai.Location = new System.Drawing.Point(130, 160);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(200, 24);
            //
            // lblDiaChi
            //
            this.lblDiaChi.Location = new System.Drawing.Point(20, 195);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(100, 20);
            this.lblDiaChi.Text = "Địa chỉ:";
            //
            // txtDiaChi
            //
            this.txtDiaChi.Location = new System.Drawing.Point(130, 195);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 24);
            //
            // lblLePhi
            //
            this.lblLePhi.Location = new System.Drawing.Point(20, 230);
            this.lblLePhi.Name = "lblLePhi";
            this.lblLePhi.Size = new System.Drawing.Size(100, 20);
            this.lblLePhi.Text = "Lệ phí đóng:";
            //
            // txtLePhi
            //
            this.txtLePhi.Location = new System.Drawing.Point(130, 230);
            this.txtLePhi.Name = "txtLePhi";
            this.txtLePhi.Size = new System.Drawing.Size(200, 24);
            //
            // btnLuu
            //
            this.btnLuu.Location = new System.Drawing.Point(130, 280);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 36);
            this.btnLuu.Text = "Lưu / Cấp hồ sơ";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            //
            // btnDong
            //
            this.btnDong.Location = new System.Drawing.Point(290, 280);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(80, 36);
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            //
            // DangKyBenhNhanForm
            //
            this.ClientSize = new System.Drawing.Size(420, 380);
            this.Controls.Add(this.lblMaBN);
            this.Controls.Add(this.txtMaBN);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.lblSoDienThoai);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblLePhi);
            this.Controls.Add(this.txtLePhi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnDong);
            this.Name = "DangKyBenhNhanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký bệnh nhân / Cấp hồ sơ";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
