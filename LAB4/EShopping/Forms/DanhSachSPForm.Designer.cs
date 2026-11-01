namespace eShopping.Forms
{
    partial class DanhSachSPForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNhom;
        private System.Windows.Forms.ComboBox cboNhom;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnThemGio;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNhom = new System.Windows.Forms.Label();
            this.cboNhom = new System.Windows.Forms.ComboBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnThemGio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // lblNhom
            this.lblNhom.Location = new System.Drawing.Point(15, 20);
            this.lblNhom.Text = "Nhóm sản phẩm:";
            // cboNhom
            this.cboNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhom.Location = new System.Drawing.Point(130, 17);
            this.cboNhom.Size = new System.Drawing.Size(250, 21);
            this.cboNhom.SelectedIndexChanged += new System.EventHandler(this.cboNhom_SelectedIndexChanged);
            // dgvSanPham
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(15, 55);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(750, 320);
            // lblSoLuong
            this.lblSoLuong.Location = new System.Drawing.Point(15, 395);
            this.lblSoLuong.Text = "Số lượng mua:";
            // nudSoLuong
            this.nudSoLuong.Location = new System.Drawing.Point(105, 393);
            this.nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuong.Size = new System.Drawing.Size(80, 20);
            this.nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // btnChiTiet
            this.btnChiTiet.Location = new System.Drawing.Point(460, 388);
            this.btnChiTiet.Size = new System.Drawing.Size(140, 35);
            this.btnChiTiet.Text = "Xem chi tiết";
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // btnThemGio
            this.btnThemGio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemGio.Location = new System.Drawing.Point(615, 388);
            this.btnThemGio.Size = new System.Drawing.Size(150, 35);
            this.btnThemGio.Text = "Thêm vào giỏ hàng";
            this.btnThemGio.Click += new System.EventHandler(this.btnThemGio_Click);
            // DanhSachSPForm
            this.ClientSize = new System.Drawing.Size(780, 435);
            this.Controls.Add(this.btnThemGio);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.cboNhom);
            this.Controls.Add(this.lblNhom);
            this.Name = "DanhSachSPForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh Sách Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
