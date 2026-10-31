namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmMain
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
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnQuanLyPhong = new System.Windows.Forms.Button();
            this.btnHopDongThue = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(55)))), ((int)(((byte)(115)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(253, 34);
            this.lblHeaderTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(661, 41);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "HỆ THỐNG QUẢN LÝ CHO THUÊ VĂN PHÒNG";
            this.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.Location = new System.Drawing.Point(80, 117);
            this.btnDanhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(293, 92);
            this.btnDanhMuc.TabIndex = 1;
            this.btnDanhMuc.Text = "   Danh mục";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnQuanLyPhong
            // 
            this.btnQuanLyPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnQuanLyPhong.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnQuanLyPhong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyPhong.Location = new System.Drawing.Point(413, 117);
            this.btnQuanLyPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanLyPhong.Name = "btnQuanLyPhong";
            this.btnQuanLyPhong.Size = new System.Drawing.Size(293, 92);
            this.btnQuanLyPhong.TabIndex = 2;
            this.btnQuanLyPhong.Text = "Mặt bằng - Văn phòng";
            this.btnQuanLyPhong.UseVisualStyleBackColor = true;
            this.btnQuanLyPhong.Click += new System.EventHandler(this.btnQuanLyPhong_Click);
            // 
            // btnHopDongThue
            // 
            this.btnHopDongThue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnHopDongThue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHopDongThue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopDongThue.Location = new System.Drawing.Point(747, 117);
            this.btnHopDongThue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHopDongThue.Name = "btnHopDongThue";
            this.btnHopDongThue.Size = new System.Drawing.Size(293, 92);
            this.btnHopDongThue.TabIndex = 3;
            this.btnHopDongThue.Text = "Lập Hợp đồng thuê";
            this.btnHopDongThue.UseVisualStyleBackColor = true;
            this.btnHopDongThue.Click += new System.EventHandler(this.btnHopDongThue_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDichVu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichVu.Location = new System.Drawing.Point(80, 234);
            this.btnDichVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(293, 92);
            this.btnDichVu.TabIndex = 4;
            this.btnDichVu.Text = "dịch vụ";
            this.btnDichVu.UseVisualStyleBackColor = true;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(413, 234);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(293, 92);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.Text = "  Thanh toán Hóa đơn";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(747, 234);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(293, 92);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = " Báo cáo Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(413, 351);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(293, 92);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "X    Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1120, 505);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnDichVu);
            this.Controls.Add(this.btnHopDongThue);
            this.Controls.Add(this.btnQuanLyPhong);
            this.Controls.Add(this.btnDanhMuc);
            this.Controls.Add(this.lblHeaderTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Cho thuê Văn phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnQuanLyPhong;
        private System.Windows.Forms.Button btnHopDongThue;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;
    }
}
