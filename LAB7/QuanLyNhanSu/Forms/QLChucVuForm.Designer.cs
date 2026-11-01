namespace QuanLyNhanSu.Forms
{
    partial class QLChucVuForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMa; private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.Label lblTen; private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.Button btnThem; private System.Windows.Forms.Button btnSua; private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvData;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMa = new System.Windows.Forms.Label(); this.txtMaCV = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label(); this.txtTenCV = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button(); this.btnSua = new System.Windows.Forms.Button(); this.btnXoa = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();

            this.lblMa.Text = "Mã CV:"; this.lblMa.Location = new System.Drawing.Point(20, 20); this.lblMa.Size = new System.Drawing.Size(60, 20);
            this.txtMaCV.Location = new System.Drawing.Point(90, 20); this.txtMaCV.Size = new System.Drawing.Size(120, 20);

            this.lblTen.Text = "Tên CV:"; this.lblTen.Location = new System.Drawing.Point(230, 20); this.lblTen.Size = new System.Drawing.Size(60, 20);
            this.txtTenCV.Location = new System.Drawing.Point(290, 20); this.txtTenCV.Size = new System.Drawing.Size(180, 20);

            this.btnThem.Text = "Thêm"; this.btnThem.Location = new System.Drawing.Point(490, 18); this.btnThem.Size = new System.Drawing.Size(75, 25); this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnSua.Text = "Sửa"; this.btnSua.Location = new System.Drawing.Point(490, 50); this.btnSua.Size = new System.Drawing.Size(75, 25); this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnXoa.Text = "Xóa"; this.btnXoa.Location = new System.Drawing.Point(490, 82); this.btnXoa.Size = new System.Drawing.Size(75, 25); this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.dgvData.Location = new System.Drawing.Point(20, 60); this.dgvData.Size = new System.Drawing.Size(450, 220);
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvData_SelectionChanged);

            this.ClientSize = new System.Drawing.Size(585, 300);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblMa, this.txtMaCV, this.lblTen, this.txtTenCV, this.btnThem, this.btnSua, this.btnXoa, this.dgvData });
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Chức Vụ";
            this.ResumeLayout(false); this.PerformLayout();
        }
    }
}
