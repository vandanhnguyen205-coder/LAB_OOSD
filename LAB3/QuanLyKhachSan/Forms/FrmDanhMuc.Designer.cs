namespace QuanLyKhachSan.Forms
{
    partial class FrmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPhong;
        private System.Windows.Forms.TabPage tabKhuVuc;
        private System.Windows.Forms.TabPage tabDichVu;
        private System.Windows.Forms.TabPage tabTienNghi;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridView dgvKhuVuc;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.DataGridView dgvTienNghi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPhong = new System.Windows.Forms.TabPage();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.tabKhuVuc = new System.Windows.Forms.TabPage();
            this.dgvKhuVuc = new System.Windows.Forms.DataGridView();
            this.tabDichVu = new System.Windows.Forms.TabPage();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.tabTienNghi = new System.Windows.Forms.TabPage();
            this.dgvTienNghi = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.tabKhuVuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuVuc)).BeginInit();
            this.tabDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.tabTienNghi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienNghi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPhong);
            this.tabControl1.Controls.Add(this.tabKhuVuc);
            this.tabControl1.Controls.Add(this.tabDichVu);
            this.tabControl1.Controls.Add(this.tabTienNghi);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 420);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPhong
            // 
            this.tabPhong.Controls.Add(this.dgvPhong);
            this.tabPhong.Location = new System.Drawing.Point(4, 22);
            this.tabPhong.Name = "tabPhong";
            this.tabPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhong.Size = new System.Drawing.Size(772, 394);
            this.tabPhong.TabIndex = 0;
            this.tabPhong.Text = "Danh Sách Phòng";
            this.tabPhong.UseVisualStyleBackColor = true;
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhong.Location = new System.Drawing.Point(3, 3);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.Size = new System.Drawing.Size(766, 388);
            this.dgvPhong.TabIndex = 0;
            // 
            // tabKhuVuc
            // 
            this.tabKhuVuc.Controls.Add(this.dgvKhuVuc);
            this.tabKhuVuc.Location = new System.Drawing.Point(4, 22);
            this.tabKhuVuc.Name = "tabKhuVuc";
            this.tabKhuVuc.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhuVuc.Size = new System.Drawing.Size(772, 394);
            this.tabKhuVuc.TabIndex = 1;
            this.tabKhuVuc.Text = "Khu Vực";
            this.tabKhuVuc.UseVisualStyleBackColor = true;
            // 
            // dgvKhuVuc
            // 
            this.dgvKhuVuc.AllowUserToAddRows = false;
            this.dgvKhuVuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhuVuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhuVuc.Location = new System.Drawing.Point(3, 3);
            this.dgvKhuVuc.Name = "dgvKhuVuc";
            this.dgvKhuVuc.ReadOnly = true;
            this.dgvKhuVuc.Size = new System.Drawing.Size(766, 388);
            this.dgvKhuVuc.TabIndex = 0;
            // 
            // tabDichVu
            // 
            this.tabDichVu.Controls.Add(this.dgvDichVu);
            this.tabDichVu.Location = new System.Drawing.Point(4, 22);
            this.tabDichVu.Name = "tabDichVu";
            this.tabDichVu.Size = new System.Drawing.Size(772, 394);
            this.tabDichVu.TabIndex = 2;
            this.tabDichVu.Text = "Dịch Vụ";
            this.tabDichVu.UseVisualStyleBackColor = true;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDichVu.Location = new System.Drawing.Point(0, 0);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.Size = new System.Drawing.Size(772, 394);
            this.dgvDichVu.TabIndex = 0;
            // 
            // tabTienNghi
            // 
            this.tabTienNghi.Controls.Add(this.dgvTienNghi);
            this.tabTienNghi.Location = new System.Drawing.Point(4, 22);
            this.tabTienNghi.Name = "tabTienNghi";
            this.tabTienNghi.Size = new System.Drawing.Size(772, 394);
            this.tabTienNghi.TabIndex = 3;
            this.tabTienNghi.Text = "Tiện Nghi";
            this.tabTienNghi.UseVisualStyleBackColor = true;
            // 
            // dgvTienNghi
            // 
            this.dgvTienNghi.AllowUserToAddRows = false;
            this.dgvTienNghi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTienNghi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTienNghi.Location = new System.Drawing.Point(0, 0);
            this.dgvTienNghi.Name = "dgvTienNghi";
            this.dgvTienNghi.ReadOnly = true;
            this.dgvTienNghi.Size = new System.Drawing.Size(772, 394);
            this.dgvTienNghi.TabIndex = 0;
            // 
            // FrmDanhMuc
            // 
            this.ClientSize = new System.Drawing.Size(780, 420);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Danh Mục Bảng Trút";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.tabKhuVuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuVuc)).EndInit();
            this.tabDichVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.tabTienNghi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTienNghi)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
