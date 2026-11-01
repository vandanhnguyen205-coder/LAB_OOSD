namespace eShopping.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnGioHang;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnDangXuat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnGioHang = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(72, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(603, 46);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "HỆ THỐNG CỬA HÀNG e-SHOPPING";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSanPham.Location = new System.Drawing.Point(80, 120);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(280, 90);
            this.btnSanPham.TabIndex = 4;
            this.btnSanPham.Text = "1. XEM SẢN PHẨM";
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnGioHang
            // 
            this.btnGioHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGioHang.Location = new System.Drawing.Point(420, 120);
            this.btnGioHang.Name = "btnGioHang";
            this.btnGioHang.Size = new System.Drawing.Size(280, 90);
            this.btnGioHang.TabIndex = 3;
            this.btnGioHang.Text = "2. QUẢN LÝ GIỎ HÀNG";
            this.btnGioHang.Click += new System.EventHandler(this.btnGioHang_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.Location = new System.Drawing.Point(80, 240);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(280, 60);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "3. ĐĂNG NHẬP";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangKy.Location = new System.Drawing.Point(420, 240);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(280, 60);
            this.btnDangKy.TabIndex = 1;
            this.btnDangKy.Text = "4. ĐĂNG KÝ TÀI KHOẢN";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.Red;
            this.btnDangXuat.Location = new System.Drawing.Point(250, 325);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(280, 45);
            this.btnDangXuat.TabIndex = 0;
            this.btnDangXuat.Text = "ĐĂNG XUẤT";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(780, 395);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnGioHang);
            this.Controls.Add(this.btnSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-SHOPPING Online Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
