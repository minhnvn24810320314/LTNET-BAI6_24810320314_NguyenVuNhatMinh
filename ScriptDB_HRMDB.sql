CREATE DATABASE HRMDB;
GO

USE HRMDB;
GO

-- 1. Bảng PhongBan
CREATE TABLE PhongBan (
    MaPB INT IDENTITY(1,1) PRIMARY KEY,
    TenPB NVARCHAR(100) NOT NULL,
    MoTa NVARCHAR(255)
);

-- 2. Bảng NhanVien
CREATE TABLE NhanVien (
    MaNV INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATETIME,
    CCCD VARCHAR(20) UNIQUE,
    MaPB INT FOREIGN KEY REFERENCES PhongBan(MaPB),
    LuongCoBan DECIMAL(18,2) CHECK (LuongCoBan > 0),
    HeSoLuong FLOAT DEFAULT 1.0
);

-- 3. Bảng BangChamCong
CREATE TABLE BangChamCong (
    MaCong INT IDENTITY(1,1) PRIMARY KEY,
    MaNV INT FOREIGN KEY REFERENCES NhanVien(MaNV),
    ThangNam VARCHAR(7), -- Ví dụ: "11/2026"
    SoNgayCong FLOAT CHECK (SoNgayCong <= 31),
    SoGioOT FLOAT DEFAULT 0,
    CONSTRAINT UQ_ChamCong UNIQUE (MaNV, ThangNam)
);

-- 4. Bảng BangLuong
CREATE TABLE BangLuong (
    MaLuong INT IDENTITY(1,1),
    MaNV INT FOREIGN KEY REFERENCES NhanVien(MaNV),
    ThangNam VARCHAR(7),
    ThucLinh DECIMAL(18,2),
    PRIMARY KEY (MaNV, ThangNam)
);

-- NẠP DỮ LIỆU MẪU
INSERT INTO PhongBan (TenPB, MoTa) VALUES 
(N'Phòng Nhân sự', N'Quản lý nhân sự và tiền lương'),
(N'Phòng Kỹ thuật', N'Phát triển phần mềm'),
(N'Phòng Kinh doanh', N'Phát triển thị trường');

INSERT INTO NhanVien (HoTen, NgaySinh, CCCD, MaPB, LuongCoBan, HeSoLuong) VALUES 
(N'Nguyễn Văn An', '1995-05-20', '012345678901', 1, 10000000, 1.5),
(N'Trần Thị Bình', '1998-10-15', '012345678902', 2, 12000000, 1.8),
(N'Lê Hoàng Cường', '1992-03-12', '012345678903', 3, 9000000, 1.2);