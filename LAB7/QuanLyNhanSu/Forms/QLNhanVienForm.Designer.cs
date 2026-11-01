namespace QuanLyNhanSu.Forms
{
    partial class QLNhanVienForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMaNV; private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblHoTen; private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh; private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh; private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblSDT; private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblDiaChi; private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblTrangThai; private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblPhongBan; private System.Windows.Forms.ComboBox cboPhongBan;

        private System.Windows.Forms.Button btnThem; private System.Windows.Forms.Button btnSua; private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvData;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMaNV = new System.Windows.Forms.Label(); this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label(); this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label(); this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label(); this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblSDT = new System.Windows.Forms.Label(); this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label(); this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label(); this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblPhongBan = new System.Windows.Forms.Label(); this.cboPhongBan = new System.Windows.Forms.ComboBox();

            this.btnThem = new System.Windows.Forms.Button(); this.btnSua = new System.Windows.Forms.Button(); this.btnXoa = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();

            this.lblMaNV.Text = "Mã NV:"; this.lblMaNV.Location = new System.Drawing.Point(20, 20); this.lblMaNV.Size = new System.Drawing.Size(60, 20);
            this.txtMaNV.Location = new System.Drawing.Point(90, 20); this.txtMaNV.Size = new System.Drawing.Size(140, 20);

            this.lblHoTen.Text = "Họ tên:"; this.lblHoTen.Location = new System.Drawing.Point(250, 20); this.lblHoTen.Size = new System.Drawing.Size(60, 20);
            this.txtHoTen.Location = new System.Drawing.Point(320, 20); this.txtHoTen.Size = new System.Drawing.Size(180, 20);

            this.lblNgaySinh.Text = "Ngày sinh:"; this.lblNgaySinh.Location = new System.Drawing.Point(20, 55); this.lblNgaySinh.Size = new System.Drawing.Size(65, 20);
            this.dtpNgaySinh.Location = new System.Drawing.Point(90, 55); this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblGioiTinh.Text = "Giới tính:"; this.lblGioiTinh.Location = new System.Drawing.Point(250, 55); this.lblGioiTinh.Size = new System.Drawing.Size(60, 20);
            this.cboGioiTinh.Location = new System.Drawing.Point(320, 55); this.cboGioiTinh.Size = new System.Drawing.Size(100, 21);
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });

            this.lblSDT.Text = "Điện thoại:"; this.lblSDT.Location = new System.Drawing.Point(20, 90); this.lblSDT.Size = new System.Drawing.Size(65, 20);
            this.txtSDT.Location = new System.Drawing.Point(90, 90); this.txtSDT.Size = new System.Drawing.Size(140, 20);

            this.lblDiaChi.Text = "Địa chỉ:"; this.lblDiaChi.Location = new System.Drawing.Point(250, 90); this.lblDiaChi.Size = new System.Drawing.Size(60, 20);
            this.txtDiaChi.Location = new System.Drawing.Point(320, 90); this.txtDiaChi.Size = new System.Drawing.Size(180, 20);

            this.lblTrangThai.Text = "Trạng thái:"; this.lblTrangThai.Location = new System.Drawing.Point(20, 125); this.lblTrangThai.Size = new System.Drawing.Size(65, 20);
            this.cboTrangThai.Location = new System.Drawing.Point(90, 125); this.cboTrangThai.Size = new System.Drawing.Size(140, 21);
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Items.AddRange(new object[] { "Thử việc", "Chính thức", "Nghỉ việc" });

            this.lblPhongBan.Text = "Phòng ban:"; this.lblPhongBan.Location = new System.Drawing.Point(250, 125); this.lblPhongBan.Size = new System.Drawing.Size(65, 20);
            this.cboPhongBan.Location = new System.Drawing.Point(320, 125); this.cboPhongBan.Size = new System.Drawing.Size(180, 21);
            this.cboPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.btnThem.Text = "Thêm"; this.btnThem.Location = new System.Drawing.Point(530, 20); this.btnThem.Size = new System.Drawing.Size(85, 30); this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnSua.Text = "Sửa"; this.btnSua.Location = new System.Drawing.Point(530, 60); this.btnSua.Size = new System.Drawing.Size(85, 30); this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnXoa.Text = "Xóa"; this.btnXoa.Location = new System.Drawing.Point(530, 100); this.btnXoa.Size = new System.Drawing.Size(85, 30); this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.dgvData.Location = new System.Drawing.Point(20, 165); this.dgvData.Size = new System.Drawing.Size(595, 220);
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvData_SelectionChanged);

            this.ClientSize = new System.Drawing.Size(635, 400);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblMaNV, this.txtMaNV, this.lblHoTen, this.txtHoTen,
                this.lblNgaySinh, this.dtpNgaySinh, this.lblGioiTinh, this.cboGioiTinh,
                this.lblSDT, this.txtSDT, this.lblDiaChi, this.txtDiaChi,
                this.lblTrangThai, this.cboTrangThai, this.lblPhongBan, this.cboPhongBan,
                this.btnThem, this.btnSua, this.btnXoa, this.dgvData
            });
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hồ Sơ Nhân Viên";
            this.ResumeLayout(false); this.PerformLayout();
        }
    }
}
