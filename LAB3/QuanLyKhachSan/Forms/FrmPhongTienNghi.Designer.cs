namespace QuanLyKhachSan.Forms
{
    partial class FrmPhongTienNghi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvLapDat;
        private System.Windows.Forms.GroupBox gbLapDat;
        private System.Windows.Forms.Label lblMaTienNghi;
        private System.Windows.Forms.TextBox txtMaTienNghi;
        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnLuuLapDat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvLapDat = new System.Windows.Forms.DataGridView();
            this.gbLapDat = new System.Windows.Forms.GroupBox();
            this.lblMaTienNghi = new System.Windows.Forms.Label();
            this.txtMaTienNghi = new System.Windows.Forms.TextBox();
            this.lblSoPhong = new System.Windows.Forms.Label();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnLuuLapDat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLapDat)).BeginInit();
            this.gbLapDat.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLapDat
            // 
            this.dgvLapDat.AllowUserToAddRows = false;
            this.dgvLapDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLapDat.Location = new System.Drawing.Point(12, 12);
            this.dgvLapDat.Name = "dgvLapDat";
            this.dgvLapDat.ReadOnly = true;
            this.dgvLapDat.Size = new System.Drawing.Size(430, 340);
            this.dgvLapDat.TabIndex = 0;
            // 
            // gbLapDat
            // 
            this.gbLapDat.Controls.Add(this.btnLuuLapDat);
            this.gbLapDat.Controls.Add(this.txtGhiChu);
            this.gbLapDat.Controls.Add(this.lblGhiChu);
            this.gbLapDat.Controls.Add(this.txtTinhTrang);
            this.gbLapDat.Controls.Add(this.lblTinhTrang);
            this.gbLapDat.Controls.Add(this.dtpNgayLap);
            this.gbLapDat.Controls.Add(this.lblNgayLap);
            this.gbLapDat.Controls.Add(this.txtSoPhong);
            this.gbLapDat.Controls.Add(this.lblSoPhong);
            this.gbLapDat.Controls.Add(this.txtMaTienNghi);
            this.gbLapDat.Controls.Add(this.lblMaTienNghi);
            this.gbLapDat.Location = new System.Drawing.Point(455, 12);
            this.gbLapDat.Name = "gbLapDat";
            this.gbLapDat.Size = new System.Drawing.Size(300, 340);
            this.gbLapDat.TabIndex = 1;
            this.gbLapDat.TabStop = false;
            this.gbLapDat.Text = "Lắp Đặt Tiện Nghi Vào Phòng";
            // 
            // lblMaTienNghi
            // 
            this.lblMaTienNghi.Location = new System.Drawing.Point(15, 30);
            this.lblMaTienNghi.Name = "lblMaTienNghi";
            this.lblMaTienNghi.Size = new System.Drawing.Size(80, 20);
            this.lblMaTienNghi.Text = "Mã Tiện Nghi:";
            // 
            // txtMaTienNghi
            // 
            this.txtMaTienNghi.Location = new System.Drawing.Point(100, 27);
            this.txtMaTienNghi.Name = "txtMaTienNghi";
            this.txtMaTienNghi.Size = new System.Drawing.Size(180, 20);
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.Location = new System.Drawing.Point(15, 70);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(80, 20);
            this.lblSoPhong.Text = "Số Phòng:";
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(100, 67);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(180, 20);
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.Location = new System.Drawing.Point(15, 110);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(80, 20);
            this.lblNgayLap.Text = "Ngày Lắp:";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(100, 107);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(180, 20);
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.Location = new System.Drawing.Point(15, 150);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(80, 20);
            this.lblTinhTrang.Text = "Tình Trạng:";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(100, 147);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(180, 20);
            this.txtTinhTrang.Text = "Mới 100%";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Location = new System.Drawing.Point(15, 190);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(80, 20);
            this.lblGhiChu.Text = "Ghi Chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(100, 187);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(180, 60);
            // 
            // btnLuuLapDat
            // 
            this.btnLuuLapDat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLuuLapDat.Location = new System.Drawing.Point(60, 275);
            this.btnLuuLapDat.Name = "btnLuuLapDat";
            this.btnLuuLapDat.Size = new System.Drawing.Size(180, 45);
            this.btnLuuLapDat.TabIndex = 10;
            this.btnLuuLapDat.Text = "LƯU PHIẾU LẮP ĐẶT";
            this.btnLuuLapDat.Click += new System.EventHandler(this.btnLuuLapDat_Click);
            // 
            // FrmPhongTienNghi
            // 
            this.ClientSize = new System.Drawing.Size(770, 365);
            this.Controls.Add(this.gbLapDat);
            this.Controls.Add(this.dgvLapDat);
            this.Name = "FrmPhongTienNghi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lắp Đặt Tiện Nghi Cho Phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLapDat)).EndInit();
            this.gbLapDat.ResumeLayout(false);
            this.gbLapDat.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
