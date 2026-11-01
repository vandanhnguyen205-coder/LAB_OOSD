namespace QuanLyKhachSan.Forms
{
    partial class FrmDatPhong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox gbTimPhong;
        private System.Windows.Forms.DateTimePicker dtpNgayNhan;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.NumericUpDown nudSoKhach;
        private System.Windows.Forms.Button btnTimPhong;
        private System.Windows.Forms.Label lblNgayNhan;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.Label lblSoKhach;
        private System.Windows.Forms.DataGridView dgvPhongTrong;
        private System.Windows.Forms.GroupBox gbThongTinKhach;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtQuocTich;
        private System.Windows.Forms.TextBox txtCoc;
        private System.Windows.Forms.Button btnLuuDatPhong;
        private System.Windows.Forms.Label lblMaKhach;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblQuocTich;
        private System.Windows.Forms.Label lblCoc;

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
            this.gbTimPhong = new System.Windows.Forms.GroupBox();
            this.lblNgayNhan = new System.Windows.Forms.Label();
            this.dtpNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.lblSoKhach = new System.Windows.Forms.Label();
            this.nudSoKhach = new System.Windows.Forms.NumericUpDown();
            this.btnTimPhong = new System.Windows.Forms.Button();
            this.dgvPhongTrong = new System.Windows.Forms.DataGridView();
            this.gbThongTinKhach = new System.Windows.Forms.GroupBox();
            this.lblMaKhach = new System.Windows.Forms.Label();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblQuocTich = new System.Windows.Forms.Label();
            this.txtQuocTich = new System.Windows.Forms.TextBox();
            this.lblCoc = new System.Windows.Forms.Label();
            this.txtCoc = new System.Windows.Forms.TextBox();
            this.btnLuuDatPhong = new System.Windows.Forms.Button();
            this.gbTimPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTrong)).BeginInit();
            this.gbThongTinKhach.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTimPhong
            // 
            this.gbTimPhong.Controls.Add(this.btnTimPhong);
            this.gbTimPhong.Controls.Add(this.nudSoKhach);
            this.gbTimPhong.Controls.Add(this.lblSoKhach);
            this.gbTimPhong.Controls.Add(this.dtpNgayTra);
            this.gbTimPhong.Controls.Add(this.lblNgayTra);
            this.gbTimPhong.Controls.Add(this.dtpNgayNhan);
            this.gbTimPhong.Controls.Add(this.lblNgayNhan);
            this.gbTimPhong.Location = new System.Drawing.Point(12, 12);
            this.gbTimPhong.Name = "gbTimPhong";
            this.gbTimPhong.Size = new System.Drawing.Size(420, 150);
            this.gbTimPhong.TabIndex = 0;
            this.gbTimPhong.TabStop = false;
            this.gbTimPhong.Text = "Tìm Phong Trong";
            // 
            // lblNgayNhan
            // 
            this.lblNgayNhan.Location = new System.Drawing.Point(15, 30);
            this.lblNgayNhan.Name = "lblNgayNhan";
            this.lblNgayNhan.Size = new System.Drawing.Size(80, 20);
            this.lblNgayNhan.Text = "Ngày Nhận:";
            // 
            // dtpNgayNhan
            // 
            this.dtpNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhan.Location = new System.Drawing.Point(100, 28);
            this.dtpNgayNhan.Name = "dtpNgayNhan";
            this.dtpNgayNhan.Size = new System.Drawing.Size(120, 20);
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.Location = new System.Drawing.Point(15, 65);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(80, 20);
            this.lblNgayTra.Text = "Ngày Trả:";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(100, 63);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(120, 20);
            // 
            // lblSoKhach
            // 
            this.lblSoKhach.Location = new System.Drawing.Point(15, 100);
            this.lblSoKhach.Name = "lblSoKhach";
            this.lblSoKhach.Size = new System.Drawing.Size(80, 20);
            this.lblSoKhach.Text = "Số Khách:";
            // 
            // nudSoKhach
            // 
            this.nudSoKhach.Location = new System.Drawing.Point(100, 98);
            this.nudSoKhach.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoKhach.Name = "nudSoKhach";
            this.nudSoKhach.Size = new System.Drawing.Size(60, 20);
            this.nudSoKhach.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnTimPhong
            // 
            this.btnTimPhong.Location = new System.Drawing.Point(250, 45);
            this.btnTimPhong.Name = "btnTimPhong";
            this.btnTimPhong.Size = new System.Drawing.Size(140, 50);
            this.btnTimPhong.TabIndex = 6;
            this.btnTimPhong.Text = "Tra Cứu Phòng";
            this.btnTimPhong.Click += new System.EventHandler(this.btnTimPhong_Click);
            // 
            // dgvPhongTrong
            // 
            this.dgvPhongTrong.AllowUserToAddRows = false;
            this.dgvPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongTrong.Location = new System.Drawing.Point(12, 175);
            this.dgvPhongTrong.MultiSelect = false;
            this.dgvPhongTrong.Name = "dgvPhongTrong";
            this.dgvPhongTrong.ReadOnly = true;
            this.dgvPhongTrong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongTrong.Size = new System.Drawing.Size(420, 250);
            this.dgvPhongTrong.TabIndex = 1;
            // 
            // gbThongTinKhach
            // 
            this.gbThongTinKhach.Controls.Add(this.btnLuuDatPhong);
            this.gbThongTinKhach.Controls.Add(this.txtCoc);
            this.gbThongTinKhach.Controls.Add(this.lblCoc);
            this.gbThongTinKhach.Controls.Add(this.txtQuocTich);
            this.gbThongTinKhach.Controls.Add(this.lblQuocTich);
            this.gbThongTinKhach.Controls.Add(this.txtCMND);
            this.gbThongTinKhach.Controls.Add(this.lblCMND);
            this.gbThongTinKhach.Controls.Add(this.txtHoTen);
            this.gbThongTinKhach.Controls.Add(this.lblHoTen);
            this.gbThongTinKhach.Controls.Add(this.txtMaKhach);
            this.gbThongTinKhach.Controls.Add(this.lblMaKhach);
            this.gbThongTinKhach.Location = new System.Drawing.Point(450, 12);
            this.gbThongTinKhach.Name = "gbThongTinKhach";
            this.gbThongTinKhach.Size = new System.Drawing.Size(320, 413);
            this.gbThongTinKhach.TabIndex = 2;
            this.gbThongTinKhach.TabStop = false;
            this.gbThongTinKhach.Text = "Thông Tin Đặt Phòng";
            // 
            // lblMaKhach
            // 
            this.lblMaKhach.Location = new System.Drawing.Point(15, 35);
            this.lblMaKhach.Name = "lblMaKhach";
            this.lblMaKhach.Size = new System.Drawing.Size(80, 20);
            this.lblMaKhach.Text = "Mã Khách:";
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(100, 32);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(190, 20);
            // 
            // lblHoTen
            // 
            this.lblHoTen.Location = new System.Drawing.Point(15, 75);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(80, 20);
            this.lblHoTen.Text = "Họ và Tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(100, 72);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(190, 20);
            // 
            // lblCMND
            // 
            this.lblCMND.Location = new System.Drawing.Point(15, 115);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(80, 20);
            this.lblCMND.Text = "CCCD/CMND:";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(100, 112);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(190, 20);
            // 
            // lblQuocTich
            // 
            this.lblQuocTich.Location = new System.Drawing.Point(15, 155);
            this.lblQuocTich.Name = "lblQuocTich";
            this.lblQuocTich.Size = new System.Drawing.Size(80, 20);
            this.lblQuocTich.Text = "Quốc Tịch:";
            // 
            // txtQuocTich
            // 
            this.txtQuocTich.Location = new System.Drawing.Point(100, 152);
            this.txtQuocTich.Name = "txtQuocTich";
            this.txtQuocTich.Size = new System.Drawing.Size(190, 20);
            this.txtQuocTich.Text = "Việt Nam";
            // 
            // lblCoc
            // 
            this.lblCoc.Location = new System.Drawing.Point(15, 195);
            this.lblCoc.Name = "lblCoc";
            this.lblCoc.Size = new System.Drawing.Size(80, 20);
            this.lblCoc.Text = "Tiền Cọc:";
            // 
            // txtCoc
            // 
            this.txtCoc.Location = new System.Drawing.Point(100, 192);
            this.txtCoc.Name = "txtCoc";
            this.txtCoc.Size = new System.Drawing.Size(190, 20);
            this.txtCoc.Text = "0";
            // 
            // btnLuuDatPhong
            // 
            this.btnLuuDatPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuuDatPhong.Location = new System.Drawing.Point(60, 310);
            this.btnLuuDatPhong.Name = "btnLuuDatPhong";
            this.btnLuuDatPhong.Size = new System.Drawing.Size(200, 50);
            this.btnLuuDatPhong.TabIndex = 10;
            this.btnLuuDatPhong.Text = "XÁC NHẬN ĐẶT PHÒNG";
            this.btnLuuDatPhong.Click += new System.EventHandler(this.btnLuuDatPhong_Click);
            // 
            // FrmDatPhong
            // 
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.gbThongTinKhach);
            this.Controls.Add(this.dgvPhongTrong);
            this.Controls.Add(this.gbTimPhong);
            this.Name = "FrmDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng Ký Đặt Phòng";
            this.gbTimPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTrong)).EndInit();
            this.gbThongTinKhach.ResumeLayout(false);
            this.gbThongTinKhach.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
