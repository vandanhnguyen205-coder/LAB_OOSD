using System;

namespace QuanLyKhachSan.Forms  // ✅ Trùng namespace
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Location = new System.Drawing.Point(12, 144);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(263, 62);
            this.btnDanhMuc.TabIndex = 8;
            this.btnDanhMuc.Text = "Danh Mục";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.Location = new System.Drawing.Point(12, 240);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(263, 62);
            this.btnDichVu.TabIndex = 7;
            this.btnDichVu.Text = "Sử dụng dịch vụ";
            this.btnDichVu.UseVisualStyleBackColor = true;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.Location = new System.Drawing.Point(322, 144);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(263, 62);
            this.btnPhong.TabIndex = 6;
            this.btnPhong.Text = "Phòng - Tiện Nghi";
            this.btnPhong.UseVisualStyleBackColor = true;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click_1);
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Location = new System.Drawing.Point(322, 240);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(263, 62);
            this.btnTraPhong.TabIndex = 5;
            this.btnTraPhong.Text = "Trả Phòng - Thanh Toán";
            this.btnTraPhong.UseVisualStyleBackColor = true;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(322, 340);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(263, 62);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Location = new System.Drawing.Point(634, 144);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(263, 62);
            this.btnDatPhong.TabIndex = 3;
            this.btnDatPhong.Text = "Đặt - Nhận Phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click_1);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(634, 240);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(263, 62);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(200, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ KHÁCH SẠN";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrangThai.Location = new System.Drawing.Point(12, 415);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(161, 20);
            this.lblTrangThai.TabIndex = 0;
            this.lblTrangThai.Text = "Đang kiểm tra kết nối...";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.btnPhong);
            this.Controls.Add(this.btnDichVu);
            this.Controls.Add(this.btnDanhMuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khách Sạn";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTrangThai;
        private EventHandler btnPhong_Click;
        private EventHandler btnTraPhong_Click;
        private EventHandler btnDatPhong_Click;
        private EventHandler btnThongKe_Click;
    }
}