namespace QuanLyKhachSan.Forms
{
    partial class FrmDichVu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPhongDangO;
        private System.Windows.Forms.GroupBox gbChonDV;
        private System.Windows.Forms.Label lblDichVu;
        private System.Windows.Forms.ComboBox cboDichVu;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Button btnLuuDV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvPhongDangO = new System.Windows.Forms.DataGridView();
            this.gbChonDV = new System.Windows.Forms.GroupBox();
            this.btnLuuDV = new System.Windows.Forms.Button();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.cboDichVu = new System.Windows.Forms.ComboBox();
            this.lblDichVu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongDangO)).BeginInit();
            this.gbChonDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhongDangO
            // 
            this.dgvPhongDangO.AllowUserToAddRows = false;
            this.dgvPhongDangO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongDangO.Location = new System.Drawing.Point(12, 12);
            this.dgvPhongDangO.MultiSelect = false;
            this.dgvPhongDangO.Name = "dgvPhongDangO";
            this.dgvPhongDangO.ReadOnly = true;
            this.dgvPhongDangO.RowHeadersWidth = 51;
            this.dgvPhongDangO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongDangO.Size = new System.Drawing.Size(400, 250);
            this.dgvPhongDangO.TabIndex = 0;
            // 
            // gbChonDV
            // 
            this.gbChonDV.Controls.Add(this.btnLuuDV);
            this.gbChonDV.Controls.Add(this.nudSoLuong);
            this.gbChonDV.Controls.Add(this.lblSoLuong);
            this.gbChonDV.Controls.Add(this.cboDichVu);
            this.gbChonDV.Controls.Add(this.lblDichVu);
            this.gbChonDV.Location = new System.Drawing.Point(430, 12);
            this.gbChonDV.Name = "gbChonDV";
            this.gbChonDV.Size = new System.Drawing.Size(260, 250);
            this.gbChonDV.TabIndex = 1;
            this.gbChonDV.TabStop = false;
            this.gbChonDV.Text = "Sử Dụng Dịch Vụ";
            // 
            // btnLuuDV
            // 
            this.btnLuuDV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLuuDV.Location = new System.Drawing.Point(6, 164);
            this.btnLuuDV.Name = "btnLuuDV";
            this.btnLuuDV.Size = new System.Drawing.Size(220, 45);
            this.btnLuuDV.TabIndex = 4;
            this.btnLuuDV.Text = "XÁC NHẬN SỬ DỤNG";
            this.btnLuuDV.Click += new System.EventHandler(this.btnLuuDV_Click);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(90, 83);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(80, 22);
            this.nudSoLuong.TabIndex = 5;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Location = new System.Drawing.Point(15, 85);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(70, 20);
            this.lblSoLuong.TabIndex = 6;
            this.lblSoLuong.Text = "Số Lượng:";
            // 
            // cboDichVu
            // 
            this.cboDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDichVu.FormattingEnabled = true;
            this.cboDichVu.Location = new System.Drawing.Point(90, 32);
            this.cboDichVu.Name = "cboDichVu";
            this.cboDichVu.Size = new System.Drawing.Size(155, 24);
            this.cboDichVu.TabIndex = 7;
            // 
            // lblDichVu
            // 
            this.lblDichVu.Location = new System.Drawing.Point(15, 35);
            this.lblDichVu.Name = "lblDichVu";
            this.lblDichVu.Size = new System.Drawing.Size(70, 20);
            this.lblDichVu.TabIndex = 8;
            this.lblDichVu.Text = "Dịch Vụ:";
            // 
            // FrmDichVu
            // 
            this.ClientSize = new System.Drawing.Size(704, 281);
            this.Controls.Add(this.gbChonDV);
            this.Controls.Add(this.dgvPhongDangO);
            this.Name = "FrmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ghi Nhận Sử Dụng Dịch Vụ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongDangO)).EndInit();
            this.gbChonDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
