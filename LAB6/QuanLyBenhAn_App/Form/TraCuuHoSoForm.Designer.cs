namespace QuanLyBenhAn
{
    partial class TraCuuHoSoForm
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

        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnTimHoSo;
        private System.Windows.Forms.DataGridView gridHoSo;
        private System.Windows.Forms.Label lblLichSu;
        private System.Windows.Forms.DataGridView gridLichSu;

        private void InitializeComponent()
        {
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnTimHoSo = new System.Windows.Forms.Button();
            this.gridHoSo = new System.Windows.Forms.DataGridView();
            this.lblLichSu = new System.Windows.Forms.Label();
            this.gridLichSu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridHoSo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLichSu)).BeginInit();
            this.SuspendLayout();
            //
            // lblTuKhoa
            //
            this.lblTuKhoa.Location = new System.Drawing.Point(20, 20);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(230, 20);
            this.lblTuKhoa.Text = "Từ khóa (mã BN / họ tên / SĐT):";
            //
            // txtTuKhoa
            //
            this.txtTuKhoa.Location = new System.Drawing.Point(260, 18);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(250, 24);
            //
            // btnTimHoSo
            //
            this.btnTimHoSo.Location = new System.Drawing.Point(520, 16);
            this.btnTimHoSo.Name = "btnTimHoSo";
            this.btnTimHoSo.Size = new System.Drawing.Size(100, 28);
            this.btnTimHoSo.Text = "Tìm hồ sơ";
            this.btnTimHoSo.UseVisualStyleBackColor = true;
            this.btnTimHoSo.Click += new System.EventHandler(this.BtnTimHoSo_Click);
            //
            // gridHoSo
            //
            this.gridHoSo.AllowUserToAddRows = false;
            this.gridHoSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridHoSo.Location = new System.Drawing.Point(20, 60);
            this.gridHoSo.Name = "gridHoSo";
            this.gridHoSo.ReadOnly = true;
            this.gridHoSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHoSo.Size = new System.Drawing.Size(840, 200);
            this.gridHoSo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridHoSo_CellClick);
            //
            // lblLichSu
            //
            this.lblLichSu.Location = new System.Drawing.Point(20, 270);
            this.lblLichSu.Name = "lblLichSu";
            this.lblLichSu.Size = new System.Drawing.Size(300, 20);
            this.lblLichSu.Text = "Lịch sử đợt khám:";
            //
            // gridLichSu
            //
            this.gridLichSu.AllowUserToAddRows = false;
            this.gridLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLichSu.Location = new System.Drawing.Point(20, 295);
            this.gridLichSu.Name = "gridLichSu";
            this.gridLichSu.ReadOnly = true;
            this.gridLichSu.Size = new System.Drawing.Size(840, 240);
            //
            // TraCuuHoSoForm
            //
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.lblTuKhoa);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.btnTimHoSo);
            this.Controls.Add(this.gridHoSo);
            this.Controls.Add(this.lblLichSu);
            this.Controls.Add(this.gridLichSu);
            this.Name = "TraCuuHoSoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu hồ sơ / Lịch sử khám";
            ((System.ComponentModel.ISupportInitialize)(this.gridHoSo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLichSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
