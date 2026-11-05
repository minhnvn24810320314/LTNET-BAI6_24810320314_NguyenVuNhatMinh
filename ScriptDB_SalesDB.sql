CREATE DATABASE SalesDB;
GO

USE SalesDB;
GO

CREATE TABLE NhanVien (
    MaNV INT IDENTITY(1,1) PRIMARY KEY,
    TenNV NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(15) UNIQUE,
    ChucVu NVARCHAR(50)
);

CREATE TABLE KhachHang (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    TenKH NVARCHAR(100) NOT NULL,
    DienThoai VARCHAR(15) UNIQUE,
    DiemTichLuy INT DEFAULT 0
);

CREATE TABLE SanPham (
    MaSP VARCHAR(20) PRIMARY KEY,
    TenSP NVARCHAR(150) NOT NULL,
    GiaBan DECIMAL(18,2) CHECK (GiaBan > 0),
    SoLuongTon INT CHECK (SoLuongTon >= 0)
);

CREATE TABLE HoaDon (
    MaHD INT IDENTITY(1,1) PRIMARY KEY,
    NgayLap DATETIME DEFAULT GETDATE(),
    MaNV INT NOT NULL,
    MaKH INT NULL,
    TongTien DECIMAL(18,2),
    CONSTRAINT FK_HoaDon_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    CONSTRAINT FK_HoaDon_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);

CREATE TABLE ChiTietHoaDon (
    MaHD INT NOT NULL,
    MaSP VARCHAR(20) NOT NULL,
    SoLuong INT CHECK (SoLuong > 0),
    DonGia DECIMAL(18,2),
    PRIMARY KEY (MaHD, MaSP),
    CONSTRAINT FK_CTHD_HoaDon FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
    CONSTRAINT FK_CTHD_SanPham FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);

-- NẠP DỮ LIỆU MẪU
INSERT INTO NhanVien (TenNV, SoDienThoai, ChucVu) VALUES
(N'Nguyễn Văn A', '0901234567', N'Thu ngân'),
(N'Trần Thị B', '0912345678', N'Quản lý');

INSERT INTO KhachHang (TenKH, DienThoai, DiemTichLuy) VALUES
(N'Khách lẻ', '0000000000', 0),
(N'Lê Văn C', '0987654321', 10),
(N'Phạm Thị D', '0976543210', 50);

INSERT INTO SanPham (MaSP, TenSP, GiaBan, SoLuongTon) VALUES
('SP001', N'Sữa tươi Vinamilk 1L', 35000, 50),
('SP002', N'Bánh mì Sandwich', 20000, 30),
('SP003', N'Nước ngọt Coca-Cola 330ml', 10000, 100),
('SP004', N'Mì Hảo Hảo tôm chua cay', 4500, 5),
('SP005', N'Cà phê hòa tan G7', 45000, 25);