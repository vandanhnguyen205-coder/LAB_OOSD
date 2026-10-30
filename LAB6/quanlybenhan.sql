IF DB_ID(N'QuanLyBenhAn') IS NULL CREATE DATABASE QuanLyBenhAn;
GO
USE QuanLyBenhAn;
GO
IF OBJECT_ID('LichHen','U') IS NOT NULL DROP TABLE LichHen;
IF OBJECT_ID('ThanhToanVienPhi','U') IS NOT NULL DROP TABLE ThanhToanVienPhi;
IF OBJECT_ID('ChiTietXetNghiem','U') IS NOT NULL DROP TABLE ChiTietXetNghiem;
IF OBJECT_ID('ChiTietToaThuoc','U') IS NOT NULL DROP TABLE ChiTietToaThuoc;
IF OBJECT_ID('DotKham','U') IS NOT NULL DROP TABLE DotKham;
IF OBJECT_ID('LePhiHangNam','U') IS NOT NULL DROP TABLE LePhiHangNam;
IF OBJECT_ID('HoSoBenhAn','U') IS NOT NULL DROP TABLE HoSoBenhAn;
IF OBJECT_ID('QuyDinhQuyenLoi','U') IS NOT NULL DROP TABLE QuyDinhQuyenLoi;
IF OBJECT_ID('BenhNhan','U') IS NOT NULL DROP TABLE BenhNhan;
IF OBJECT_ID('TaiKhoan','U') IS NOT NULL DROP TABLE TaiKhoan;
IF OBJECT_ID('BacSi','U') IS NOT NULL DROP TABLE BacSi;
IF OBJECT_ID('NhanVien','U') IS NOT NULL DROP TABLE NhanVien;
IF OBJECT_ID('PhongBan','U') IS NOT NULL DROP TABLE PhongBan;
GO
CREATE TABLE PhongBan(
 MaPhongBan varchar(20) NOT NULL PRIMARY KEY,
 TenPhongBan nvarchar(100) NOT NULL UNIQUE,
 LoaiPhongBan nvarchar(50) NOT NULL,
 CONSTRAINT CK_PhongBan_Loai CHECK(LoaiPhongBan IN (N'Khoa điều trị',N'Phòng chức năng'))
);

CREATE TABLE NhanVien(
 MaNV varchar(20) NOT NULL PRIMARY KEY,
 MaPhongBan varchar(20) NOT NULL,
 HoTen nvarchar(120) NOT NULL,
 ChucVu nvarchar(50) NOT NULL,
 SoDienThoai varchar(20) NULL,
 CONSTRAINT FK_NhanVien_PhongBan FOREIGN KEY(MaPhongBan) REFERENCES PhongBan(MaPhongBan)
);

CREATE TABLE BacSi(
 MaBacSi varchar(20) NOT NULL PRIMARY KEY,
 MaPhongBan varchar(20) NOT NULL,
 HoTen nvarchar(120) NOT NULL,
 SoDienThoai varchar(20) NULL,
 CONSTRAINT FK_BacSi_PhongBan FOREIGN KEY(MaPhongBan) REFERENCES PhongBan(MaPhongBan)
);

CREATE TABLE TaiKhoan(
 TenDangNhap varchar(50) NOT NULL PRIMARY KEY,
 MaNV varchar(20) NULL,
 MaBacSi varchar(20) NULL,
 MatKhau varchar(255) NOT NULL,
 VaiTro nvarchar(30) NOT NULL,
 TrangThai nvarchar(20) NOT NULL DEFAULT N'Hoạt động',
 CONSTRAINT CK_TaiKhoan_TrangThai CHECK(TrangThai IN (N'Hoạt động',N'Khóa')),
 CONSTRAINT CK_TaiKhoan_MotVaiTro CHECK(
   (MaNV IS NOT NULL AND MaBacSi IS NULL) OR
   (MaNV IS NULL AND MaBacSi IS NOT NULL)
 ),
 CONSTRAINT FK_TaiKhoan_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV),
 CONSTRAINT FK_TaiKhoan_BacSi FOREIGN KEY(MaBacSi) REFERENCES BacSi(MaBacSi)
);

CREATE TABLE BenhNhan(
 MaBenhNhan varchar(20) NOT NULL PRIMARY KEY,
 HoTen nvarchar(120) NOT NULL,
 DiaChi nvarchar(200) NOT NULL,
 NgaySinh date NOT NULL,
 SoDienThoai varchar(20) NOT NULL,
 Anh3x4 varchar(255) NULL,
 CONSTRAINT CK_BenhNhan_NgaySinh CHECK(NgaySinh <= GETDATE())
);

CREATE TABLE QuyDinhQuyenLoi(
 MaQuyDinh varchar(20) NOT NULL PRIMARY KEY,
 TenQuyenLoi nvarchar(100) NOT NULL,
 ChuKyKham nvarchar(20) NOT NULL,
 SoLanMienPhi int NOT NULL CHECK(SoLanMienPhi > 0),
 MucLePhi decimal(18,2) NOT NULL CHECK(MucLePhi >= 0),
 NgayApDung date NOT NULL
);

CREATE TABLE HoSoBenhAn(
 MaHoSo varchar(20) NOT NULL PRIMARY KEY,
 MaBenhNhan varchar(20) NOT NULL UNIQUE,
 NgayCap date NOT NULL,
 TrangThai nvarchar(20) NOT NULL DEFAULT N'Hieu luc',
 CONSTRAINT CK_HoSo_TrangThai CHECK(TrangThai IN (N'Hieu luc',N'Het han')),
 CONSTRAINT FK_HoSo_BenhNhan FOREIGN KEY(MaBenhNhan) REFERENCES BenhNhan(MaBenhNhan)
);

CREATE TABLE LePhiHangNam(
 MaLePhi varchar(20) NOT NULL PRIMARY KEY,
 MaHoSo varchar(20) NOT NULL,
 MaQuyDinh varchar(20) NOT NULL,
 MaNV varchar(20) NOT NULL,
 KyDong int NOT NULL CHECK(KyDong > 0),
 SoTien decimal(18,2) NOT NULL CHECK(SoTien >= 0),
 NgayDong date NOT NULL,
 NgayHetHan date NOT NULL,
 TrangThai nvarchar(20) NOT NULL DEFAULT N'Da dong',
 CONSTRAINT CK_LePhi_Ngay CHECK(NgayHetHan >= NgayDong),
 CONSTRAINT CK_LePhi_TrangThai CHECK(TrangThai IN (N'Da dong',N'Qua han')),
 CONSTRAINT UQ_LePhi_HoSo_Ky UNIQUE(MaHoSo,KyDong),
 CONSTRAINT FK_LePhi_HoSo FOREIGN KEY(MaHoSo) REFERENCES HoSoBenhAn(MaHoSo),
 CONSTRAINT FK_LePhi_QuyDinh FOREIGN KEY(MaQuyDinh) REFERENCES QuyDinhQuyenLoi(MaQuyDinh),
 CONSTRAINT FK_LePhi_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

CREATE TABLE DotKham(
 MaDotKham varchar(20) NOT NULL PRIMARY KEY,
 MaHoSo varchar(20) NOT NULL,
 MaBacSi varchar(20) NOT NULL,
 MaPhongBan varchar(20) NOT NULL,
 MaNV varchar(20) NOT NULL,
 NgayGioKham datetime NOT NULL CHECK(NgayGioKham <= GETDATE()),
 LoaiKham nvarchar(20) NOT NULL,
 TrieuChung nvarchar(max) NULL,
 DienBienBenh nvarchar(max) NULL,
 HieuQuaDieuTri nvarchar(max) NULL,
 NgayXuatVien date NULL,
 TrangThai nvarchar(20) NOT NULL DEFAULT N'Da ghi nhan',
 CONSTRAINT CK_DotKham_Loai CHECK(LoaiKham IN (N'Dieu tri',N'Dinh ky')),
 CONSTRAINT CK_DotKham_TrangThai CHECK(TrangThai IN (N'Da ghi nhan',N'Da danh gia',N'Da luu tru')),
 CONSTRAINT FK_DotKham_HoSo FOREIGN KEY(MaHoSo) REFERENCES HoSoBenhAn(MaHoSo),
 CONSTRAINT FK_DotKham_BacSi FOREIGN KEY(MaBacSi) REFERENCES BacSi(MaBacSi),
 CONSTRAINT FK_DotKham_PhongBan FOREIGN KEY(MaPhongBan) REFERENCES PhongBan(MaPhongBan),
 CONSTRAINT FK_DotKham_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

CREATE TABLE ChiTietToaThuoc(
 MaDotKham varchar(20) NOT NULL,
 TenThuoc nvarchar(100) NOT NULL,
 LieuDung nvarchar(100) NULL,
 SoLuong int NOT NULL CHECK(SoLuong > 0),
 PhanUngThuoc nvarchar(200) NULL,
 PRIMARY KEY(MaDotKham,TenThuoc),
 CONSTRAINT FK_ToaThuoc_DotKham FOREIGN KEY(MaDotKham) REFERENCES DotKham(MaDotKham)
);

CREATE TABLE ChiTietXetNghiem(
 MaDotKham varchar(20) NOT NULL,
 LoaiXetNghiem nvarchar(100) NOT NULL,
 YeuCau nvarchar(200) NULL,
 KetQua nvarchar(200) NULL,
 PRIMARY KEY(MaDotKham,LoaiXetNghiem),
 CONSTRAINT FK_XetNghiem_DotKham FOREIGN KEY(MaDotKham) REFERENCES DotKham(MaDotKham)
);

CREATE TABLE ThanhToanVienPhi(
 MaThanhToan varchar(20) NOT NULL PRIMARY KEY,
 MaDotKham varchar(20) NOT NULL UNIQUE,
 MaNV varchar(20) NOT NULL,
 NgayThanhToan datetime NOT NULL,
 SoTien decimal(18,2) NOT NULL CHECK(SoTien >= 0),
 TrangThai nvarchar(20) NOT NULL DEFAULT N'Da thanh toan',
 CONSTRAINT CK_ThanhToan_TrangThai CHECK(TrangThai IN (N'Da thanh toan')),
 CONSTRAINT FK_ThanhToan_DotKham FOREIGN KEY(MaDotKham) REFERENCES DotKham(MaDotKham),
 CONSTRAINT FK_ThanhToan_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

CREATE TABLE LichHen(
 MaLichHen varchar(20) NOT NULL PRIMARY KEY,
 MaHoSo varchar(20) NOT NULL,
 MaBacSi varchar(20) NULL,
 MaPhongBan varchar(20) NOT NULL,
 NgayGioHen datetime NOT NULL CHECK(NgayGioHen > GETDATE()),
 LyDo nvarchar(200) NULL,
 TrangThai nvarchar(20) NOT NULL DEFAULT N'Cho xac nhan',
 CONSTRAINT CK_LichHen_TrangThai CHECK(TrangThai IN (N'Cho xac nhan',N'Da xac nhan',N'Da huy')),
 CONSTRAINT FK_LichHen_HoSo FOREIGN KEY(MaHoSo) REFERENCES HoSoBenhAn(MaHoSo),
 CONSTRAINT FK_LichHen_BacSi FOREIGN KEY(MaBacSi) REFERENCES BacSi(MaBacSi),
 CONSTRAINT FK_LichHen_PhongBan FOREIGN KEY(MaPhongBan) REFERENCES PhongBan(MaPhongBan)
);