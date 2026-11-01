namespace eShopping.Forms
{
    partial class GioHangForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Label lblTamTinh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTinhTien;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.lblTamTinh = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.SuspendLayout();
            // dgvGioHang
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Location = new System.Drawing.Point(12, 12);
            this.dgvGioHang.MultiSelect = false;
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(560, 260);
            // lblTamTinh
            this.lblTamTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTamTinh.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTamTinh.Location = new System.Drawing.Point(12, 290);
            this.lblTamTinh.Size = new System.Drawing.Size(300, 30);
            this.lblTamTinh.Text = "Tạm tính: 0 VNĐ";
            // btnXoa
            this.btnXoa.Location = new System.Drawing.Point(320, 288);
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.Text = "Xóa mục";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // btnTinhTien
            this.btnTinhTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTinhTien.Location = new System.Drawing.Point(432, 288);
            this.btnTinhTien.Size = new System.Drawing.Size(140, 35);
            this.btnTinhTien.Text = "TIẾN HÀNH ĐẶT HÀNG";
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // GioHangForm
            this.ClientSize = new System.Drawing.Size(584, 336);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblTamTinh);
            this.Controls.Add(this.dgvGioHang);
            this.Name = "GioHangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Giỏ Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
