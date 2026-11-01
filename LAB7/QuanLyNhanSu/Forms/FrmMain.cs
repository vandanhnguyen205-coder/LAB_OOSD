using System.Drawing;
using System.Windows.Forms;
namespace QuanLyNhanSu.Forms {
    public class FrmMain : Form {
        public FrmMain() {
            StartPosition=FormStartPosition.CenterScreen;
            Size=new Size(850,600);
            MinimumSize=new Size(700,450);
            Text = "CÔNG TY SƠN ĐÔNG Á - QUẢN LÝ NHÂN SỰ VÀ LƯƠNG";
            var panel = new FlowLayoutPanel { Dock=DockStyle.Fill, Padding=new Padding(28), FlowDirection=FlowDirection.TopDown, WrapContents=false, AutoScroll=true };
            Controls.Add(panel);
            var title = new Label { Text="QUẢN LÝ NHÂN SỰ VÀ LƯƠNG", AutoSize=true, Font=new Font("Segoe UI",18,FontStyle.Bold), Margin=new Padding(8,8,8,24) }; panel.Controls.Add(title);
            var bFrmTuyenDung = new Button { Text="Tuyển dụng – thử việc", Width=420, Height=48, Margin=new Padding(8) }; bFrmTuyenDung.Click += (s,e) => { using(var f=new FrmTuyenDung()) f.ShowDialog(this); }; panel.Controls.Add(bFrmTuyenDung);
            var bFrmHopDongQuyetDinh = new Button { Text="Hợp đồng – quyết định – bảo hiểm", Width=420, Height=48, Margin=new Padding(8) }; bFrmHopDongQuyetDinh.Click += (s,e) => { using(var f=new FrmHopDongQuyetDinh()) f.ShowDialog(this); }; panel.Controls.Add(bFrmHopDongQuyetDinh);
            var bFrmChamCong = new Button { Text="Chấm công – phụ trội – kế hoạch tuần", Width=420, Height=48, Margin=new Padding(8) }; bFrmChamCong.Click += (s,e) => { using(var f=new FrmChamCong()) f.ShowDialog(this); }; panel.Controls.Add(bFrmChamCong);
            var bFrmKhenThuongKyLuat = new Button { Text="Khen thưởng – kỷ luật", Width=420, Height=48, Margin=new Padding(8) }; bFrmKhenThuongKyLuat.Click += (s,e) => { using(var f=new FrmKhenThuongKyLuat()) f.ShowDialog(this); }; panel.Controls.Add(bFrmKhenThuongKyLuat);
            var bFrmLuong = new Button { Text="Tính lương tháng", Width=420, Height=48, Margin=new Padding(8) }; bFrmLuong.Click += (s,e) => { using(var f=new FrmLuong()) f.ShowDialog(this); }; panel.Controls.Add(bFrmLuong);
            var exit = new Button { Text="Thoát", Width=160, Height=40, Margin=new Padding(8) }; exit.Click += (s,e)=>Close(); panel.Controls.Add(exit);
        }
    }
}