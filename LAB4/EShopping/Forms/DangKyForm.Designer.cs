namespace eShopping.Forms
{
    partial class DangKyForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHoTen; private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh; private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblCMND; private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblDiaChi; private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblSDT; private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblUser; private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass; private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblEmail; private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnXacNhanDangKy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHoTen = new System.Windows.Forms.Label(); this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label(); this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblCMND = new System.Windows.Forms.Label(); this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label(); this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label(); this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label(); this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label(); this.txtPass = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label(); this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnXacNhanDangKy = new System.Windows.Forms.Button();
            this.SuspendLayout();

            int y = 20;
            this.lblHoTen.Location = new System.Drawing.Point(20, y); this.lblHoTen.Text = "Họ và Tên (*):";
            this.txtHoTen.Location = new System.Drawing.Point(140, y-3); this.txtHoTen.Size = new System.Drawing.Size(200, 20); y += 35;

            this.lblNgaySinh.Location = new System.Drawing.Point(20, y); this.lblNgaySinh.Text = "Ngày sinh:";
            this.dtpNgaySinh.Location = new System.Drawing.Point(140, y-3); this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpNgaySinh.Size = new System.Drawing.Size(200, 20); y += 35;

            this.lblCMND.Location = new System.Drawing.Point(20, y); this.lblCMND.Text = "CMND/Passport (*):";
            this.txtCMND.Location = new System.Drawing.Point(140, y-3); this.txtCMND.Size = new System.Drawing.Size(200, 20); y += 35;

            this.lblDiaChi.Location = new System.Drawing.Point(20, y); this.lblDiaChi.Text = "Địa chỉ:";
            this.txtDiaChi.Location = new System.Drawing.Point(140, y-3); this.txtDiaChi.Size = new System.Drawing.Size(200, 20); y += 35;

            this.lblSDT.Location = new System.Drawing.Point(20, y); this.lblSDT.Text = "Điện thoại:";
            this.txtSDT.Location = new System.Drawing.Point(140, y-3); this.txtSDT.Size = new System.Drawing.Size(200, 20); y += 35;

            this.lblUser.Location = new System.Drawing.Point(20, y); this.lblUser.Text = "Tên đăng nhập (*):";
            this.txtUser.Location = new System.Drawing.Point(140, y-3); this.txtUser.Size = new System.Drawing.Size(200, 20); y += 35;

            this.lblPass.Location = new System.Drawing.Point(20, y); this.lblPass.Text = "Mật khẩu (*):";
            this.txtPass.Location = new System.Drawing.Point(140, y-3); this.txtPass.PasswordChar = '*'; this.txtPass.Size = new System.Drawing.Size(200, 20); y += 35;

            this.lblEmail.Location = new System.Drawing.Point(20, y); this.lblEmail.Text = "Email:";
            this.txtEmail.Location = new System.Drawing.Point(140, y-3); this.txtEmail.Size = new System.Drawing.Size(200, 20); y += 45;

            this.btnXacNhanDangKy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXacNhanDangKy.Location = new System.Drawing.Point(90, y);
            this.btnXacNhanDangKy.Size = new System.Drawing.Size(180, 45);
            this.btnXacNhanDangKy.Text = "XÁC NHẬN ĐĂNG KÝ";
            this.btnXacNhanDangKy.Click += new System.EventHandler(this.btnXacNhanDangKy_Click);

            this.ClientSize = new System.Drawing.Size(365, y + 65);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblHoTen, this.txtHoTen, this.lblNgaySinh, this.dtpNgaySinh,
                this.lblCMND, this.txtCMND, this.lblDiaChi, this.txtDiaChi,
                this.lblSDT, this.txtSDT, this.lblUser, this.txtUser,
                this.lblPass, this.txtPass, this.lblEmail, this.txtEmail, this.btnXacNhanDangKy
            });
            this.Name = "DangKyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo Tài Khoản Khách Hàng";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
