namespace QuanLyKhachSan.Forms
{
    partial class FrmSuDungDichVu
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
            this.txtSoPhieuLuuTru = new System.Windows.Forms.TextBox();
            this.txtSoPhieuDat = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDichVu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoPhieuLuuTru
            // 
            this.txtSoPhieuLuuTru.Location = new System.Drawing.Point(126, 17);
            this.txtSoPhieuLuuTru.Name = "txtSoPhieuLuuTru";
            this.txtSoPhieuLuuTru.Size = new System.Drawing.Size(188, 22);
            this.txtSoPhieuLuuTru.TabIndex = 53;
            // 
            // txtSoPhieuDat
            // 
            this.txtSoPhieuDat.AutoSize = true;
            this.txtSoPhieuDat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSoPhieuDat.Location = new System.Drawing.Point(12, 20);
            this.txtSoPhieuDat.Name = "txtSoPhieuDat";
            this.txtSoPhieuDat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSoPhieuDat.Size = new System.Drawing.Size(108, 16);
            this.txtSoPhieuDat.TabIndex = 52;
            this.txtSoPhieuDat.Text = "Số Phiếu Lưu Trữ";
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(407, 20);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(89, 22);
            this.txtPhong.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(352, 23);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Phòng ";
            // 
            // txtDichVu
            // 
            this.txtDichVu.Location = new System.Drawing.Point(588, 20);
            this.txtDichVu.Name = "txtDichVu";
            this.txtDichVu.Size = new System.Drawing.Size(188, 22);
            this.txtDichVu.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(529, 20);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Dịch Vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Ngày Sử Dụng";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 22);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(431, 72);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(77, 22);
            this.numSoLuong.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(352, 72);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Số Lượng ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 43);
            this.button1.TabIndex = 62;
            this.button1.Text = "Ghi nhận";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(12, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(922, 353);
            this.dataGridView1.TabIndex = 63;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Số Phiếu ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Phòng ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Dịch Vụ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số Lượng ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Đơn Gía";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Thành Tiền ";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // FrmSuDungDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 525);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDichVu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoPhieuLuuTru);
            this.Controls.Add(this.txtSoPhieuDat);
            this.Name = "FrmSuDungDichVu";
            this.Text = "Sử dụng dịch vụ";
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoPhieuLuuTru;
        private System.Windows.Forms.Label txtSoPhieuDat;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDichVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}