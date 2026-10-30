namespace QuanLyBenhAn
{
    partial class MainForm
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

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnNhapDotKham;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Label lblStatus;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnNhapDotKham = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(90, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HỆ THỐNG QUẢN LÝ BỆNH ÁN";
            //
            // btnDangKy
            //
            this.btnDangKy.Location = new System.Drawing.Point(90, 80);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(280, 40);
            this.btnDangKy.TabIndex = 1;
            this.btnDangKy.Text = "Đăng ký bệnh nhân / Cấp hồ sơ";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            //
            // btnNhapDotKham
            //
            this.btnNhapDotKham.Location = new System.Drawing.Point(90, 130);
            this.btnNhapDotKham.Name = "btnNhapDotKham";
            this.btnNhapDotKham.Size = new System.Drawing.Size(280, 40);
            this.btnNhapDotKham.TabIndex = 2;
            this.btnNhapDotKham.Text = "Nhập thông tin đợt khám";
            this.btnNhapDotKham.UseVisualStyleBackColor = true;
            this.btnNhapDotKham.Click += new System.EventHandler(this.btnNhapDotKham_Click);
            //
            // btnTraCuu
            //
            this.btnTraCuu.Location = new System.Drawing.Point(90, 180);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(280, 40);
            this.btnTraCuu.TabIndex = 3;
            this.btnTraCuu.Text = "Tra cứu hồ sơ / Lịch sử khám";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(90, 250);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(180, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Đang kiểm tra kết nối CSDL...";
            //
            // MainForm
            //
            this.ClientSize = new System.Drawing.Size(480, 320);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnNhapDotKham);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.lblStatus);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bệnh án - Trang chủ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
