namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmHopDongThue
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblSoHD = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.lblMaKhach = new System.Windows.Forms.Label();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.lblPhongTrong = new System.Windows.Forms.Label();
            this.cboPhongTrong = new System.Windows.Forms.ComboBox();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.numThoiGian = new System.Windows.Forms.NumericUpDown();
            this.lblDienTich = new System.Windows.Forms.Label();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btnLapHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiGian)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSoHD
            // 
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.Location = new System.Drawing.Point(30, 30);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Size = new System.Drawing.Size(76, 13);
            this.lblSoHD.TabIndex = 0;
            this.lblSoHD.Text = "Số Hợp Đồng:";
            // 
            // txtSoHD
            // 
            this.txtSoHD.Location = new System.Drawing.Point(160, 27);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(260, 20);
            this.txtSoHD.TabIndex = 1;
            // 
            // lblMaKhach
            // 
            this.lblMaKhach.AutoSize = true;
            this.lblMaKhach.Location = new System.Drawing.Point(30, 70);
            this.lblMaKhach.Name = "lblMaKhach";
            this.lblMaKhach.Size = new System.Drawing.Size(88, 13);
            this.lblMaKhach.TabIndex = 2;
            this.lblMaKhach.Text = "Mã Khách Hàng:";
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(160, 67);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(260, 20);
            this.txtMaKhach.TabIndex = 3;
            // 
            // lblPhongTrong
            // 
            this.lblPhongTrong.AutoSize = true;
            this.lblPhongTrong.Location = new System.Drawing.Point(30, 110);
            this.lblPhongTrong.Name = "lblPhongTrong";
            this.lblPhongTrong.Size = new System.Drawing.Size(102, 13);
            this.lblPhongTrong.TabIndex = 4;
            this.lblPhongTrong.Text = "Chọn Phòng Trống:";
            // 
            // cboPhongTrong
            // 
            this.cboPhongTrong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongTrong.FormattingEnabled = true;
            this.cboPhongTrong.Location = new System.Drawing.Point(160, 107);
            this.cboPhongTrong.Name = "cboPhongTrong";
            this.cboPhongTrong.Size = new System.Drawing.Size(260, 21);
            this.cboPhongTrong.TabIndex = 5;
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.AutoSize = true;
            this.lblNgayBD.Location = new System.Drawing.Point(30, 150);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(75, 13);
            this.lblNgayBD.TabIndex = 6;
            this.lblNgayBD.Text = "Ngày Bắt Đầu:";
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBD.Location = new System.Drawing.Point(160, 147);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(260, 20);
            this.dtpNgayBD.TabIndex = 7;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Location = new System.Drawing.Point(30, 190);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(121, 13);
            this.lblThoiGian.TabIndex = 8;
            this.lblThoiGian.Text = "Thời gian thuê (Tháng):";
            // 
            // numThoiGian
            // 
            this.numThoiGian.Location = new System.Drawing.Point(160, 187);
            this.numThoiGian.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            this.numThoiGian.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numThoiGian.Name = "numThoiGian";
            this.numThoiGian.Size = new System.Drawing.Size(260, 20);
            this.numThoiGian.TabIndex = 9;
            this.numThoiGian.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // lblDienTich
            // 
            this.lblDienTich.AutoSize = true;
            this.lblDienTich.Location = new System.Drawing.Point(30, 230);
            this.lblDienTich.Name = "lblDienTich";
            this.lblDienTich.Size = new System.Drawing.Size(78, 13);
            this.lblDienTich.TabIndex = 10;
            this.lblDienTich.Text = "Diện tích (m2):";
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(160, 227);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(260, 20);
            this.txtDienTich.TabIndex = 11;
            this.txtDienTich.Text = "50";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(30, 270);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(70, 13);
            this.lblDonGia.TabIndex = 12;
            this.lblDonGia.Text = "Đơn giá/m2:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(160, 267);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(260, 20);
            this.txtDonGia.TabIndex = 13;
            this.txtDonGia.Text = "300000";
            // 
            // btnLapHD
            // 
            this.btnLapHD.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLapHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnLapHD.Location = new System.Drawing.Point(160, 310);
            this.btnLapHD.Name = "btnLapHD";
            this.btnLapHD.Size = new System.Drawing.Size(260, 40);
            this.btnLapHD.TabIndex = 14;
            this.btnLapHD.Text = "Lập Hợp Đồng (Transaction)";
            this.btnLapHD.UseVisualStyleBackColor = false;
            this.btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);
            // 
            // FrmHopDongThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 381);
            this.Controls.Add(this.btnLapHD);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.lblDienTich);
            this.Controls.Add(this.numThoiGian);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.lblNgayBD);
            this.Controls.Add(this.cboPhongTrong);
            this.Controls.Add(this.lblPhongTrong);
            this.Controls.Add(this.txtMaKhach);
            this.Controls.Add(this.lblMaKhach);
            this.Controls.Add(this.txtSoHD);
            this.Controls.Add(this.lblSoHD);
            this.Name = "FrmHopDongThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Hợp Đồng Cho Thuê Văn Phòng";
            ((System.ComponentModel.ISupportInitialize)(this.numThoiGian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoHD;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label lblMaKhach;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.Label lblPhongTrong;
        private System.Windows.Forms.ComboBox cboPhongTrong;
        private System.Windows.Forms.Label lblNgayBD;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.NumericUpDown numThoiGian;
        private System.Windows.Forms.Label lblDienTich;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btnLapHD;
    }
}
