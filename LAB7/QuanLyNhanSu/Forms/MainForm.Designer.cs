namespace QuanLyNhanSu.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnPhongBan;
        private System.Windows.Forms.Button btnChucVu;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnTuyenDung;
        private System.Windows.Forms.Button btnTinhLuong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnPhongBan = new System.Windows.Forms.Button();
            this.btnChucVu = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnTuyenDung = new System.Windows.Forms.Button();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(40, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(491, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "HỆ THỐNG QUẢN LÝ NHÂN SỰ & LƯƠNG";
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.Location = new System.Drawing.Point(60, 70);
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.Size = new System.Drawing.Size(340, 40);
            this.btnPhongBan.TabIndex = 1;
            this.btnPhongBan.Text = "1. QUẢN LÝ PHÒNG BAN";
            this.btnPhongBan.Click += new System.EventHandler(this.btnPhongBan_Click);
            // 
            // btnChucVu
            // 
            this.btnChucVu.Location = new System.Drawing.Point(60, 120);
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.Size = new System.Drawing.Size(340, 40);
            this.btnChucVu.TabIndex = 2;
            this.btnChucVu.Text = "2. QUẢN LÝ CHỨC VỤ";
            this.btnChucVu.Click += new System.EventHandler(this.btnChucVu_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(60, 170);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(340, 40);
            this.btnNhanVien.TabIndex = 3;
            this.btnNhanVien.Text = "3. HỒ SƠ NHÂN VIÊN";
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnTuyenDung
            // 
            this.btnTuyenDung.Location = new System.Drawing.Point(60, 220);
            this.btnTuyenDung.Name = "btnTuyenDung";
            this.btnTuyenDung.Size = new System.Drawing.Size(340, 40);
            this.btnTuyenDung.TabIndex = 4;
            this.btnTuyenDung.Text = "4. TUYỂN DỤNG & THỬ VIỆC";
            this.btnTuyenDung.Click += new System.EventHandler(this.btnTuyenDung_Click);
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Location = new System.Drawing.Point(60, 270);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(340, 40);
            this.btnTinhLuong.TabIndex = 5;
            this.btnTinhLuong.Text = "5. TÍNH LƯƠNG THÁNG";
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(460, 340);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnPhongBan);
            this.Controls.Add(this.btnChucVu);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.btnTuyenDung);
            this.Controls.Add(this.btnTinhLuong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Công ty Sơn Đông Á - Quản Lý Nhân Sự & Lương";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
