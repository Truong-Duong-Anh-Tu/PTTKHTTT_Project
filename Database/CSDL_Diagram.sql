
CREATE DATABASE DB_TRUNGTAMTHI ON
    (Name = DB_TrungTamThi_data, 
    FileName = 'C:\Users\ANH TU\Documents\Third Year\HK II\PTTK HTTT\Project\Database\DataFile\DB_TrungTamThi_data.mdf')
LOG ON
    (Name = DB_TrungTamThi_log,
    FileName = 'C:\Users\ANH TU\Documents\Third Year\HK II\PTTK HTTT\Project\Database\DataFile\DB_TrungTamThi_log.ldf');
go

use DB_TRUNGTAMTHI
go

CREATE TABLE [NHANVIEN] (
  [NV_MaNhanVien] varchar(255) PRIMARY KEY NOT NULL,
  [NV_TenNhanVien] nvarchar(255),
  [NV_NgaySinh] date,
  [NV_GioiTinh] nvarchar(3) CHECK (NV_GioiTinh IN (N'Nam', N'Nữ')),
  [NV_Email] char,
  [NV_SDT] char,
  [NV_CCCD] char,
  [NV_DiaChi] nvarchar(255),
  [NV_ChucVu] nvarchar(255),
  [NV_Luong] int,
  [NV_MaPhongBan] varchar(255) NOT NULL
)
GO

CREATE TABLE [PHONGBAN] (
  [PB_MaPhongBan] varchar(255) PRIMARY KEY,
  [PB_TenPhongBan] nvarchar
)
GO

CREATE TABLE [KHACHHANG] (
  [KH_MaKhachHang] varchar(255) PRIMARY KEY NOT NULL,
  [KH_LoaiKhachHang] nvarchar,
  [KH_Email] char,
  [KH_SDT] char
)
GO

CREATE TABLE [KHACHHANGHTUDO] (
  [KHTD_MaKhachHang] varchar(255) PRIMARY KEY NOT NULL,
  [KHTD_HoTen] nvarchar
)
GO

CREATE TABLE [KHACHHANGDONVI] (
  [KHDV_MaKhachHang] varchar(255) PRIMARY KEY NOT NULL,
  [KHDV_TenDonVi] nvarchar
)
GO

CREATE TABLE [THISINH] (
  [TS_SoBaoDanh] varchar(255) PRIMARY KEY NOT NULL,
  [TS_HoTen] nvarchar,
  [TS_NgaySinh] date,
  [TS_GioiTinh] nvarchar(255) CHECK (TS_GioiTinh IN (N'Nam', N'Nữ')),
  [TS_Email] char,
  [TS_SDT] char,
  [TS_CCCD] char
)
GO

CREATE TABLE [PHIEUDANGKYDUTHI] (
  [PDKDT_MaPhieu] varchar(255) PRIMARY KEY NOT NULL,
  [PDKDT_ThoiGianLap] date,
  [PDKDT_DiaChiChuyenPhat] nvarchar,
  [PDKDT_TrangThaiThanhToan] nvarchar CHECK (PDKDT_TrangThaiThanhToan IN (N'Chưa thanh toán', N'Thanh toán gia hạn', N'Đã thanh toán')),
  [PDKDT_MaKhachHang] varchar(255) NOT NULL,
  [PDKDT_MaLichTHi] varchar(255) NOT NULL,
  [PDKDT_MaNhanVienLap] varchar(255) NOT NULL
)
GO

CREATE TABLE [PHONGTHI] (
  [PT_MaPhongThi] varchar(255) PRIMARY KEY,
  [PT_HinhThuc] nvarchar CHECK (PT_HinhThuc IN (N'Tự luận', N'Trắc nghiệm', N'Trác nghiệm-Tự luận')),
  [PT_SLThiSinhToiDa] int,
  [PT_SLThiSinhToiTHieu] int,
  [PT_SLNhanVienCoiThi] int,
  [PT_TinhTrang] nvarchar(20) CHECK (PT_TinhTrang IN (N'Trống', N'Có lịch sử dụng'))
)
GO

CREATE TABLE [LICHTHI] (
  [LT_MaLichThi] varchar(255) PRIMARY KEY,
  [LT_MaKyThi] varchar(255) NOT NULL,
  [LT_SLDangKy] int,
  [LT_TrangThai] nvarchar CHECK (LT_TrangThai IN (N'Chưa diễn ra', N'Đã diễn ra')),
  [LT_TenKyThi] nvarchar,
  [LT_NgayThi] date,
  [LT_MaPhongThi] varchar(255) NOT NULL,
  [LT_TGBatDau] time,
  [LT_TGKetThuc] time
)
GO

CREATE TABLE [PHEUTHANHTOAN] (
  [PTT_MaPhieu] varchar(255) PRIMARY KEY,
  [PTT_MaPhieuDK] varchar(255) NOT NULL,
  [PTT_NhanVienLap] varchar(255) NOT NULL,
  [PTT_NgayIn] date,
  [PTT_SoTienBanDau] int,
  [PTT_PhanTramGiam] float,
  [PTT_SoTienThanhToan] int,
  [PTT_HinhThucThanhToan] nvarchar,
  [PTT_ThoiHan] date
)
GO

CREATE TABLE [BAITHI] (
  [BT_MaBaiThi] varchar(255) PRIMARY KEY,
  [BT_MaKyThi] varchar(255) NOT NULL,
  [BT_SoBaoDanh] varchar(255) NOT NULL,
  [BT_ThoiGianLamBai] time,
  [BT_DiemSo] float,
  [BT_DVChamThi] varchar(255),
  [BT_DonViCham] nvarchar(255)
)
GO

CREATE TABLE [PHIEUGIAHAN] (
  [PGH_MaPhieu] nvarchar(255) PRIMARY KEY,
  [PGH_MaPhieuDK] nvarchar(255) NOT NULL,
  [PGH_LyDoGiaHan] nvarchar,
  [PGH_SoTienThanhToan] int,
  [PGH_HinhThucThanhToan] nvarchar,
  [PGH_ThoiHan] date
)
GO

CREATE TABLE [CHUNGCHI] (
  [CC_MaBaiThi] nvarchar(255),
  [CC_MaKyThi] nvarchar(255),
  [CC_SoBaoDanh] nvarchar(255),
  [CC_NgayCap] date,
  [CC_ThoiHan] nvarchar,
  PRIMARY KEY ([CC_MaBaiThi], [CC_MaKyThi])
)
GO

CREATE TABLE [KYTHI] (
  [KT_MaKyThi] nvarchar(255) PRIMARY KEY,
  [KT_TenKyThi] nvarchar,
  [KT_LePhi] int
)
GO

CREATE TABLE [PHIEUDUTHI] (
  [PDT_MaPhieu] nvarchar(255) PRIMARY KEY,
  [PDT_MaPhieuDangKy] nvarchar(255) NOT NULL,
  [PDT_SoBaoDanh] nvarchar(255) NOT NULL,
  [PDT_MaLichThi] nvarchar(255) NOT NULL,
  [PDT_MaPhongThi] nvarchar(255) NOT NULL
)
GO

CREATE TABLE [DONVICHAMTHI] (
  [DVCT_MaDonVi] nvarchar(255) PRIMARY KEY,
  [DVCT_TenDonVi] nvarchar
)
GO

CREATE TABLE [PHANCONG] (
  [PC_MaNhanVien] nvarchar(255) PRIMARY KEY,
  [PC_MaLichThi] nvarchar(255) NOT NULL
)
GO

CREATE TABLE [THONGBAO] (
  [TB_MaThongBao] nvarchar(255) PRIMARY KEY,
  [TB_MaNhanVienGui] nvarchar(255) NOT NULL,
  [TB_MaNhanVienNhan] nvarchar(255) NOT NULL,
  [TB_NoiDung] nvarchar,
  [TB_ThoiGianGui] datetime
)
GO

--Thêm constrant foreign key (khóa ngoại)
ALTER TABLE [NHANVIEN] ADD FOREIGN KEY ([NV_MaPhongBan]) REFERENCES [PHONGBAN] ([PB_MaPhongBan])
GO

ALTER TABLE [KHACHHANGHTUDO] ADD FOREIGN KEY ([KHTD_MaKhachHang]) REFERENCES [KHACHHANG] ([KH_MaKhachHang])
GO

ALTER TABLE [KHACHHANGDONVI] ADD FOREIGN KEY ([KHDV_MaKhachHang]) REFERENCES [KHACHHANG] ([KH_MaKhachHang])
GO

ALTER TABLE [PHIEUDANGKYDUTHI] ADD FOREIGN KEY ([PDKDT_MaKhachHang]) REFERENCES [KHACHHANG] ([KH_MaKhachHang])
GO

ALTER TABLE [PHIEUDANGKYDUTHI] ADD FOREIGN KEY ([PDKDT_MaLichTHi]) REFERENCES [LICHTHI] ([LT_MaLichThi])
GO

ALTER TABLE [PHIEUDANGKYDUTHI] ADD FOREIGN KEY ([PDKDT_MaNhanVienLap]) REFERENCES [NHANVIEN] ([NV_MaNhanVien])
GO

ALTER TABLE [LICHTHI] ADD FOREIGN KEY ([LT_MaKyThi]) REFERENCES [KYTHI] ([KT_MaKyThi])
GO

ALTER TABLE [LICHTHI] ADD FOREIGN KEY ([LT_MaPhongThi]) REFERENCES [PHONGTHI] ([PT_MaPhongThi])
GO

ALTER TABLE [PHEUTHANHTOAN] ADD FOREIGN KEY ([PTT_MaPhieuDK]) REFERENCES [PHIEUDANGKYDUTHI] ([PDKDT_MaPhieu])
GO

ALTER TABLE [PHEUTHANHTOAN] ADD FOREIGN KEY ([PTT_NhanVienLap]) REFERENCES [NHANVIEN] ([NV_MaNhanVien])
GO

ALTER TABLE [BAITHI] ADD FOREIGN KEY ([BT_MaKyThi]) REFERENCES [KYTHI] ([KT_MaKyThi])
GO

ALTER TABLE [BAITHI] ADD FOREIGN KEY ([BT_SoBaoDanh]) REFERENCES [THISINH] ([TS_SoBaoDanh])
GO

ALTER TABLE [BAITHI] ADD FOREIGN KEY ([BT_DonViCham]) REFERENCES [DONVICHAMTHI] ([DVCT_MaDonVi])
GO

ALTER TABLE [PHIEUGIAHAN] ADD FOREIGN KEY ([PGH_MaPhieuDK]) REFERENCES [PHIEUDANGKYDUTHI] ([PDKDT_MaPhieu])
GO

ALTER TABLE [BAITHI] ADD FOREIGN KEY ([BT_MaBaiThi]) REFERENCES [CHUNGCHI] ([CC_MaBaiThi])
GO

ALTER TABLE [PHIEUDUTHI] ADD FOREIGN KEY ([PDT_MaPhieuDangKy]) REFERENCES [PHIEUDANGKYDUTHI] ([PDKDT_MaPhieu])
GO

ALTER TABLE [PHIEUDUTHI] ADD FOREIGN KEY ([PDT_SoBaoDanh]) REFERENCES [THISINH] ([TS_SoBaoDanh])
GO

ALTER TABLE [PHIEUDUTHI] ADD FOREIGN KEY ([PDT_MaLichThi]) REFERENCES [LICHTHI] ([LT_MaLichThi])
GO

ALTER TABLE [PHIEUDUTHI] ADD FOREIGN KEY ([PDT_MaPhongThi]) REFERENCES [PHONGTHI] ([PT_MaPhongThi])
GO

ALTER TABLE [PHANCONG] ADD FOREIGN KEY ([PC_MaNhanVien]) REFERENCES [NHANVIEN] ([NV_MaNhanVien])
GO

ALTER TABLE [PHANCONG] ADD FOREIGN KEY ([PC_MaLichThi]) REFERENCES [LICHTHI] ([LT_MaLichThi])
GO

CREATE TABLE [NHANVIEN_THONGBAO] (
  [NHANVIEN_TB_MaNhanVien] varchar,
  [THONGBAO_TB_MaNhanVienGui] varchar,
  PRIMARY KEY ([NHANVIEN_NV_MaNhanVien], [THONGBAO_TB_MaNhanVienGui])
);
GO

ALTER TABLE [NHANVIEN_THONGBAO] ADD FOREIGN KEY ([NHANVIEN_NV_MaNhanVien]) REFERENCES [NHANVIEN] ([NV_MaNhanVien]);
GO

ALTER TABLE [NHANVIEN_THONGBAO] ADD FOREIGN KEY ([THONGBAO_TB_MaNhanVienGui]) REFERENCES [THONGBAO] ([TB_MaNhanVienGui]);
GO


ALTER TABLE [THONGBAO] ADD FOREIGN KEY ([TB_MaNhanVienNhan]) REFERENCES [NHANVIEN] ([NV_MaNhanVien])
GO


-- Xóa database:
-- use master;
-- drop database DB_TRUNGTAMTHI;