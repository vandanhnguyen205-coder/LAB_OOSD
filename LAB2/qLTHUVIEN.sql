
CREATE DATABASE QuanLyThuVienDB;
-- =============================================
-- 1. BẢNG NHÂN VIÊN
-- =============================================
CREATE TABLE NhanVien (
    MaNhanVien VARCHAR(10) PRIMARY KEY,
    Ho NVARCHAR(30) NOT NULL,
    Ten NVARCHAR(10) NOT NULL,
    Phai NVARCHAR(3) CHECK (Phai IN (N'Nam', N'Nữ')),
    NgaySinh DATE NULL,
    ChucVu NVARCHAR(30) NOT NULL,
    SoDienThoai VARCHAR(15) NULL
);

-- =============================================
-- 2. BẢNG THỂ LOẠI
-- =============================================
CREATE TABLE TheLoai (
    MaTheLoai VARCHAR(10) PRIMARY KEY,
    TenTheLoai NVARCHAR(50) NOT NULL
);

-- =============================================
-- 3. BẢNG NHÀ XUẤT BẢN
-- (Không có TenNXB theo đúng yêu cầu)
-- =============================================
CREATE TABLE NhaXuatBan (
    MaNhaXuatBan VARCHAR(10) PRIMARY KEY,
    DiaChi NVARCHAR(200) NULL,
    SoDienThoai VARCHAR(15) NULL
);

-- =============================================
-- 4. BẢNG ĐẦU SÁCH
-- =============================================
CREATE TABLE DauSach (
    MaDauSach VARCHAR(10) PRIMARY KEY,
    TenSach NVARCHAR(150) NOT NULL,
    NamXuatBan INT CHECK (NamXuatBan <= YEAR(GETDATE())),
    SoLuongHienCo INT DEFAULT 0 CHECK (SoLuongHienCo >= 0),
    MaTheLoai VARCHAR(10) NOT NULL,
    MaNhaXuatBan VARCHAR(10) NOT NULL,
    FOREIGN KEY (MaTheLoai) REFERENCES TheLoai(MaTheLoai),
    FOREIGN KEY (MaNhaXuatBan) REFERENCES NhaXuatBan(MaNhaXuatBan)
);

-- =============================================
-- 5. BẢNG ĐỘC GIẢ
-- =============================================
CREATE TABLE DocGia (
    MaDocGia VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(50) NOT NULL,
    NgaySinh DATE NULL,
    Phai NVARCHAR(3) CHECK (Phai IN (N'Nam', N'Nữ')),
    SoDienThoai VARCHAR(15) NULL,
    DiaChi NVARCHAR(200) NULL,
    Email VARCHAR(100) NULL,
    Anh3x4 VARCHAR(255) NULL
);

-- =============================================
-- 6. BẢNG THẺ ĐỘC GIẢ
-- =============================================
CREATE TABLE TheDocGia (
    MaThe VARCHAR(10) PRIMARY KEY,
    MaDocGia VARCHAR(10) NOT NULL,
    NgayCap DATE DEFAULT GETDATE(),
    HanSuDung DATE NOT NULL,
    LePhiDaDong BIT DEFAULT 1,
    TrangThaiHoatDong BIT DEFAULT 1,
    FOREIGN KEY (MaDocGia) REFERENCES DocGia(MaDocGia),
    CONSTRAINT CHK_HanSuDung CHECK (HanSuDung >= NgayCap)
);
GO

-- Đảm bảo tại một thời điểm mỗi độc giả chỉ có 1 thẻ đang hoạt động
CREATE UNIQUE INDEX UIX_DocGia_TheHoatDong 
ON TheDocGia(MaDocGia) 
WHERE TrangThaiHoatDong = 1;
GO

-- =============================================
-- 7. BẢNG PHIẾU MƯỢN
-- =============================================
CREATE TABLE PhieuMuon (
    MaPhieuMuon VARCHAR(10) PRIMARY KEY,
    MaThe VARCHAR(10) NOT NULL,
    MaNhanVien VARCHAR(10) NOT NULL,
    NgayMuon DATETIME DEFAULT GETDATE(),
    NgayHenTra DATE NOT NULL,
    FOREIGN KEY (MaThe) REFERENCES TheDocGia(MaThe),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- =============================================
-- 8. BẢNG CHI TIẾT PHIẾU MƯỢN
-- =============================================
CREATE TABLE ChiTietPhieuMuon (
    MaChiTiet VARCHAR(10) PRIMARY KEY,
    MaPhieuMuon VARCHAR(10) NOT NULL,
    MaDauSach VARCHAR(10) NOT NULL,
    NgayTraThucTe DATE NULL,
    TinhTrangTra NVARCHAR(50) DEFAULT N'Đang mượn',
    FOREIGN KEY (MaPhieuMuon) REFERENCES PhieuMuon(MaPhieuMuon),
    FOREIGN KEY (MaDauSach) REFERENCES DauSach(MaDauSach),
    CONSTRAINT UQ_Phieu_DauSach UNIQUE (MaPhieuMuon, MaDauSach)
);

-- =============================================
-- 9. BẢNG PHIẾU PHẠT
-- =============================================
CREATE TABLE PhieuPhat (
    MaPhieuPhat VARCHAR(10) PRIMARY KEY,
    MaChiTiet VARCHAR(10) NOT NULL,
    MaNhanVien VARCHAR(10) NOT NULL,
    NgayPhat DATETIME DEFAULT GETDATE(),
    LyDo NVARCHAR(200) NOT NULL,
    PhiPhat DECIMAL(18,2) DEFAULT 0 CHECK (PhiPhat >= 0),
    FOREIGN KEY (MaChiTiet) REFERENCES ChiTietPhieuMuon(MaChiTiet),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);
GO