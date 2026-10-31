namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmThanhToan
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblSoHD = new System.Windows.Forms.Label();
            this.txtSoHoaDon = new System.Windows.Forms.TextBox();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.cboHinhThuc = new System.Windows.Forms.ComboBox();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSoHD
            // 
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.Location = new System.Drawing.Point(30, 30);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Size = new System.Drawing.Size(69, 13);
            this.lblSoHD.TabIndex = 0;
            this.lblSoHD.Text = "Số Hóa Đơn:";
            // 
            // txtSoHoaDon
            // 
            this.txtSoHoaDon.Location = new System.Drawing.Point(150, 27);
            this.txtSoHoaDon.Name = "txtSoHoaDon";
            this.txtSoHoaDon.Size = new System.Drawing.Size(230, 20);
            this.txtSoHoaDon.TabIndex = 1;
            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Location = new System.Drawing.Point(30, 80);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(60, 13);
            this.lblHinhThuc.TabIndex = 2;
            this.lblHinhThuc.Text = "Hình Thức:";
            // 
            // cboHinhThuc
            // 
            this.cboHinhThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThuc.FormattingEnabled = true;
            this.cboHinhThuc.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản",
            "Thẻ",
            "Ví điện tử"});
            this.cboHinhThuc.Location = new System.Drawing.Point(150, 77);
            this.cboHinhThuc.Name = "cboHinhThuc";
            this.cboHinhThuc.Size = new System.Drawing.Size(230, 21);
            this.cboHinhThuc.TabIndex = 3;
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Location = new System.Drawing.Point(30, 130);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(71, 13);
            this.lblSoTien.TabIndex = 4;
            this.lblSoTien.Text = "Số Tiền Nộp:";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(150, 127);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(230, 20);
            this.txtSoTien.TabIndex = 5;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.LightGreen;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.Location = new System.Drawing.Point(150, 180);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(230, 40);
            this.btnXacNhan.TabIndex = 6;
            this.btnXacNhan.Text = "Xác Nhận Thanh Toán";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // FrmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.lblSoTien);
            this.Controls.Add(this.cboHinhThuc);
            this.Controls.Add(this.lblHinhThuc);
            this.Controls.Add(this.txtSoHoaDon);
            this.Controls.Add(this.lblSoHD);
            this.Name = "FrmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Toán Hóa Đơn Văn Phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoHD;
        private System.Windows.Forms.TextBox txtSoHoaDon;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.ComboBox cboHinhThuc;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Button btnXacNhan;
    }
}
