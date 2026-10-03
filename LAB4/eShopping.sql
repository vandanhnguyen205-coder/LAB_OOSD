/* ==========================================================
   CSDL e-SHOPPING - SQL Server
   Gồm: DROP (con trước, cha sau) -> CREATE (cha trước, con sau)
        -> dữ liệu mẫu cho các bảng danh mục
   ========================================================== */

IF DB_ID(N'eShopping') IS NULL
    CREATE DATABASE eShopping;
GO

USE eShopping;
GO

/* ==========================================================
   1. XÓA BẢNG NẾU ĐÃ TỒN TẠI
      Thứ tự: bảng con (chứa khóa ngoại) trước, bảng cha sau
   ========================================================== */
IF OBJECT_ID('CHITIETDONHANG', 'U') IS NOT NULL DROP TABLE CHITIETDONHANG;
IF OBJECT_ID('DONDATHANG',     'U') IS NOT NULL DROP TABLE DONDATHANG;
IF OBJECT_ID('MUCGIOHANG',     'U') IS NOT NULL DROP TABLE MUCGIOHANG;
IF OBJECT_ID('GIOHANG',        'U') IS NOT NULL DROP TABLE GIOHANG;
IF OBJECT_ID('THETINDUNG',     'U') IS NOT NULL DROP TABLE THETINDUNG;
IF OBJECT_ID('NGUOINHAN',      'U') IS NOT NULL DROP TABLE NGUOINHAN;
IF OBJECT_ID('SANPHAM',        'U') IS NOT NULL DROP TABLE SANPHAM;
IF OBJECT_ID('NHOMSANPHAM',    'U') IS NOT NULL DROP TABLE NHOMSANPHAM;
IF OBJECT_ID('LOAITHE',        'U') IS NOT NULL DROP TABLE LOAITHE;
IF OBJECT_ID('LOAIPHIEU',      'U') IS NOT NULL DROP TABLE LOAIPHIEU;
IF OBJECT_ID('KHUVUCGIAO',     'U') IS NOT NULL DROP TABLE KHUVUCGIAO;
IF OBJECT_ID('KHACHHANG',      'U') IS NOT NULL DROP TABLE KHACHHANG;
GO

/* ==========================================================
   2. TẠO BẢNG (bảng cha trước, bảng con sau)
   ========================================================== */

-- 2.1 KHACHHANG
CREATE TABLE KHACHHANG (
    MaKH            INT IDENTITY(1,1) NOT NULL,
    HoTen           NVARCHAR(100) NOT NULL,
    NgaySinh        DATE          NOT NULL,
    SoCMND_Passport NVARCHAR(20)  NOT NULL,
    DiaChi          NVARCHAR(200) NOT NULL,
    DienThoai       NVARCHAR(15)  NOT NULL,
    TenDangNhap     NVARCHAR(50)  NOT NULL,
    MatKhau         NVARCHAR(255) NOT NULL,   -- lưu chuỗi đã băm
    Email           NVARCHAR(100) NULL,       -- tùy chọn
    CONSTRAINT PK_KHACHHANG PRIMARY KEY (MaKH),
    CONSTRAINT UQ_KHACHHANG_TenDangNhap UNIQUE (TenDangNhap),
    CONSTRAINT CK_KHACHHANG_Email
        CHECK (Email IS NULL OR Email LIKE '%_@_%._%')
);
GO

-- 2.2 NHOMSANPHAM (đồng bộ từ HT Quản lý sản phẩm)
CREATE TABLE NHOMSANPHAM (
    MaNhom  NVARCHAR(20)  NOT NULL,
    TenNhom NVARCHAR(100) NOT NULL,
    CONSTRAINT PK_NHOMSANPHAM PRIMARY KEY (MaNhom)
);
GO

-- 2.3 SANPHAM (đồng bộ từ HT Quản lý sản phẩm)
CREATE TABLE SANPHAM (
    MaSP           NVARCHAR(20)  NOT NULL,
    MaNhom         NVARCHAR(20)  NOT NULL,
    TenSP          NVARCHAR(200) NOT NULL,
    NhaSanXuat     NVARCHAR(100) NULL,
    HinhAnh        NVARCHAR(255) NULL,
    MoTa           NVARCHAR(MAX) NULL,
    ThongSoKyThuat NVARCHAR(MAX) NULL,
    GiaBan         DECIMAL(18,0) NOT NULL,
    TinhTrang      BIT           NOT NULL CONSTRAINT DF_SANPHAM_TinhTrang DEFAULT 1,
    CONSTRAINT PK_SANPHAM PRIMARY KEY (MaSP),
    CONSTRAINT FK_SANPHAM_NHOMSANPHAM FOREIGN KEY (MaNhom)
        REFERENCES NHOMSANPHAM (MaNhom),
    CONSTRAINT CK_SANPHAM_GiaBan CHECK (GiaBan >= 0)
);
GO

-- 2.4 LOAIPHIEU
CREATE TABLE LOAIPHIEU (
    MaLoaiPhieu   INT IDENTITY(1,1) NOT NULL,
    TenLoai       NVARCHAR(50)  NOT NULL,
    DonGia        DECIMAL(18,0) NOT NULL,
    ThoiGianXuLy  NVARCHAR(50)  NOT NULL,
    NguongMienPhi DECIMAL(18,0) NULL,         -- NULL: không có ngưỡng miễn phí
    CONSTRAINT PK_LOAIPHIEU PRIMARY KEY (MaLoaiPhieu),
    CONSTRAINT UQ_LOAIPHIEU_TenLoai UNIQUE (TenLoai),
    CONSTRAINT CK_LOAIPHIEU_DonGia CHECK (DonGia >= 0),
    CONSTRAINT CK_LOAIPHIEU_NguongMienPhi
        CHECK (NguongMienPhi IS NULL OR NguongMienPhi >= 0)
);
GO

-- 2.5 KHUVUCGIAO
CREATE TABLE KHUVUCGIAO (
    MaKV   INT IDENTITY(1,1) NOT NULL,
    TenKV  NVARCHAR(100) NOT NULL,
    PhiGiao DECIMAL(18,0) NOT NULL,
    CONSTRAINT PK_KHUVUCGIAO PRIMARY KEY (MaKV),
    CONSTRAINT CK_KHUVUCGIAO_PhiGiao CHECK (PhiGiao >= 0)
);
GO

-- 2.6 LOAITHE
CREATE TABLE LOAITHE (
    MaLoaiThe  INT IDENTITY(1,1) NOT NULL,
    TenLoai    NVARCHAR(50)  NOT NULL,
    DoDaiSoThe INT           NOT NULL,
    DoDaiCSV   INT           NOT NULL,
    LePhi      DECIMAL(18,0) NOT NULL,
    CONSTRAINT PK_LOAITHE PRIMARY KEY (MaLoaiThe),
    CONSTRAINT UQ_LOAITHE_TenLoai UNIQUE (TenLoai),
    CONSTRAINT CK_LOAITHE_DoDaiSoThe CHECK (DoDaiSoThe IN (15, 16)),
    CONSTRAINT CK_LOAITHE_DoDaiCSV   CHECK (DoDaiCSV IN (3, 4)),
    CONSTRAINT CK_LOAITHE_LePhi      CHECK (LePhi >= 0)
);
GO

-- 2.7 THETINDUNG (chỉ lưu thông tin rút gọn, không lưu số thẻ đầy đủ và CSV)
CREATE TABLE THETINDUNG (
    MaThe      INT IDENTITY(1,1) NOT NULL,
    MaLoaiThe  INT          NOT NULL,
    SoCuoi4    CHAR(4)      NOT NULL,
    NgayHetHan DATE         NOT NULL,
    TenChuThe  NVARCHAR(100) NOT NULL,
    CONSTRAINT PK_THETINDUNG PRIMARY KEY (MaThe),
    CONSTRAINT FK_THETINDUNG_LOAITHE FOREIGN KEY (MaLoaiThe)
        REFERENCES LOAITHE (MaLoaiThe),
    CONSTRAINT CK_THETINDUNG_SoCuoi4
        CHECK (SoCuoi4 LIKE '[0-9][0-9][0-9][0-9]')   -- đúng 4 chữ số
);
GO

-- 2.8 NGUOINHAN
CREATE TABLE NGUOINHAN (
    MaNguoiNhan INT IDENTITY(1,1) NOT NULL,
    HoTen       NVARCHAR(100) NOT NULL,
    DiaChi      NVARCHAR(200) NOT NULL,
    DienThoai   NVARCHAR(15)  NOT NULL,
    CONSTRAINT PK_NGUOINHAN PRIMARY KEY (MaNguoiNhan)
);
GO

-- 2.9 GIOHANG (mỗi khách có tối đa một giỏ hiện tại)
CREATE TABLE GIOHANG (
    MaGioHang INT IDENTITY(1,1) NOT NULL,
    MaKH      INT           NOT NULL,
    TamTinh   DECIMAL(18,0) NOT NULL CONSTRAINT DF_GIOHANG_TamTinh DEFAULT 0,
    CONSTRAINT PK_GIOHANG PRIMARY KEY (MaGioHang),
    CONSTRAINT UQ_GIOHANG_MaKH UNIQUE (MaKH),
    CONSTRAINT FK_GIOHANG_KHACHHANG FOREIGN KEY (MaKH)
        REFERENCES KHACHHANG (MaKH),
    CONSTRAINT CK_GIOHANG_TamTinh CHECK (TamTinh >= 0)
);
GO

-- 2.10 MUCGIOHANG (hợp thành với GIOHANG)
CREATE TABLE MUCGIOHANG (
    MaGioHang INT           NOT NULL,
    MaSP      NVARCHAR(20)  NOT NULL,
    SoLuong   INT           NOT NULL,
    ThanhTien DECIMAL(18,0) NOT NULL CONSTRAINT DF_MUCGIOHANG_ThanhTien DEFAULT 0,
    CONSTRAINT PK_MUCGIOHANG PRIMARY KEY (MaGioHang, MaSP),
    CONSTRAINT FK_MUCGIOHANG_GIOHANG FOREIGN KEY (MaGioHang)
        REFERENCES GIOHANG (MaGioHang) ON DELETE CASCADE,
    CONSTRAINT FK_MUCGIOHANG_SANPHAM FOREIGN KEY (MaSP)
        REFERENCES SANPHAM (MaSP),
    CONSTRAINT CK_MUCGIOHANG_SoLuong   CHECK (SoLuong > 0),
    CONSTRAINT CK_MUCGIOHANG_ThanhTien CHECK (ThanhTien >= 0)
);
GO

-- 2.11 DONDATHANG
CREATE TABLE DONDATHANG (
    MaDon        INT IDENTITY(1,1) NOT NULL,
    MaKH         INT           NOT NULL,
    MaLoaiPhieu  INT           NOT NULL,
    MaKV         INT           NOT NULL,
    MaThe        INT           NOT NULL,
    MaNguoiNhan  INT           NOT NULL,
    ThoiDiemDat  DATETIME      NOT NULL CONSTRAINT DF_DONDATHANG_ThoiDiemDat DEFAULT GETDATE(),
    PhiGiao      DECIMAL(18,0) NOT NULL CONSTRAINT DF_DONDATHANG_PhiGiao  DEFAULT 0,
    LePhiThe     DECIMAL(18,0) NOT NULL CONSTRAINT DF_DONDATHANG_LePhiThe DEFAULT 0,
    TongTriGia   DECIMAL(18,0) NOT NULL,
    TrangThai    NVARCHAR(30)  NOT NULL CONSTRAINT DF_DONDATHANG_TrangThai DEFAULT N'KhoiTao',
    CONSTRAINT PK_DONDATHANG PRIMARY KEY (MaDon),
    CONSTRAINT UQ_DONDATHANG_MaNguoiNhan UNIQUE (MaNguoiNhan),
    CONSTRAINT FK_DONDATHANG_KHACHHANG  FOREIGN KEY (MaKH)        REFERENCES KHACHHANG (MaKH),
    CONSTRAINT FK_DONDATHANG_LOAIPHIEU  FOREIGN KEY (MaLoaiPhieu) REFERENCES LOAIPHIEU (MaLoaiPhieu),
    CONSTRAINT FK_DONDATHANG_KHUVUCGIAO FOREIGN KEY (MaKV)        REFERENCES KHUVUCGIAO (MaKV),
    CONSTRAINT FK_DONDATHANG_THETINDUNG FOREIGN KEY (MaThe)       REFERENCES THETINDUNG (MaThe),
    CONSTRAINT FK_DONDATHANG_NGUOINHAN  FOREIGN KEY (MaNguoiNhan) REFERENCES NGUOINHAN (MaNguoiNhan),
    CONSTRAINT CK_DONDATHANG_PhiGiao    CHECK (PhiGiao >= 0),
    CONSTRAINT CK_DONDATHANG_LePhiThe   CHECK (LePhiThe >= 0),
    CONSTRAINT CK_DONDATHANG_TongTriGia CHECK (TongTriGia >= 0),
    CONSTRAINT CK_DONDATHANG_TrangThai
        CHECK (TrangThai IN (N'KhoiTao', N'ChoThanhToan', N'DaXacNhan',
                             N'ThanhToanThatBai', N'DaHuy'))
);
GO

-- 2.12 CHITIETDONHANG (hợp thành với DONDATHANG)
CREATE TABLE CHITIETDONHANG (
    MaDon   INT           NOT NULL,
    MaSP    NVARCHAR(20)  NOT NULL,
    SoLuong INT           NOT NULL,
    DonGia  DECIMAL(18,0) NOT NULL,           -- giá tại thời điểm đặt
    CONSTRAINT PK_CHITIETDONHANG PRIMARY KEY (MaDon, MaSP),
    CONSTRAINT FK_CHITIETDONHANG_DONDATHANG FOREIGN KEY (MaDon)
        REFERENCES DONDATHANG (MaDon) ON DELETE CASCADE,
    CONSTRAINT FK_CHITIETDONHANG_SANPHAM FOREIGN KEY (MaSP)
        REFERENCES SANPHAM (MaSP),
    CONSTRAINT CK_CHITIETDONHANG_SoLuong CHECK (SoLuong > 0),
    CONSTRAINT CK_CHITIETDONHANG_DonGia  CHECK (DonGia >= 0)
);
GO

/* ==========================================================
   3. DỮ LIỆU MẪU CHO CÁC BẢNG DANH MỤC
      (giá trị tiền chỉ là ví dụ, chỉnh theo yêu cầu của bài)
   ========================================================== */

-- Loại thẻ: Visa, Master, Discover (16 số, CSV 3 số); American Express (15 số, CSV 4 số)
INSERT INTO LOAITHE (TenLoai, DoDaiSoThe, DoDaiCSV, LePhi) VALUES
    (N'Visa',             16, 3, 10000),
    (N'Master',           16, 3, 10000),
    (N'Discover',         16, 3, 12000),
    (N'American Express', 15, 4, 15000);

-- Loại phiếu: ngưỡng miễn phí 1.000.000 (nhanh) và 5.000.000 (nhanh trong ngày)
INSERT INTO LOAIPHIEU (TenLoai, DonGia, ThoiGianXuLy, NguongMienPhi) VALUES
    (N'Thường',            15000, N'3 - 5 ngày', NULL),
    (N'Nhanh',             30000, N'1 - 2 ngày', 1000000),
    (N'Nhanh trong ngày',  60000, N'Trong ngày', 5000000);

-- Khu vực giao hàng
INSERT INTO KHUVUCGIAO (TenKV, PhiGiao) VALUES
    (N'Nội thành',   10000),
    (N'Ngoại thành', 20000),
    (N'Tỉnh khác',   35000);

-- Nhóm sản phẩm và sản phẩm mẫu (dữ liệu giả lập từ HT Quản lý sản phẩm)
INSERT INTO NHOMSANPHAM (MaNhom, TenNhom) VALUES
    (N'DT', N'Điện thoại'),
    (N'LT', N'Laptop');

INSERT INTO SANPHAM (MaSP, MaNhom, TenSP, NhaSanXuat, GiaBan, TinhTrang) VALUES
    (N'DT001', N'DT', N'Điện thoại A', N'Hãng 1', 5500000,  1),
    (N'DT002', N'DT', N'Điện thoại B', N'Hãng 2', 12000000, 1),
    (N'LT001', N'LT', N'Laptop C',     N'Hãng 3', 18000000, 1),
    (N'LT002', N'LT', N'Laptop D',     N'Hãng 4', 25000000, 0);
GO
