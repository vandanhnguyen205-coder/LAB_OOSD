namespace eShopping.Forms
{
    partial class XacNhanDonForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaDon;
        private System.Windows.Forms.Label lblStatusEmail;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMaDon = new System.Windows.Forms.Label();
            this.lblStatusEmail = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Size = new System.Drawing.Size(440, 35);
            this.lblTitle.Text = "ĐẶT HÀNG THÀNH CÔNG!";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblMaDon
            this.lblMaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMaDon.Location = new System.Drawing.Point(20, 70);
            this.lblMaDon.Size = new System.Drawing.Size(440, 30);
            this.lblMaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblStatusEmail
            this.lblStatusEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblStatusEmail.Location = new System.Drawing.Point(20, 115);
            this.lblStatusEmail.Size = new System.Drawing.Size(440, 40);
            this.lblStatusEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // btnDong
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDong.Location = new System.Drawing.Point(170, 175);
            this.btnDong.Size = new System.Drawing.Size(140, 40);
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // XacNhanDonForm
            this.ClientSize = new System.Drawing.Size(480, 235);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lblStatusEmail);
            this.Controls.Add(this.lblMaDon);
            this.Controls.Add(this.lblTitle);
            this.Name = "XacNhanDonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xác Nhận Đơn Đặt Hàng";
            this.ResumeLayout(false);
        }
    }
}
