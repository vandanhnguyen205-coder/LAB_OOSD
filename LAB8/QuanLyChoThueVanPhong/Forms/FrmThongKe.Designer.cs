namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmThongKe
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
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblTyLeLapDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(160, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(466, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁO CÁO THỐNG KÊ DOANH THU TÒA NHÀ";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.LightGreen;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.Location = new System.Drawing.Point(240, 74);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(293, 49);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "Xem Báo Cáo Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.Navy;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(67, 160);
            this.lblTongDoanhThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTongDoanhThu.Size = new System.Drawing.Size(318, 20);
            this.lblTongDoanhThu.TabIndex = 2;
            this.lblTongDoanhThu.Text = "TỔNG DOANH THU THÁNG: -- VNĐ";
            // 
            // lblTyLeLapDay
            // 
            this.lblTyLeLapDay.AutoSize = true;
            this.lblTyLeLapDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTyLeLapDay.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTyLeLapDay.Location = new System.Drawing.Point(67, 209);
            this.lblTyLeLapDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTyLeLapDay.Name = "lblTyLeLapDay";
            this.lblTyLeLapDay.Size = new System.Drawing.Size(293, 20);
            this.lblTyLeLapDay.TabIndex = 3;
            this.lblTyLeLapDay.Text = "TỶ LỆ LẤP ĐẦY MẶT BẰNG: -- %";
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 321);
            this.Controls.Add(this.lblTyLeLapDay);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Doanh Thu Văn Phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblTyLeLapDay;
    }
}
