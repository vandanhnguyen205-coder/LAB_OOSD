# LAB5 – QUẢN LÝ CÔNG TY DU LỊCH VĂN HÓA VIỆT

## Nội dung đã chuẩn bị

- **6 sơ đồ bổ sung** trong `UML/`: 2 Use Case phân rã, 2 Activity, 2 Sequence. Chúng **không phải bản sao** của các sơ đồ sẵn có P.2, P.3, P.20 và P.7–P.12 trong tài liệu.
- **ERD dùng lại**: Hình P.21 (trang 24) trong Word, không vẽ một ERD mới thay thế.
- **Script SQL Server**: `Database/QuanLyCongTyDuLich.sql` được tách nguyên văn từ bảng code trong Word; gồm 16 bảng, khóa ngoại, ràng buộc và dữ liệu mẫu.
- **WinForms C# .NET Framework 4.7.2**: 8 form nghiệp vụ, 1 form điều hướng, 8 Service nghiệp vụ, `Db.cs` và `App.config` được tách từ Word. Các file `.Designer.cs`, `UiFactory.cs`, `Program.cs`, `.csproj`, `.sln` được bổ sung để có cơ sở mở project. `KetNoiService.cs` và nút “Kiểm tra kết nối CSDL” được bổ sung cho việc nghiệm thu.

## Quan trọng trước khi chạy

- **Cảnh báo**: File SQL gốc có lệnh `DROP TABLE` trước khi tạo lại các bảng. **Không chạy lại sau khi đã nhập dữ liệu cần giữ**, vì có thể xóa toàn bộ dữ liệu của các bảng này.
- Các form hiện bố trí giao diện bằng mã C# (`UiFactory.cs`), **không giống hệt pixel** ảnh mẫu trong Word. Việc chỉnh giao diện bằng WinForms Designer kéo-thả có thể bị hạn chế khi dùng mã bố cục động.
- Các `.cs` nghiệp vụ được lấy từ tài liệu và **chưa được biên dịch/chạy kiểm thử bằng Visual Studio/SQL Server thực tế trong môi trường tạo tài liệu này**. Phải mở trên Windows, Build và thử từng chức năng; nếu có lỗi phát sinh, sửa theo thông báo thực tế.

## Cách chạy (Visual Studio 2022 / SQL Server LocalDB)

1. Giải nén file ZIP, đặt thư mục `LAB5_QuanLyCongTyDuLich` vào nơi dễ tìm (không đặt trong `.vs`).
2. Mở **SQL Server Management Studio** (hoặc SQL Server Object Explorer), kết nối instance `(localdb)\MSSQLLocalDB`. Nếu dùng `SQLEXPRESS` hoặc instance riêng thì thay trong `App.config`.
3. Mở `Database/QuanLyCongTyDuLich.sql` → kiểm tra script → **Execute một lần trên DB LAB5 dùng để thử**. Kiểm tra thông báo tạo thành công.
4. Chạy `Tests/KiemTraDuLieu.sql`, đảm bảo cột `SoBang` = `16` và xuất hiện dữ liệu tour mẫu.
5. Mở `QuanLyCongTyDuLich.sln` trong **Visual Studio 2022**, chấp nhận load project .NET Framework 4.7.2. Cài **.NET desktop development** và .NET Framework 4.7.2 targeting pack nếu máy chưa có.
6. Right click Solution → **Build Solution** (`Ctrl+Shift+B`). Chọn `Set as Startup Project` nếu cần, sau đó `F5`.
7. Trên `FrmMain`, bấm **Kiểm tra kết nối CSDL**. Nếu thất bại, kiểm tra instance SQL Server đang chạy, tên database và chuỗi kết nối trong `App.config`.
8. Mở từng form để thử thêm dữ liệu, theo dõi danh sách và thông báo. Sau mỗi thao tác kiểm tra dữ liệu bằng câu lệnh `SELECT`.

## 8 form nghiệp vụ + form chính

| Form | Chức năng | Service / bảng chính |
|---|---|---|
| FrmMain | Điều hướng và kiểm tra kết nối | KetNoiService |
| FrmDanhMuc | Phương tiện, điểm bán vé, hướng dẫn viên, điểm tham quan | DanhMucService / các bảng danh mục |
| FrmTour | Tour, điểm dừng, phương tiện theo chặng, điểm tham quan | TourService / Tour, TourDiemDung, TourPhuongTien, TourDiemThamQuan |
| FrmChuyenLe | Tạo chuyến, tính ngày về, đóng đăng ký | ChuyenLeService / ChuyenLe |
| FrmDangKyLe | Đăng ký, thu tiền vé khách lẻ | DangKyLeService / DangKyLe |
| FrmDangKyDoan | Lập phiếu đoàn, lập danh sách, hủy mất cọc | DangKyDoanService / DoanKhach, DangKyDoan, ThanhVienDoan, PhanCongHDV |
| FrmPhanCongHDV | Phân công HDV và kiểm tra trùng lịch | PhanCongService / PhanCongHDV |
| FrmKetThucKhaoSat | Thanh toán đoàn, gửi khảo sát, nhận góp ý | KetThucService / ThanhToanDoan, KhaoSat |
| FrmLuongThongKe | Lương HDV và thống kê | ThongKeService / HuongDanVien, PhanCongHDV |

## 2 kịch bản mới cho báo cáo truy vết

### TC-L5-01 — Tạo chuyến khách lẻ

- **Tiền điều kiện**: database mẫu, tour T001 đang mở bán, SoNgay = 3.
- **Thao tác**: `FrmChuyenLe` → mã chuyến `CL004`, chọn `T001`, ngày đi `25/11/2026`, địa điểm đón `Nhà Văn hóa Thanh Niên, Quận 1`, bấm **Tạo chuyến**.
- **Mong đợi**: nếu mã chưa tồn tại, `ChuyenLeService.ThemChuyen` tạo được bản ghi mới với `NgayVe = 27/11/2026`, trạng thái `Mở đăng ký`; Grid tự nạp lại.
- **Đối chứng SQL**: `SELECT * FROM ChuyenLe WHERE MaChuyen = 'CL004';`
- **Truy vết**: BR/QD02 → UC-01 → Activity-01 → Sequence-01 → FrmChuyenLe → ChuyenLeService → Tour/ChuyenLe → TC-L5-01.
- **Ca lỗi bổ sung**: thử mã `CL004` lần thứ hai → SQL từ chối trùng khóa chính.

### TC-L5-02 — Hủy phiếu đoàn, mất cọc

- **Tiền điều kiện**: dữ liệu mẫu `DD002`, ngày đi `10/12/2026`, trạng thái `Đã đăng ký` và thời điểm kiểm thử **trước ngày 10/12/2026**. Tiền cọc ban đầu `12.000.000`.
- **Thao tác**: `FrmDangKyDoan` → chọn `DD002` → **Hủy phiếu (mất cọc)** → xác nhận.
- **Mong đợi**: `DangKyDoan.TrangThai = N'Hủy - mất cọc'`, `TienCoc` vẫn là `12.000.000`; không còn dòng `PhanCongHDV` có `SoDKDoan='DD002'` nếu trước đó có phân công.
- **Đối chứng SQL**:
  - `SELECT SoDKDoan, TrangThai, TienCoc FROM DangKyDoan WHERE SoDKDoan='DD002';`
  - `SELECT * FROM PhanCongHDV WHERE SoDKDoan='DD002';`
- **Truy vết**: BR04 → UC-02 → Activity-02 → Sequence-02 → FrmDangKyDoan → DangKyDoanService → DangKyDoan/PhanCongHDV → TC-L5-02.
- **Lưu ý**: Nếu hủy DD002 thành công, không lặp lại ca này trừ khi dùng database test mới. Hủy phiếu sau khi đã khởi hành phải bị từ chối.

## Gợi ý chụp ảnh đưa vào báo cáo Word

1. Dán 6 ảnh UML đã export từ file `.puml` (mở bằng VS Code + PlantUML hoặc IDE tương đương), mỗi ảnh có caption và mô tả ngắn phía dưới.
2. Dán ảnh ERD P.21 có sẵn từ Word.
3. Dán ảnh `SELECT COUNT(*) ... = 16`, danh sách bảng và quan hệ trong SSMS.
4. Dán ảnh `FrmMain` và 8 form nghiệp vụ khi chạy `F5`.
5. Dán ảnh nút **Kiểm tra kết nối CSDL** trả về thông báo thành công và kết quả hai test với `SELECT`.

## Phân biệt nguồn

- Các Service nghiệp vụ, Form code-behind, script SQL, Db.cs và App.config **được tách từ tài liệu thầy**.
- 6 sơ đồ UML, UiFactory, các Designer tạo bằng mã, Program, project/solution, KetNoiService, kịch bản kiểm thử bổ sung **là phần triển khai cho LAB5**, cần được thầy/nhóm duyệt phù hợp yêu cầu nộp thực tế.
