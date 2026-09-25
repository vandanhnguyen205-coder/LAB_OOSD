namespace QuanLyKhachSan.Forms
{
    partial class FrmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDichVuSuDung = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblSoPhieuDat = new System.Windows.Forms.Label();
            this.lblSoPhieuDangO = new System.Windows.Forms.Label();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.lblTongDenBu = new System.Windows.Forms.Label();
            this.lblDoanhThuHoaDon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVuSuDung)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Từ Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(303, 19);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Đến Ngày ";
            // 
            // button3
            // 
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(599, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 50);
            this.button3.TabIndex = 13;
            this.button3.Text = "Thống Kê";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(46, 226);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Dịch Vụ Sử Dụng ";
            // 
            // dgvDichVuSuDung
            // 
            this.dgvDichVuSuDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVuSuDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Column4});
            this.dgvDichVuSuDung.Location = new System.Drawing.Point(46, 254);
            this.dgvDichVuSuDung.Name = "dgvDichVuSuDung";
            this.dgvDichVuSuDung.RowHeadersWidth = 51;
            this.dgvDichVuSuDung.RowTemplate.Height = 24;
            this.dgvDichVuSuDung.Size = new System.Drawing.Size(552, 172);
            this.dgvDichVuSuDung.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Mã DV";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Tên Dịch Vụ";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Tổng Số Lượng ";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tổng Tiền ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.Location = new System.Drawing.Point(77, 18);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(168, 22);
            this.dtTuNgay.TabIndex = 26;
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.Location = new System.Drawing.Point(379, 18);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(168, 22);
            this.dtDenNgay.TabIndex = 27;
            // 
            // lblSoPhieuDat
            // 
            this.lblSoPhieuDat.AutoSize = true;
            this.lblSoPhieuDat.Location = new System.Drawing.Point(43, 85);
            this.lblSoPhieuDat.Name = "lblSoPhieuDat";
            this.lblSoPhieuDat.Size = new System.Drawing.Size(64, 16);
            this.lblSoPhieuDat.TabIndex = 28;
            this.lblSoPhieuDat.Text = "Phiếu Đặt";
            // 
            // lblSoPhieuDangO
            // 
            this.lblSoPhieuDangO.AutoSize = true;
            this.lblSoPhieuDangO.Location = new System.Drawing.Point(439, 85);
            this.lblSoPhieuDangO.Name = "lblSoPhieuDangO";
            this.lblSoPhieuDangO.Size = new System.Drawing.Size(50, 16);
            this.lblSoPhieuDangO.TabIndex = 29;
            this.lblSoPhieuDangO.Text = "Đang ở";
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Location = new System.Drawing.Point(43, 133);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(60, 16);
            this.lblHoaDon.TabIndex = 30;
            this.lblHoaDon.Text = "Hóa Đơn";
            // 
            // lblTongDenBu
            // 
            this.lblTongDenBu.AutoSize = true;
            this.lblTongDenBu.Location = new System.Drawing.Point(43, 184);
            this.lblTongDenBu.Name = "lblTongDenBu";
            this.lblTongDenBu.Size = new System.Drawing.Size(85, 16);
            this.lblTongDenBu.TabIndex = 31;
            this.lblTongDenBu.Text = "Tổng Đền Bù";
            // 
            // lblDoanhThuHoaDon
            // 
            this.lblDoanhThuHoaDon.AutoSize = true;
            this.lblDoanhThuHoaDon.Location = new System.Drawing.Point(439, 133);
            this.lblDoanhThuHoaDon.Name = "lblDoanhThuHoaDon";
            this.lblDoanhThuHoaDon.Size = new System.Drawing.Size(95, 16);
            this.lblDoanhThuHoaDon.TabIndex = 32;
            this.lblDoanhThuHoaDon.Text = "Doanh Thu HĐ";
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 503);
            this.Controls.Add(this.lblDoanhThuHoaDon);
            this.Controls.Add(this.lblTongDenBu);
            this.Controls.Add(this.lblHoaDon);
            this.Controls.Add(this.lblSoPhieuDangO);
            this.Controls.Add(this.lblSoPhieuDat);
            this.Controls.Add(this.dtDenNgay);
            this.Controls.Add(this.dtTuNgay);
            this.Controls.Add(this.dgvDichVuSuDung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVuSuDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDichVuSuDung;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private System.Windows.Forms.Label lblSoPhieuDat;
        private System.Windows.Forms.Label lblSoPhieuDangO;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblTongDenBu;
        private System.Windows.Forms.Label lblDoanhThuHoaDon;
    }
}