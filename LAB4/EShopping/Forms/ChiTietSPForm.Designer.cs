namespace eShopping.Forms
{
    partial class ChiTietSPForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblNSX;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Button btnThemGio;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblNSX = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemGio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // lblTenSP
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTenSP.Location = new System.Drawing.Point(20, 20);
            this.lblTenSP.Size = new System.Drawing.Size(340, 30);
            // lblMaSP
            this.lblMaSP.Location = new System.Drawing.Point(20, 65);
            this.lblMaSP.Size = new System.Drawing.Size(340, 20);
            // lblNSX
            this.lblNSX.Location = new System.Drawing.Point(20, 95);
            this.lblNSX.Size = new System.Drawing.Size(340, 20);
            // lblGia
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGia.ForeColor = System.Drawing.Color.Red;
            this.lblGia.Location = new System.Drawing.Point(20, 130);
            this.lblGia.Size = new System.Drawing.Size(340, 25);
            // lblTrangThai
            this.lblTrangThai.Location = new System.Drawing.Point(20, 165);
            this.lblTrangThai.Size = new System.Drawing.Size(340, 20);
            // lblSoLuong
            this.lblSoLuong.Location = new System.Drawing.Point(20, 210);
            this.lblSoLuong.Text = "Số lượng mua:";
            // nudSoLuong
            this.nudSoLuong.Location = new System.Drawing.Point(120, 208);
            this.nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuong.Size = new System.Drawing.Size(80, 20);
            this.nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // btnThemGio
            this.btnThemGio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemGio.Location = new System.Drawing.Point(100, 260);
            this.btnThemGio.Size = new System.Drawing.Size(180, 45);
            this.btnThemGio.Text = "Thêm vào giỏ hàng";
            this.btnThemGio.Click += new System.EventHandler(this.btnThemGio_Click);
            // ChiTietSPForm
            this.ClientSize = new System.Drawing.Size(380, 325);
            this.Controls.Add(this.btnThemGio);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblNSX);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.lblTenSP);
            this.Name = "ChiTietSPForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông Tin Chi Tiết Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
