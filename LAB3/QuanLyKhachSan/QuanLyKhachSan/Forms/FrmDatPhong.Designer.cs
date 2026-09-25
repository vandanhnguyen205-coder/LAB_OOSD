namespace QuanLyKhachSan.Forms
{
    partial class FrmDatPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDanhSachPhiêu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLapPhieuDat = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.Label();
            this.txtSoPhieuDat = new System.Windows.Forms.Label();
            this.dgvPhongChon = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDanhSachPhong = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhiêu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhong)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachPhiêu
            // 
            this.dgvDanhSachPhiêu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhiêu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Column4,
            this.Column5,
            this.Column2,
            this.Column6});
            this.dgvDanhSachPhiêu.Location = new System.Drawing.Point(47, 395);
            this.dgvDanhSachPhiêu.Name = "dgvDanhSachPhiêu";
            this.dgvDanhSachPhiêu.RowHeadersWidth = 51;
            this.dgvDanhSachPhiêu.RowTemplate.Height = 24;
            this.dgvDanhSachPhiêu.Size = new System.Drawing.Size(927, 172);
            this.dgvDanhSachPhiêu.TabIndex = 48;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Số Phiếu";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Khách";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Ngày Nhận";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày Trả Dự Kiến";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cọc";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kiểm Tra";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Trạng Thái";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(1019, 78);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Tiền Cọc";
            // 
            // btnLapPhieuDat
            // 
            this.btnLapPhieuDat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLapPhieuDat.Location = new System.Drawing.Point(991, 347);
            this.btnLapPhieuDat.Name = "btnLapPhieuDat";
            this.btnLapPhieuDat.Size = new System.Drawing.Size(167, 23);
            this.btnLapPhieuDat.TabIndex = 42;
            this.btnLapPhieuDat.Text = "Lập Phiếu Đặt";
            this.btnLapPhieuDat.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(807, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 23);
            this.button4.TabIndex = 41;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(714, 78);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Phiếu Đang ở";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.AutoSize = true;
            this.txtTenKhach.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtTenKhach.Location = new System.Drawing.Point(364, 72);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTenKhach.Size = new System.Drawing.Size(80, 16);
            this.txtTenKhach.TabIndex = 38;
            this.txtTenKhach.Text = "Khách Hàng";
            // 
            // txtSoPhieuDat
            // 
            this.txtSoPhieuDat.AutoSize = true;
            this.txtSoPhieuDat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSoPhieuDat.Location = new System.Drawing.Point(32, 72);
            this.txtSoPhieuDat.Name = "txtSoPhieuDat";
            this.txtSoPhieuDat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSoPhieuDat.Size = new System.Drawing.Size(84, 16);
            this.txtSoPhieuDat.TabIndex = 36;
            this.txtSoPhieuDat.Text = "Số Phiếu Đặt";
            // 
            // dgvPhongChon
            // 
            this.dgvPhongChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvPhongChon.Location = new System.Drawing.Point(715, 142);
            this.dgvPhongChon.Name = "dgvPhongChon";
            this.dgvPhongChon.RowHeadersWidth = 51;
            this.dgvPhongChon.RowTemplate.Height = 24;
            this.dgvPhongChon.Size = new System.Drawing.Size(425, 172);
            this.dgvPhongChon.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Phòng Chọn ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Số Người";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Đơn giá/ Ngày";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dgvDanhSachPhong
            // 
            this.dgvDanhSachPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column3,
            this.Column1});
            this.dgvDanhSachPhong.Location = new System.Drawing.Point(47, 142);
            this.dgvDanhSachPhong.Name = "dgvDanhSachPhong";
            this.dgvDanhSachPhong.RowHeadersWidth = 51;
            this.dgvDanhSachPhong.RowTemplate.Height = 24;
            this.dgvDanhSachPhong.Size = new System.Drawing.Size(558, 172);
            this.dgvDanhSachPhong.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Phòng ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Khu";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sức Chứa";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Đơn Gía";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(32, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(301, 31);
            this.tabControl1.TabIndex = 50;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(293, 2);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Khách Hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(293, 2);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đặt Phòng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(293, 2);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nhận Phòng và Người Lưu Trú";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 22);
            this.textBox1.TabIndex = 51;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(450, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 22);
            this.textBox2.TabIndex = 52;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1086, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 22);
            this.textBox3.TabIndex = 53;
            // 
            // FrmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 585);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgvDanhSachPhiêu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLapPhieuDat);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenKhach);
            this.Controls.Add(this.txtSoPhieuDat);
            this.Controls.Add(this.dgvPhongChon);
            this.Controls.Add(this.dgvDanhSachPhong);
            this.Name = "FrmDatPhong";
            this.Text = "Khách Hàng - Đặt Phòng - Nhận Phòng ";
            this.Load += new System.EventHandler(this.FrmDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhiêu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhong)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDanhSachPhiêu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLapPhieuDat;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtTenKhach;
        private System.Windows.Forms.Label txtSoPhieuDat;
        private System.Windows.Forms.DataGridView dgvPhongChon;
        private System.Windows.Forms.DataGridView dgvDanhSachPhong;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}