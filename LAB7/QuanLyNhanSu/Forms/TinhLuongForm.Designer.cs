namespace QuanLyNhanSu.Forms
{
    partial class TinhLuongForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblThang; private System.Windows.Forms.NumericUpDown numThang;
        private System.Windows.Forms.Label lblNam; private System.Windows.Forms.NumericUpDown numNam;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.DataGridView dgvData;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblThang = new System.Windows.Forms.Label();
            this.numThang = new System.Windows.Forms.NumericUpDown();
            this.lblNam = new System.Windows.Forms.Label();
            this.numNam = new System.Windows.Forms.NumericUpDown();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.numThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();

            this.lblThang.Text = "Tháng:"; this.lblThang.Location = new System.Drawing.Point(20, 20); this.lblThang.Size = new System.Drawing.Size(50, 20);
            this.numThang.Location = new System.Drawing.Point(75, 20); this.numThang.Size = new System.Drawing.Size(60, 20);
            this.numThang.Minimum = 1; this.numThang.Maximum = 12;

            this.lblNam.Text = "Năm:"; this.lblNam.Location = new System.Drawing.Point(155, 20); this.lblNam.Size = new System.Drawing.Size(40, 20);
            this.numNam.Location = new System.Drawing.Point(200, 20); this.numNam.Size = new System.Drawing.Size(80, 20);
            this.numNam.Minimum = 2000; this.numNam.Maximum = 2100;

            this.btnTinhLuong.Text = "TÍNH & LƯU BẢNG LƯƠNG THÁNG";
            this.btnTinhLuong.Location = new System.Drawing.Point(310, 15);
            this.btnTinhLuong.Size = new System.Drawing.Size(220, 30);
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);

            this.dgvData.Location = new System.Drawing.Point(20, 60);
            this.dgvData.Size = new System.Drawing.Size(740, 340);
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.ClientSize = new System.Drawing.Size(780, 420);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblThang, this.numThang, this.lblNam, this.numNam, this.btnTinhLuong, this.dgvData
            });
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bảng Lương Tháng - Công Ty Sơn Đông Á";
            ((System.ComponentModel.ISupportInitialize)(this.numThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false); this.PerformLayout();
        }
    }
}
