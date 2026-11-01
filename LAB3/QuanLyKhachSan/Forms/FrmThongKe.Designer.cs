namespace QuanLyKhachSan.Forms
{
    partial class FrmThongKe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnXemThongKe;
        private System.Windows.Forms.TabControl tabThongKe;
        private System.Windows.Forms.TabPage tabDoanhThu;
        private System.Windows.Forms.TabPage tabDV;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.DataGridView dgvTanSuatDV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnXemThongKe = new System.Windows.Forms.Button();
            this.tabThongKe = new System.Windows.Forms.TabControl();
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.tabDV = new System.Windows.Forms.TabPage();
            this.dgvTanSuatDV = new System.Windows.Forms.DataGridView();
            this.pnlFilter.SuspendLayout();
            this.tabThongKe.SuspendLayout();
            this.tabDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.tabDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTanSuatDV)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.btnXemThongKe);
            this.pnlFilter.Controls.Add(this.dtpDenNgay);
            this.pnlFilter.Controls.Add(this.lblDenNgay);
            this.pnlFilter.Controls.Add(this.dtpTuNgay);
            this.pnlFilter.Controls.Add(this.lblTuNgay);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(780, 60);
            this.pnlFilter.TabIndex = 0;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.Location = new System.Drawing.Point(20, 20);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(60, 20);
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(85, 17);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(120, 20);
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.Location = new System.Drawing.Point(235, 20);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(60, 20);
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(300, 17);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(120, 20);
            // 
            // btnXemThongKe
            // 
            this.btnXemThongKe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXemThongKe.Location = new System.Drawing.Point(460, 12);
            this.btnXemThongKe.Name = "btnXemThongKe";
            this.btnXemThongKe.Size = new System.Drawing.Size(140, 32);
            this.btnXemThongKe.TabIndex = 4;
            this.btnXemThongKe.Text = "Xem Thống Kê";
            this.btnXemThongKe.Click += new System.EventHandler(this.btnXemThongKe_Click);
            // 
            // tabThongKe
            // 
            this.tabThongKe.Controls.Add(this.tabDoanhThu);
            this.tabThongKe.Controls.Add(this.tabDV);
            this.tabThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabThongKe.Location = new System.Drawing.Point(0, 60);
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.SelectedIndex = 0;
            this.tabThongKe.Size = new System.Drawing.Size(780, 360);
            this.tabThongKe.TabIndex = 1;
            // 
            // tabDoanhThu
            // 
            this.tabDoanhThu.Controls.Add(this.dgvDoanhThu);
            this.tabDoanhThu.Location = new System.Drawing.Point(4, 22);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoanhThu.Size = new System.Drawing.Size(772, 334);
            this.tabDoanhThu.TabIndex = 0;
            this.tabDoanhThu.Text = "Doanh Thu Theo Ngày";
            this.tabDoanhThu.UseVisualStyleBackColor = true;
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AllowUserToAddRows = false;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhThu.Location = new System.Drawing.Point(3, 3);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.ReadOnly = true;
            this.dgvDoanhThu.Size = new System.Drawing.Size(766, 328);
            this.dgvDoanhThu.TabIndex = 0;
            // 
            // tabDV
            // 
            this.tabDV.Controls.Add(this.dgvTanSuatDV);
            this.tabDV.Location = new System.Drawing.Point(4, 22);
            this.tabDV.Name = "tabDV";
            this.tabDV.Padding = new System.Windows.Forms.Padding(3);
            this.tabDV.Size = new System.Drawing.Size(772, 334);
            this.tabDV.TabIndex = 1;
            this.tabDV.Text = "Tần Suất Sử Dụng Dịch Vụ";
            this.tabDV.UseVisualStyleBackColor = true;
            // 
            // dgvTanSuatDV
            // 
            this.dgvTanSuatDV.AllowUserToAddRows = false;
            this.dgvTanSuatDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTanSuatDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTanSuatDV.Location = new System.Drawing.Point(3, 3);
            this.dgvTanSuatDV.Name = "dgvTanSuatDV";
            this.dgvTanSuatDV.ReadOnly = true;
            this.dgvTanSuatDV.Size = new System.Drawing.Size(766, 328);
            this.dgvTanSuatDV.TabIndex = 0;
            // 
            // FrmThongKe
            // 
            this.ClientSize = new System.Drawing.Size(780, 420);
            this.Controls.Add(this.tabThongKe);
            this.Controls.Add(this.pnlFilter);
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo Cáo & Thống Kê Doanh Thu";
            this.pnlFilter.ResumeLayout(false);
            this.tabThongKe.ResumeLayout(false);
            this.tabDoanhThu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.tabDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTanSuatDV)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
