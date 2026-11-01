using System.Drawing;
using System.Windows.Forms;
namespace QuanLyNhanSu.Forms {
    public class FrmHopDongQuyetDinh : Form {
        public FrmHopDongQuyetDinh() {
            StartPosition=FormStartPosition.CenterScreen;
            Size=new Size(850,600);
            MinimumSize=new Size(700,450);
            Text = "Hợp đồng – quyết định – bảo hiểm";
            var panel = new TableLayoutPanel { Dock=DockStyle.Fill, Padding=new Padding(18), ColumnCount=1, RowCount=3 };
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize)); panel.RowStyles.Add(new RowStyle(SizeType.Percent,100)); panel.RowStyles.Add(new RowStyle(SizeType.AutoSize)); Controls.Add(panel);
            panel.Controls.Add(new Label { Text="Hợp đồng – quyết định – bảo hiểm", AutoSize=true, Font=new Font("Segoe UI",16,FontStyle.Bold), Margin=new Padding(4,4,4,18) },0,0);
            panel.Controls.Add(new Label { Text="Form giao diện khung theo LAB7.docx. Bổ sung các trường nhập liệu, gọi Service và kiểm thử theo mục 8–9 của tài liệu.", AutoSize=true, MaximumSize=new Size(680,0), Font=new Font("Segoe UI",10), Padding=new Padding(8) },0,1);
            var close = new Button { Text="Đóng", Width=120, Height=36, Anchor=AnchorStyles.Right, Margin=new Padding(8) }; close.Click += (s,e)=>Close(); panel.Controls.Add(close,0,2);
        }
    }
}