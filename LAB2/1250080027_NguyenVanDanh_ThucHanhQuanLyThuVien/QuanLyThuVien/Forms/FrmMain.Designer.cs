namespace QuanLyThuVien.Forms
{
    partial class FrmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnMuonTra = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Location = new System.Drawing.Point(241, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(475, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hệ Thống Quản Lý Thư Viện";
            this.lblTitle.UseMnemonic = false;
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.Location = new System.Drawing.Point(24, 122);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(247, 68);
            this.btnDanhMuc.TabIndex = 1;
            this.btnDanhMuc.Text = "Danh Mục/ Nhân Viên";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            // 
            // btnDocGia
            // 
            this.btnDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocGia.Location = new System.Drawing.Point(24, 252);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Size = new System.Drawing.Size(247, 68);
            this.btnDocGia.TabIndex = 2;
            this.btnDocGia.Text = "Độc giả và thẻ";
            this.btnDocGia.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(24, 402);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(247, 68);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnSach
            // 
            this.btnSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.Location = new System.Drawing.Point(735, 122);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(247, 68);
            this.btnSach.TabIndex = 4;
            this.btnSach.Text = "Quản Lý Đầu Sách";
            this.btnSach.UseVisualStyleBackColor = true;
            // 
            // btnMuonTra
            // 
            this.btnMuonTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuonTra.Location = new System.Drawing.Point(735, 252);
            this.btnMuonTra.Name = "btnMuonTra";
            this.btnMuonTra.Size = new System.Drawing.Size(247, 68);
            this.btnMuonTra.TabIndex = 5;
            this.btnMuonTra.Text = "Mượn - Trả Sách";
            this.btnMuonTra.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(735, 402);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(247, 68);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 547);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnMuonTra);
            this.Controls.Add(this.btnSach);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnDocGia);
            this.Controls.Add(this.btnDanhMuc);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnDocGia;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnMuonTra;
        private System.Windows.Forms.Button btnThoat;
    }
}