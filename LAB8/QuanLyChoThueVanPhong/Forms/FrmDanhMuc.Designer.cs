namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmDanhMuc
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
            this.grpPhong = new System.Windows.Forms.GroupBox();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.grpPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPhong
            // 
            this.grpPhong.Controls.Add(this.dgvPhong);
            this.grpPhong.Location = new System.Drawing.Point(12, 53);
            this.grpPhong.Name = "grpPhong";
            this.grpPhong.Size = new System.Drawing.Size(760, 396);
            this.grpPhong.TabIndex = 0;
            this.grpPhong.TabStop = false;
            this.grpPhong.Text = "Danh sách Mặt bằng / Văn phòng";
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhong.Location = new System.Drawing.Point(3, 16);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.Size = new System.Drawing.Size(754, 377);
            this.dgvPhong.TabIndex = 0;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(12, 12);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(120, 35);
            this.btnTaiLai.TabIndex = 1;
            this.btnTaiLai.Text = "Tải lại Danh sách";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.grpPhong);
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Danh mục Mặt bằng";
            this.grpPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPhong;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Button btnTaiLai;
    }
}
