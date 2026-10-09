// Giao diện WinForms tạo bằng các control và container chuẩn để Visual Studio Designer hiển thị.
// Có thể chỉnh trực tiếp vị trí, kích thước, Text trong tab Design.
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCongTyDuLich.Forms
{
    public partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnDanhMuc;
        private Button btnTour;
        private Button btnChuyenLe;
        private Button btnDangKyLe;
        private Button btnDangKyDoan;
        private Button btnPhanCong;
        private Button btnKetThuc;
        private Button btnThongKe;
        private Button btnThoat;
        private Button btnKiemTraCSDL;
        private TableLayoutPanel mainLayout;
        private Label lblTieuDe;
        private TableLayoutPanel menuLayout;
        private FlowLayoutPanel footerLayout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null) this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.btnDanhMuc = new Button();
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Text = "Danh mục";
            this.btnDanhMuc.Size = new Size(190, 36);
            this.btnDanhMuc.FlatStyle = FlatStyle.Standard;
            this.btnTour = new Button();
            this.btnTour.Name = "btnTour";
            this.btnTour.Text = "Tour - hành trình";
            this.btnTour.Size = new Size(190, 36);
            this.btnTour.FlatStyle = FlatStyle.Standard;
            this.btnChuyenLe = new Button();
            this.btnChuyenLe.Name = "btnChuyenLe";
            this.btnChuyenLe.Text = "Lịch chuyến khách lẻ";
            this.btnChuyenLe.Size = new Size(190, 36);
            this.btnChuyenLe.FlatStyle = FlatStyle.Standard;
            this.btnDangKyLe = new Button();
            this.btnDangKyLe.Name = "btnDangKyLe";
            this.btnDangKyLe.Text = "Đăng ký khách lẻ";
            this.btnDangKyLe.Size = new Size(190, 36);
            this.btnDangKyLe.FlatStyle = FlatStyle.Standard;
            this.btnDangKyDoan = new Button();
            this.btnDangKyDoan.Name = "btnDangKyDoan";
            this.btnDangKyDoan.Text = "Đăng ký theo đoàn";
            this.btnDangKyDoan.Size = new Size(190, 36);
            this.btnDangKyDoan.FlatStyle = FlatStyle.Standard;
            this.btnPhanCong = new Button();
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Text = "Phân công hướng dẫn viên";
            this.btnPhanCong.Size = new Size(190, 36);
            this.btnPhanCong.FlatStyle = FlatStyle.Standard;
            this.btnKetThuc = new Button();
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Text = "Kết thúc tour - khảo sát";
            this.btnKetThuc.Size = new Size(190, 36);
            this.btnKetThuc.FlatStyle = FlatStyle.Standard;
            this.btnThongKe = new Button();
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Text = "Lương - thống kê";
            this.btnThongKe.Size = new Size(190, 36);
            this.btnThongKe.FlatStyle = FlatStyle.Standard;
            this.btnThoat = new Button();
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Size = new Size(190, 36);
            this.btnThoat.FlatStyle = FlatStyle.Standard;
            this.btnKiemTraCSDL = new Button();
            this.btnKiemTraCSDL.Name = "btnKiemTraCSDL";
            this.btnKiemTraCSDL.Text = "Kiểm tra kết nối CSDL";
            this.btnKiemTraCSDL.Size = new Size(190, 36);
            this.btnKiemTraCSDL.FlatStyle = FlatStyle.Standard;
            this.btnDanhMuc.Click += new EventHandler(this.btnDanhMuc_Click);
            this.btnTour.Click += new EventHandler(this.btnTour_Click);
            this.btnChuyenLe.Click += new EventHandler(this.btnChuyenLe_Click);
            this.btnDangKyLe.Click += new EventHandler(this.btnDangKyLe_Click);
            this.btnDangKyDoan.Click += new EventHandler(this.btnDangKyDoan_Click);
            this.btnPhanCong.Click += new EventHandler(this.btnPhanCong_Click);
            this.btnKetThuc.Click += new EventHandler(this.btnKetThuc_Click);
            this.btnThongKe.Click += new EventHandler(this.btnThongKe_Click);
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            this.btnKiemTraCSDL.Click += new EventHandler(this.btnKiemTraCSDL_Click);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1120, 760);
            this.MinimumSize = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Segoe UI", 9.5f);
            this.Text = "CÔNG TY DU LỊCH VĂN HÓA VIỆT";
            this.mainLayout = new TableLayoutPanel();
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Dock = DockStyle.Fill;
            this.mainLayout.Padding = new Padding(12);
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.RowCount = 3;
            this.mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            this.Controls.Add(this.mainLayout);
            this.lblTieuDe = new Label();
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Text = "CÔNG TY DU LỊCH VĂN HÓA VIỆT";
            this.lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTieuDe.ForeColor = Color.FromArgb(33, 65, 94);
            this.lblTieuDe.Dock = DockStyle.Fill;
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            this.mainLayout.Controls.Add(this.lblTieuDe, 0, 0);
            this.menuLayout = new TableLayoutPanel();
            this.menuLayout.Name = "menuLayout";
            this.menuLayout.Dock = DockStyle.Fill;
            this.menuLayout.ColumnCount = 2;
            this.menuLayout.RowCount = 4;
            this.menuLayout.Padding = new Padding(48, 8, 48, 8);
            this.menuLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.menuLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.menuLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            this.menuLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            this.menuLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            this.menuLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            this.btnDanhMuc.Dock = DockStyle.Fill;
            this.btnDanhMuc.Margin = new Padding(13);
            this.menuLayout.Controls.Add(this.btnDanhMuc, 0, 0);
            this.btnTour.Dock = DockStyle.Fill;
            this.btnTour.Margin = new Padding(13);
            this.menuLayout.Controls.Add(this.btnTour, 1, 0);
            this.btnChuyenLe.Dock = DockStyle.Fill;
            this.btnChuyenLe.Margin = new Padding(13);
            this.menuLayout.Controls.Add(this.btnChuyenLe, 0, 1);
            this.btnDangKyLe.Dock = DockStyle.Fill;
            this.btnDangKyLe.Margin = new Padding(13);
            this.menuLayout.Controls.Add(this.btnDangKyLe, 1, 1);
            this.btnDangKyDoan.Dock = DockStyle.Fill;
            this.btnDangKyDoan.Margin = new Padding(13);
            this.menuLayout.Controls.Add(this.btnDangKyDoan, 0, 2);
            this.btnPhanCong.Dock = DockStyle.Fill;
            this.btnPhanCong.Margin = new Padding(13);
            this.menuLayout.Controls.Add(this.btnPhanCong, 1, 2);
            this.btnKetThuc.Dock = DockStyle.Fill;
            this.btnKetThuc.Margin = new Padding(13);
            this.menuLayout.Controls.Add(this.btnKetThuc, 0, 3);
            this.btnThongKe.Dock = DockStyle.Fill;
            this.btnThongKe.Margin = new Padding(13);
            this.menuLayout.Controls.Add(this.btnThongKe, 1, 3);
            this.mainLayout.Controls.Add(this.menuLayout, 0, 1);
            this.footerLayout = new FlowLayoutPanel();
            this.footerLayout.Name = "footerLayout";
            this.footerLayout.Dock = DockStyle.Fill;
            this.footerLayout.FlowDirection = FlowDirection.RightToLeft;
            this.footerLayout.Padding = new Padding(5);
            this.btnThoat.Size = new Size(115, 35);
            this.btnKiemTraCSDL.Size = new Size(205, 35);
            this.footerLayout.Controls.Add(this.btnThoat);
            this.footerLayout.Controls.Add(this.btnKiemTraCSDL);
            this.mainLayout.Controls.Add(this.footerLayout, 0, 2);
            this.ResumeLayout(false);
        }
    }
}
