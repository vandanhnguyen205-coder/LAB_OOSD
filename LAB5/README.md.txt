LAB5 - BẢN SỬA: DESIGNER HIỂN THỊ TRONG VISUAL STUDIO 2022

NGUYÊN NHÂN: Bản cũ gọi các phương thức UiFactory trong InitializeComponent.
Runtime hiển thị được các control, nhưng WinForms Designer không tái dựng đúng.

BẢN NÀY: Chuyển giao diện 9 form (FrmMain + 8 form nghiệp vụ) sang các control
và container khai báo trực tiếp bằng mã chuẩn trong *.Designer.cs.
Không thay đổi các file Service, Db.cs, App.config hay SQL mẫu.

CÁCH DÙNG:
1. Đóng hẳn Visual Studio trước khi thay project.
2. GIẢI NÉN TOÀN BỘ, mở QuanLyCongTyDuLich.sln TRONG THƯ MỤC MỚI.
3. Chuột phải Forms/FrmMain.cs > View Designer hoặc Shift + F7.
4. Chọn các nút trong Designer, F4 để sửa Properties.
5. Build > Rebuild Solution, chạy F5, kiểm tra nút Kiểm tra kết nối CSDL.
6. Mở từng form còn lại trong Design để chỉnh bố cục tùy ý.

LƯU Ý:
- Chưa chạy kiểm thử bằng Visual Studio trên Windows trong môi trường tạo file này.
- Nếu Visual Studio vẫn hiển thị bản cũ, đóng VS, xóa .vs, bin, obj rồi mở lại.
- SQL script có DROP TABLE; KHÔNG chạy lại trên database đang có dữ liệu cần giữ.
- File *.Designer.cs có thể bị Visual Studio tự viết lại sau khi chỉnh bằng chuột.
