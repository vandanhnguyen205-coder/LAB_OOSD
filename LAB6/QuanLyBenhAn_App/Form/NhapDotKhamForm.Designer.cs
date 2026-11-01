namespace QuanLyBenhAn
{
    partial class NhapDotKhamForm
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

        private System.Windows.Forms.Label lblMaHoSo;
        private System.Windows.Forms.TextBox txtMaHoSo;
        private System.Windows.Forms.Label lblMaBacSi;
        private System.Windows.Forms.TextBox txtMaBacSi;
        private System.Windows.Forms.Label lblMaPhongBan;
        private System.Windows.Forms.TextBox txtMaPhongBan;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblLoaiKham;
        private System.Windows.Forms.ComboBox cboLoaiKham;
        private System.Windows.Forms.Label lblTrieuChung;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Label lblDienBien;
        private System.Windows.Forms.TextBox txtDienBien;
        private System.Windows.Forms.Label lblHieuQua;
        private System.Windows.Forms.TextBox txtHieuQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;

        private void InitializeComponent()
        {
            this.lblMaHoSo = new System.Windows.Forms.Label();
            this.txtMaHoSo = new System.Windows.Forms.TextBox();
            this.lblMaBacSi = new System.Windows.Forms.Label();
            this.txtMaBacSi = new System.Windows.Forms.TextBox();
            this.lblMaPhongBan = new System.Windows.Forms.Label();
            this.txtMaPhongBan = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblLoaiKham = new System.Windows.Forms.Label();
            this.cboLoaiKham = new System.Windows.Forms.ComboBox();
            this.lblTrieuChung = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.lblDienBien = new System.Windows.Forms.Label();
            this.txtDienBien = new System.Windows.Forms.TextBox();
            this.lblHieuQua = new System.Windows.Forms.Label();
            this.txtHieuQua = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblMaHoSo
            //
            this.lblMaHoSo.Location = new System.Drawing.Point(20, 20);
            this.lblMaHoSo.Name = "lblMaHoSo";
            this.lblMaHoSo.Size = new System.Drawing.Size(130, 20);
            this.lblMaHoSo.Text = "Mã hồ sơ:";
            //
            // txtMaHoSo
            //
            this.txtMaHoSo.Location = new System.Drawing.Point(160, 20);
            this.txtMaHoSo.Name = "txtMaHoSo";
            this.txtMaHoSo.Size = new System.Drawing.Size(230, 24);
            //
            // lblMaBacSi
            //
            this.lblMaBacSi.Location = new System.Drawing.Point(20, 55);
            this.lblMaBacSi.Name = "lblMaBacSi";
            this.lblMaBacSi.Size = new System.Drawing.Size(130, 20);
            this.lblMaBacSi.Text = "Mã bác sĩ:";
            //
            // txtMaBacSi
            //
            this.txtMaBacSi.Location = new System.Drawing.Point(160, 55);
            this.txtMaBacSi.Name = "txtMaBacSi";
            this.txtMaBacSi.Size = new System.Drawing.Size(230, 24);
            //
            // lblMaPhongBan
            //
            this.lblMaPhongBan.Location = new System.Drawing.Point(20, 90);
            this.lblMaPhongBan.Name = "lblMaPhongBan";
            this.lblMaPhongBan.Size = new System.Drawing.Size(130, 20);
            this.lblMaPhongBan.Text = "Mã phòng ban:";
            //
            // txtMaPhongBan
            //
            this.txtMaPhongBan.Location = new System.Drawing.Point(160, 90);
            this.txtMaPhongBan.Name = "txtMaPhongBan";
            this.txtMaPhongBan.Size = new System.Drawing.Size(230, 24);
            //
            // lblMaNV
            //
            this.lblMaNV.Location = new System.Drawing.Point(20, 125);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(130, 20);
            this.lblMaNV.Text = "Mã nhân viên:";
            //
            // txtMaNV
            //
            this.txtMaNV.Location = new System.Drawing.Point(160, 125);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(230, 24);
            //
            // lblLoaiKham
            //
            this.lblLoaiKham.Location = new System.Drawing.Point(20, 160);
            this.lblLoaiKham.Name = "lblLoaiKham";
            this.lblLoaiKham.Size = new System.Drawing.Size(130, 20);
            this.lblLoaiKham.Text = "Loại khám:";
            //
            // cboLoaiKham
            //
            this.cboLoaiKham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiKham.Items.AddRange(new object[] { "Dieu tri", "Dinh ky" });
            this.cboLoaiKham.Location = new System.Drawing.Point(160, 160);
            this.cboLoaiKham.Name = "cboLoaiKham";
            this.cboLoaiKham.Size = new System.Drawing.Size(200, 24);
            //
            // lblTrieuChung
            //
            this.lblTrieuChung.Location = new System.Drawing.Point(20, 195);
            this.lblTrieuChung.Name = "lblTrieuChung";
            this.lblTrieuChung.Size = new System.Drawing.Size(130, 20);
            this.lblTrieuChung.Text = "Triệu chứng:";
            //
            // txtTrieuChung
            //
            this.txtTrieuChung.Location = new System.Drawing.Point(160, 195);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(230, 24);
            //
            // lblDienBien
            //
            this.lblDienBien.Location = new System.Drawing.Point(20, 230);
            this.lblDienBien.Name = "lblDienBien";
            this.lblDienBien.Size = new System.Drawing.Size(130, 20);
            this.lblDienBien.Text = "Diễn biến bệnh:";
            //
            // txtDienBien
            //
            this.txtDienBien.Location = new System.Drawing.Point(160, 230);
            this.txtDienBien.Name = "txtDienBien";
            this.txtDienBien.Size = new System.Drawing.Size(230, 24);
            //
            // lblHieuQua
            //
            this.lblHieuQua.Location = new System.Drawing.Point(20, 265);
            this.lblHieuQua.Name = "lblHieuQua";
            this.lblHieuQua.Size = new System.Drawing.Size(130, 20);
            this.lblHieuQua.Text = "Hiệu quả điều trị:";
            //
            // txtHieuQua
            //
            this.txtHieuQua.Location = new System.Drawing.Point(160, 265);
            this.txtHieuQua.Name = "txtHieuQua";
            this.txtHieuQua.Size = new System.Drawing.Size(230, 24);
            //
            // btnLuu
            //
            this.btnLuu.Location = new System.Drawing.Point(160, 320);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 36);
            this.btnLuu.Text = "Lưu đợt khám";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            //
            // btnDong
            //
            this.btnDong.Location = new System.Drawing.Point(320, 320);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(80, 36);
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            //
            // NhapDotKhamForm
            //
            this.ClientSize = new System.Drawing.Size(460, 400);
            this.Controls.Add(this.lblMaHoSo);
            this.Controls.Add(this.txtMaHoSo);
            this.Controls.Add(this.lblMaBacSi);
            this.Controls.Add(this.txtMaBacSi);
            this.Controls.Add(this.lblMaPhongBan);
            this.Controls.Add(this.txtMaPhongBan);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lblLoaiKham);
            this.Controls.Add(this.cboLoaiKham);
            this.Controls.Add(this.lblTrieuChung);
            this.Controls.Add(this.txtTrieuChung);
            this.Controls.Add(this.lblDienBien);
            this.Controls.Add(this.txtDienBien);
            this.Controls.Add(this.lblHieuQua);
            this.Controls.Add(this.txtHieuQua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnDong);
            this.Name = "NhapDotKhamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập thông tin đợt khám";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
