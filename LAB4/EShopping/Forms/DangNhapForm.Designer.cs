namespace eShopping.Forms
{
    partial class DangNhapForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnDangKyForm;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnDangKyForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblUser
            this.lblUser.Location = new System.Drawing.Point(30, 30);
            this.lblUser.Text = "Tên đăng nhập:";
            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(140, 27);
            this.txtUsername.Size = new System.Drawing.Size(180, 20);
            // lblPass
            this.lblPass.Location = new System.Drawing.Point(30, 75);
            this.lblPass.Text = "Mật khẩu:";
            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(140, 72);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(180, 20);
            // btnDangNhap
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.Location = new System.Drawing.Point(40, 125);
            this.btnDangNhap.Size = new System.Drawing.Size(130, 40);
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // btnDangKyForm
            this.btnDangKyForm.Location = new System.Drawing.Point(190, 125);
            this.btnDangKyForm.Size = new System.Drawing.Size(130, 40);
            this.btnDangKyForm.Text = "Đăng ký mới";
            this.btnDangKyForm.Click += new System.EventHandler(this.btnDangKyForm_Click);
            // DangNhapForm
            this.ClientSize = new System.Drawing.Size(360, 190);
            this.Controls.Add(this.btnDangKyForm);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUser);
            this.Name = "DangNhapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng Nhập Tài Khoản";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
