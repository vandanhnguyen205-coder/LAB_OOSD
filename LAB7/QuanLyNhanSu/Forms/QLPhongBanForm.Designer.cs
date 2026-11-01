namespace QuanLyNhanSu.Forms
{
    partial class QLPhongBanForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMa; private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.Label lblTen; private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.Label lblLoai; private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Button btnThem; private System.Windows.Forms.Button btnSua; private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvData;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMa = new System.Windows.Forms.Label(); this.txtMaPB = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label(); this.txtTenPB = new System.Windows.Forms.TextBox();
            this.lblLoai = new System.Windows.Forms.Label(); this.cboLoai = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button(); this.btnSua = new System.Windows.Forms.Button(); this.btnXoa = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();

            this.lblMa.Text = "Mã PB:"; this.lblMa.Location = new System.Drawing.Point(20, 20); this.lblMa.Size = new System.Drawing.Size(60, 20);
            this.txtMaPB.Location = new System.Drawing.Point(90, 20); this.txtMaPB.Size = new System.Drawing.Size(120, 20);

            this.lblTen.Text = "Tên PB:"; this.lblTen.Location = new System.Drawing.Point(230, 20); this.lblTen.Size = new System.Drawing.Size(60, 20);
            this.txtTenPB.Location = new System.Drawing.Point(290, 20); this.txtTenPB.Size = new System.Drawing.Size(180, 20);

            this.lblLoai.Text = "Loại đơn vị:"; this.lblLoai.Location = new System.Drawing.Point(20, 55); this.lblLoai.Size = new System.Drawing.Size(70, 20);
            this.cboLoai.Location = new System.Drawing.Point(90, 55); this.cboLoai.Size = new System.Drawing.Size(120, 21);
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.Items.AddRange(new object[] { "Phòng", "Ban", "Phân xưởng" });

            this.btnThem.Text = "Thêm"; this.btnThem.Location = new System.Drawing.Point(490, 18); this.btnThem.Size = new System.Drawing.Size(75, 25); this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnSua.Text = "Sửa"; this.btnSua.Location = new System.Drawing.Point(490, 50); this.btnSua.Size = new System.Drawing.Size(75, 25); this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnXoa.Text = "Xóa"; this.btnXoa.Location = new System.Drawing.Point(490, 82); this.btnXoa.Size = new System.Drawing.Size(75, 25); this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.dgvData.Location = new System.Drawing.Point(20, 100); this.dgvData.Size = new System.Drawing.Size(450, 220);
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvData_SelectionChanged);

            this.ClientSize = new System.Drawing.Size(585, 340);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblMa, this.txtMaPB, this.lblTen, this.txtTenPB, this.lblLoai, this.cboLoai, this.btnThem, this.btnSua, this.btnXoa, this.dgvData });
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Phòng Ban";
            this.ResumeLayout(false); this.PerformLayout();
        }
    }
}
