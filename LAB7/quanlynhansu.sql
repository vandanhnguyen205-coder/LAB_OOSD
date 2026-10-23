IF DB_ID(N'QuanLyNhanSu') IS NULL CREATE DATABASE QuanLyNhanSu;
GO
USE QuanLyNhanSu;
GO
IF OBJECT_ID('PhieuThuPhat','U') IS NOT NULL DROP TABLE PhieuThuPhat;
IF OBJECT_ID('QuyetDinhKyLuat','U') IS NOT NULL DROP TABLE QuyetDinhKyLuat;
IF OBJECT_ID('PhieuChiThuong','U') IS NOT NULL DROP TABLE PhieuChiThuong;
IF OBJECT_ID('QuyetDinhKhenThuong','U') IS NOT NULL DROP TABLE QuyetDinhKhenThuong;
IF OBJECT_ID('ChiTietPhuTroi','U') IS NOT NULL DROP TABLE ChiTietPhuTroi;
IF OBJECT_ID('PhieuPhuTroi','U') IS NOT NULL DROP TABLE PhieuPhuTroi;
IF OBJECT_ID('KeHoachTuan','U') IS NOT NULL DROP TABLE KeHoachTuan;
IF OBJECT_ID('BangChamCong','U') IS NOT NULL DROP TABLE BangChamCong;
IF OBJECT_ID('HoSoBaoHiem','U') IS NOT NULL DROP TABLE HoSoBaoHiem;
IF OBJECT_ID('QuyetDinhChucVu','U') IS NOT NULL DROP TABLE QuyetDinhChucVu;
IF OBJECT_ID('QuyetDinhLuong','U') IS NOT NULL DROP TABLE QuyetDinhLuong;
IF OBJECT_ID('HopDong','U') IS NOT NULL DROP TABLE HopDong;
IF OBJECT_ID('QuyetDinhTuyenDung','U') IS NOT NULL DROP TABLE QuyetDinhTuyenDung;
IF OBJECT_ID('NhanVien','U') IS NOT NULL DROP TABLE NhanVien;
IF OBJECT_ID('ChucVu','U') IS NOT NULL DROP TABLE ChucVu;
IF OBJECT_ID('PhongBan','U') IS NOT NULL DROP TABLE PhongBan;
GO
CREATE TABLE PhongBan(
 MaPB varchar(20) NOT NULL PRIMARY KEY,
 TenPB nvarchar(120) NOT NULL UNIQUE,
 LoaiDonVi nvarchar(30) NOT NULL,
 CONSTRAINT CK_PB_Loai CHECK(LoaiDonVi IN (N'Phòng',N'Ban',N'Phân xưởng'))
);
CREATE TABLE ChucVu(
 MaCV varchar(20) NOT NULL PRIMARY KEY,
 TenCV nvarchar(120) NOT NULL UNIQUE
);
CREATE TABLE NhanVien(
 MaNV varchar(20) NOT NULL PRIMARY KEY,
 HoTen nvarchar(120) NOT NULL,
 NgaySinh date NULL,
 GioiTinh nvarchar(10) NULL CHECK(GioiTinh IN (N'Nam',N'Nữ')),
 DienThoai varchar(20) NULL,
 DiaChi nvarchar(250) NULL,
 MaPB varchar(20) NOT NULL,
 TrangThai nvarchar(30) NOT NULL DEFAULT N'Thử việc',
 CONSTRAINT CK_NV_TrangThai CHECK(TrangThai IN (N'Thử việc',N'Chính thức',N'Nghỉ việc')),
 CONSTRAINT FK_NV_PB FOREIGN KEY(MaPB) REFERENCES PhongBan(MaPB)
);
CREATE TABLE QuyetDinhTuyenDung(
 SoQD varchar(20) NOT NULL PRIMARY KEY,
 MaNV varchar(20) NOT NULL,
 MaPB varchar(20) NOT NULL,
 NgayQD date NOT NULL,
 NgayBatDauThuViec date NOT NULL,
 NgayKetThucThuViec date NOT NULL,
 LuongThuViec decimal(18,2) NOT NULL CHECK(LuongThuViec>=0),
 DieuKhoan nvarchar(1000) NULL,
 CONSTRAINT UQ_QDTD_NV UNIQUE(MaNV),
 CONSTRAINT FK_QDTD_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV),
 CONSTRAINT FK_QDTD_PB FOREIGN KEY(MaPB) REFERENCES PhongBan(MaPB),
 CONSTRAINT CK_QDTD_Ngay CHECK(NgayKetThucThuViec>=NgayBatDauThuViec)
);
CREATE TABLE HopDong(
 SoHD varchar(20) NOT NULL PRIMARY KEY,
 MaNV varchar(20) NOT NULL,
 LoaiHD varchar(10) NOT NULL,
 NgayKy date NOT NULL,
 NgayBatDau date NOT NULL,
 NgayKetThuc date NULL,
 CONSTRAINT CK_HD_Loai CHECK(LoaiHD IN ('DAIHAN','NGANHAN')),
 CONSTRAINT CK_HD_Ngay CHECK(NgayKetThuc IS NULL OR NgayKetThuc>=NgayBatDau),
 CONSTRAINT FK_HD_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);
CREATE TABLE QuyetDinhLuong(
 SoQD varchar(20) NOT NULL PRIMARY KEY,
 MaNV varchar(20) NOT NULL,
 NgayHieuLuc date NOT NULL,
 LuongCoBan decimal(18,2) NOT NULL CHECK(LuongCoBan>0),
 PhuCapLuong decimal(18,2) NOT NULL DEFAULT 0 CHECK(PhuCapLuong>=0),
 PhuCapDocHai decimal(18,2) NOT NULL DEFAULT 0 CHECK(PhuCapDocHai>=0),
 LyDo nvarchar(200) NULL,
 CONSTRAINT FK_QDL_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);
CREATE TABLE QuyetDinhChucVu(
 SoQD varchar(20) NOT NULL PRIMARY KEY,
 MaNV varchar(20) NOT NULL,
 MaCV varchar(20) NOT NULL,
 NgayHieuLuc date NOT NULL,
 PhuCapChucVu decimal(18,2) NOT NULL DEFAULT 0 CHECK(PhuCapChucVu>=0),
 CONSTRAINT FK_QDCV_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV),
 CONSTRAINT FK_QDCV_CV FOREIGN KEY(MaCV) REFERENCES ChucVu(MaCV)
);
CREATE TABLE HoSoBaoHiem(
 MaHS varchar(20) NOT NULL PRIMARY KEY,
 MaNV varchar(20) NOT NULL,
 SoHD varchar(20) NOT NULL,
 SoBHXH varchar(30) NULL,
 SoBHYT varchar(30) NULL,
 TyLeBHXH decimal(5,2) NOT NULL CHECK(TyLeBHXH>=0),
 TyLeBHYT decimal(5,2) NOT NULL CHECK(TyLeBHYT>=0),
 NgayLap date NOT NULL,
 CONSTRAINT UQ_BH_HD UNIQUE(SoHD),
 CONSTRAINT FK_BH_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV),
 CONSTRAINT FK_BH_HD FOREIGN KEY(SoHD) REFERENCES HopDong(SoHD)
);
CREATE TABLE BangChamCong(
 MaNV varchar(20) NOT NULL,
 Thang int NOT NULL CHECK(Thang BETWEEN 1 AND 12),
 Nam int NOT NULL CHECK(Nam>2000),
 NgayCongChuan decimal(4,1) NOT NULL CHECK(NgayCongChuan>0),
 SoNgayCong decimal(4,1) NOT NULL CHECK(SoNgayCong>=0),
 PRIMARY KEY(MaNV,Thang,Nam),
 CONSTRAINT CK_CC_Cong CHECK(SoNgayCong<=NgayCongChuan),
 CONSTRAINT FK_CC_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);
CREATE TABLE KeHoachTuan(
 MaKH varchar(20) NOT NULL PRIMARY KEY,
 MaPB varchar(20) NOT NULL,
 TuNgay date NOT NULL,
 DenNgay date NOT NULL,
 NoiDungPhanCong nvarchar(1000) NOT NULL,
 GioPhuTroiDuKien decimal(6,1) NOT NULL DEFAULT 0 CHECK(GioPhuTroiDuKien>=0),
 NguoiLap nvarchar(120) NOT NULL,
 CONSTRAINT CK_KH_Ngay CHECK(DenNgay>=TuNgay),
 CONSTRAINT FK_KH_PB FOREIGN KEY(MaPB) REFERENCES PhongBan(MaPB)
);
CREATE TABLE PhieuPhuTroi(
 SoPhieu varchar(20) NOT NULL PRIMARY KEY,
 MaPB varchar(20) NOT NULL,
 NgayPhuTroi date NOT NULL,
 SoGio decimal(4,1) NOT NULL,
 HinhThuc nvarchar(20) NOT NULL,
 CONSTRAINT CK_PT_Gio CHECK(SoGio>0 AND SoGio<=24),
 CONSTRAINT CK_PT_HinhThuc CHECK(HinhThuc IN (N'Tăng ca',N'Ngày lễ',N'Ngày nghỉ')),
 CONSTRAINT FK_PT_PB FOREIGN KEY(MaPB) REFERENCES PhongBan(MaPB)
);
CREATE TABLE ChiTietPhuTroi(
 SoPhieu varchar(20) NOT NULL,
 MaNV varchar(20) NOT NULL,
 PRIMARY KEY(SoPhieu,MaNV),
 CONSTRAINT FK_CTPT_Phieu FOREIGN KEY(SoPhieu) REFERENCES PhieuPhuTroi(SoPhieu),
 CONSTRAINT FK_CTPT_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);
CREATE TABLE QuyetDinhKhenThuong(
 SoQD varchar(20) NOT NULL PRIMARY KEY,
 NgayQD date NOT NULL,
 LoaiDoiTuong varchar(10) NOT NULL,
 MaNV varchar(20) NULL,
 MaPB varchar(20) NULL,
 LoaiKhenThuong nvarchar(40) NOT NULL,
 SoTien decimal(18,2) NOT NULL CHECK(SoTien>0),
 NguoiKy nvarchar(120) NOT NULL,
 CONSTRAINT CK_KT_Loai CHECK(LoaiKhenThuong IN (N'Thành tích',N'Thưởng ngày lễ',N'Thưởng cuối năm',N'Lương tháng 13')),
 CONSTRAINT FK_KT_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV),
 CONSTRAINT FK_KT_PB FOREIGN KEY(MaPB) REFERENCES PhongBan(MaPB),
 CONSTRAINT CK_KT_Target CHECK((LoaiDoiTuong='CANHAN' AND MaNV IS NOT NULL AND MaPB IS NULL) OR (LoaiDoiTuong='TAPTHE' AND MaPB IS NOT NULL AND MaNV IS NULL))
);
CREATE TABLE PhieuChiThuong(
 SoPhieuChi varchar(20) NOT NULL PRIMARY KEY,
 SoQD varchar(20) NOT NULL,
 NgayLap date NOT NULL,
 SoTien decimal(18,2) NOT NULL CHECK(SoTien>0),
 HinhThuc nvarchar(20) NOT NULL,
 CONSTRAINT UQ_PC_QD UNIQUE(SoQD),
 CONSTRAINT CK_PC_HinhThuc CHECK(HinhThuc IN (N'Chi tiền',N'Cộng vào lương')),
 CONSTRAINT FK_PC_QD FOREIGN KEY(SoQD) REFERENCES QuyetDinhKhenThuong(SoQD)
);
CREATE TABLE QuyetDinhKyLuat(
 SoQD varchar(20) NOT NULL PRIMARY KEY,
 NgayQD date NOT NULL,
 LoaiDoiTuong varchar(10) NOT NULL,
 MaNV varchar(20) NULL,
 MaPB varchar(20) NULL,
 HinhThucKyLuat nvarchar(60) NOT NULL,
 SoTienPhat decimal(18,2) NOT NULL DEFAULT 0 CHECK(SoTienPhat>=0),
 NguoiKy nvarchar(120) NOT NULL,
 CONSTRAINT FK_KL_NV FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV),
 CONSTRAINT FK_KL_PB FOREIGN KEY(MaPB) REFERENCES PhongBan(MaPB),
 CONSTRAINT CK_KL_Target CHECK((LoaiDoiTuong='CANHAN' AND MaNV IS NOT NULL AND MaPB IS NULL) OR (LoaiDoiTuong='TAPTHE' AND MaPB IS NOT NULL AND MaNV IS NULL))
);
CREATE TABLE PhieuThuPhat(
 SoPhieuThu varchar(20) NOT NULL PRIMARY KEY,
 SoQD varchar(20) NOT NULL,
 NgayLap date NOT NULL,
 SoTien decimal(18,2) NOT NULL CHECK(SoTien>0),
 HinhThuc nvarchar(20) NOT NULL,
 CONSTRAINT UQ_TP_QD UNIQUE(SoQD),
 CONSTRAINT CK_TP_HinhThuc CHECK(HinhThuc IN (N'Thu tiền',N'Trừ vào lương')),
 CONSTRAINT FK_TP_QD FOREIGN KEY(SoQD) REFERENCES QuyetDinhKyLuat(SoQD)
);
GO

INSERT INTO PhongBan(MaPB,TenPB,LoaiDonVi) VALUES
('PB01',N'Phòng Nhân sự',N'Phòng'),('PB02',N'Phòng Kế toán',N'Phòng'),
('PB03',N'Phân xưởng Sản xuất sơn',N'Phân xưởng'),('PB04',N'Ban Chấm công',N'Ban');
INSERT INTO ChucVu(MaCV,TenCV) VALUES
('CV01',N'Nhân viên'),('CV02',N'Tổ trưởng'),('CV03',N'Trưởng phòng'),('CV04',N'Giám đốc');
INSERT INTO NhanVien(MaNV,HoTen,NgaySinh,GioiTinh,DienThoai,DiaChi,MaPB,TrangThai) VALUES
('NV001',N'Nguyễn Văn An','19900515',N'Nam','0901000001',N'12 Lê Lợi, Quận 1, TP.HCM','PB03',N'Chính thức'),
('NV002',N'Trần Thị Bích','19920320',N'Nữ','0901000002',N'45 Nguyễn Huệ, Quận 1, TP.HCM','PB02',N'Chính thức'),
('NV003',N'Lê Quang Cường','19950710',N'Nam','0901000003',N'8 Cách Mạng Tháng 8, Quận 3, TP.HCM','PB03',N'Chính thức'),
('NV004',N'Phạm Thu Dung','20001102',N'Nữ','0901000004',N'30 Võ Văn Tần, Quận 3, TP.HCM','PB01',N'Thử việc');
INSERT INTO QuyetDinhTuyenDung(SoQD,MaNV,MaPB,NgayQD,NgayBatDauThuViec,NgayKetThucThuViec,LuongThuViec,DieuKhoan) VALUES
('QDTD001','NV001','PB03','20250101','20250102','20250301',6000000,N'Thử việc 2 tháng, hưởng 100% lương thử việc'),
('QDTD002','NV002','PB02','20250101','20250102','20250301',6500000,N'Thử việc 2 tháng, hưởng 100% lương thử việc'),
('QDTD003','NV003','PB03','20250101','20250102','20250301',5500000,N'Thử việc 2 tháng, hưởng 100% lương thử việc'),
('QDTD004','NV004','PB01','20260930','20261001','20261130',5500000,N'Thử việc 2 tháng, hưởng 100% lương thử việc');
INSERT INTO HopDong(SoHD,MaNV,LoaiHD,NgayKy,NgayBatDau,NgayKetThuc) VALUES
('HD001','NV001','DAIHAN','20250302','20250302',NULL),
('HD002','NV002','DAIHAN','20250302','20250302',NULL),
('HD003','NV003','NGANHAN','20250302','20250302','20270301');
INSERT INTO QuyetDinhLuong(SoQD,MaNV,NgayHieuLuc,LuongCoBan,PhuCapLuong,PhuCapDocHai,LyDo) VALUES
('QDL001','NV001','20250302',10400000,500000,800000,N'Lương chính thức'),
('QDL002','NV002','20250302',12480000,0,0,N'Lương chính thức'),
('QDL003','NV003','20250302',9360000,0,800000,N'Lương chính thức'),
('QDL004','NV001','20260701',11440000,500000,800000,N'Tăng lương');
INSERT INTO QuyetDinhChucVu(SoQD,MaNV,MaCV,NgayHieuLuc,PhuCapChucVu) VALUES
('QDCV001','NV002','CV03','20250302',2000000),
('QDCV002','NV001','CV02','20260701',1000000);
INSERT INTO HoSoBaoHiem(MaHS,MaNV,SoHD,SoBHXH,SoBHYT,TyLeBHXH,TyLeBHYT,NgayLap) VALUES
('HS001','NV001','HD001','7901234567','DN4797901234',8,1.5,'20250302'),
('HS002','NV002','HD002','7902345678','DN4797902345',8,1.5,'20250302');
INSERT INTO BangChamCong(MaNV,Thang,Nam,NgayCongChuan,SoNgayCong) VALUES
('NV001',9,2026,26,26),('NV002',9,2026,26,25),('NV003',9,2026,26,24);
INSERT INTO KeHoachTuan(MaKH,MaPB,TuNgay,DenNgay,NoiDungPhanCong,GioPhuTroiDuKien,NguoiLap) VALUES
('KH001','PB03','20260907','20260913',N'Sản xuất lô sơn nội thất, dự kiến tăng ca ngày 12/09',4,N'Tổ trưởng Nguyễn Văn An');
INSERT INTO PhieuPhuTroi(SoPhieu,MaPB,NgayPhuTroi,SoGio,HinhThuc) VALUES
('PT001','PB03','20260912',4,N'Tăng ca'),('PT002','PB03','20260902',8,N'Ngày lễ');
INSERT INTO ChiTietPhuTroi(SoPhieu,MaNV) VALUES ('PT001','NV001'),('PT001','NV003'),('PT002','NV001');
INSERT INTO QuyetDinhKhenThuong(SoQD,NgayQD,LoaiDoiTuong,MaNV,MaPB,LoaiKhenThuong,SoTien,NguoiKy) VALUES
('KT001','20260910','CANHAN','NV002',NULL,N'Thành tích',1000000,N'Giám đốc Nguyễn Hoàng Long'),
('KT002','20260901','TAPTHE',NULL,'PB03',N'Thưởng ngày lễ',500000,N'Giám đốc Nguyễn Hoàng Long');
INSERT INTO PhieuChiThuong(SoPhieuChi,SoQD,NgayLap,SoTien,HinhThuc) VALUES
('PC001','KT001','20260930',1000000,N'Cộng vào lương'),('PC002','KT002','20260902',500000,N'Cộng vào lương');
INSERT INTO QuyetDinhKyLuat(SoQD,NgayQD,LoaiDoiTuong,MaNV,MaPB,HinhThucKyLuat,SoTienPhat,NguoiKy) VALUES
('KL001','20260915','CANHAN','NV003',NULL,N'Phạt tiền (đi trễ nhiều lần)',200000,N'Giám đốc Nguyễn Hoàng Long');
INSERT INTO PhieuThuPhat(SoPhieuThu,SoQD,NgayLap,SoTien,HinhThuc) VALUES ('TP001','KL001','20260915',200000,N'Trừ vào lương');
GO
