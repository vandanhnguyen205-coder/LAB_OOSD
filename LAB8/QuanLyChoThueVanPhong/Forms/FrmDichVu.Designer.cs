namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmDichVu
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblDienCu = new System.Windows.Forms.Label();
            this.txtDienCu = new System.Windows.Forms.TextBox();
            this.lblDienMoi = new System.Windows.Forms.Label();
            this.txtDienMoi = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(303, 28);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(92, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DỊCH VỤ";
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Location = new System.Drawing.Point(53, 86);
            this.lblMaPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(71, 16);
            this.lblMaPhong.TabIndex = 1;
            this.lblMaPhong.Text = "Mã Phòng:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(187, 82);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(345, 22);
            this.txtMaPhong.TabIndex = 2;
            // 
            // lblDienCu
            // 
            this.lblDienCu.AutoSize = true;
            this.lblDienCu.Location = new System.Drawing.Point(53, 135);
            this.lblDienCu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDienCu.Name = "lblDienCu";
            this.lblDienCu.Size = new System.Drawing.Size(68, 16);
            this.lblDienCu.TabIndex = 3;
            this.lblDienCu.Text = "Chỉ Số Cũ:";
            // 
            // txtDienCu
            // 
            this.txtDienCu.Location = new System.Drawing.Point(187, 132);
            this.txtDienCu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDienCu.Name = "txtDienCu";
            this.txtDienCu.Size = new System.Drawing.Size(345, 22);
            this.txtDienCu.TabIndex = 4;
            // 
            // lblDienMoi
            // 
            this.lblDienMoi.AutoSize = true;
            this.lblDienMoi.Location = new System.Drawing.Point(53, 185);
            this.lblDienMoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDienMoi.Name = "lblDienMoi";
            this.lblDienMoi.Size = new System.Drawing.Size(74, 16);
            this.lblDienMoi.TabIndex = 5;
            this.lblDienMoi.Text = "Chỉ Số Mới:";
            // 
            // txtDienMoi
            // 
            this.txtDienMoi.Location = new System.Drawing.Point(187, 181);
            this.txtDienMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDienMoi.Name = "txtDienMoi";
            this.txtDienMoi.Size = new System.Drawing.Size(345, 22);
            this.txtDienMoi.TabIndex = 6;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Location = new System.Drawing.Point(187, 246);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(347, 49);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu Chỉ Số Dịch Vụ";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // FrmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 346);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtDienMoi);
            this.Controls.Add(this.lblDienMoi);
            this.Controls.Add(this.txtDienCu);
            this.Controls.Add(this.lblDienCu);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.lblMaPhong);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ghi Nhận Chỉ Số Dịch Vụ Văn Phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label lblDienCu;
        private System.Windows.Forms.TextBox txtDienCu;
        private System.Windows.Forms.Label lblDienMoi;
        private System.Windows.Forms.TextBox txtDienMoi;
        private System.Windows.Forms.Button btnLuu;
    }
}
