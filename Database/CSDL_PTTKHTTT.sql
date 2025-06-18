CREATE DATABASE DB_TRUNGTAMTHI ON
    (Name = DB_TrungTamThi_data, 
    FileName = 'D:\DataFile\DB_TrungTamThi_data.mdf')
LOG ON
    (Name = DB_TrungTamThi_log,
    FileName = 'D:\DataFile\DB_TrungTamThi_log.ldf');
go

use DB_TRUNGTAMTHI;
go

CREATE TABLE NHANVIEN (
  NV_MaNhanVien varchar(10) PRIMARY KEY NOT NULL,
  NV_TenNhanVien nvarchar(50),
  NV_NgaySinh date,
  NV_GioiTinh nvarchar(3) CHECK (NV_GioiTinh IN (N'Nam', N'Nữ')),
  NV_Email char(100),
  NV_SDT char(10),
  NV_CCCD char(12),
  NV_DiaChi nvarchar(100),
  NV_ChucVu nvarchar(20),
  NV_Luong int,
  NV_MaPhongBan varchar(10) NOT NULL
)
GO

CREATE TABLE TAIKHOAN (
  TK_TenDangNhap varchar(10) PRIMARY KEY,
  TK_MatKhau varchar(100),
)

CREATE TABLE PHONGBAN (
  PB_MaPhongBan varchar(10) PRIMARY KEY,
  PB_TenPhongBan nvarchar(50)
)
GO

CREATE TABLE KHACHHANG (
  KH_MaKhachHang varchar(10) PRIMARY KEY NOT NULL,
  KH_LoaiKhachHang nvarchar(20),
  KH_Email char(100),
  KH_SDT char(10)
)
GO

CREATE TABLE KHACHHANGHTUDO (
  KHTD_MaKhachHang varchar(10) PRIMARY KEY NOT NULL,
  KHTD_HoTen nvarchar(50)
)
GO

CREATE TABLE KHACHHANGDONVI (
  KHDV_MaKhachHang varchar(10) PRIMARY KEY NOT NULL,
  KHDV_TenDonVi nvarchar(30)
)
GO

CREATE TABLE THISINH (
  TS_SoBaoDanh varchar(10) PRIMARY KEY NOT NULL,
  TS_MaKhachHang varchar(10),
  TS_HoTen nvarchar(50),
  TS_NgaySinh date,
  TS_GioiTinh nvarchar(3) CHECK (TS_GioiTinh IN (N'Nam', N'Nữ')),
  TS_Email char(100),
  TS_SDT char(10),
  TS_CCCD char(12)
)
GO

CREATE TABLE PHIEUDANGKYDUTHI (
  PDKDT_MaPhieu varchar(10) PRIMARY KEY NOT NULL,
  PDKDT_ThoiGianLap date,
  PDKDT_DiaChiChuyenPhat nvarchar(100),
  PDKDT_TrangThaiThanhToan nvarchar(20) CHECK (PDKDT_TrangThaiThanhToan IN (N'Chưa thanh toán', N'Thanh toán gia hạn', N'Đã thanh toán')),
  PDKDT_MaKhachHang varchar(10) NOT NULL,
  PDKDT_MaLichTHi varchar(10) NOT NULL,
  PDKDT_MaNhanVienLap varchar(10) NOT NULL
)
GO

CREATE TABLE PHONGTHI (
  PT_MaPhongThi varchar(10) PRIMARY KEY,
  PT_HinhThuc nvarchar(30) CHECK (PT_HinhThuc IN (N'Tự luận', N'Trắc nghiệm', N'Trác nghiệm-Tự luận')),
  PT_SLThiSinhToiDa int,
  PT_SLThiSinhToiTHieu int,
  PT_SLNhanVienCoiThi int,
)
GO

CREATE TABLE LICHTHI (
  LT_MaLichThi varchar(10) PRIMARY KEY,
  LT_MaKyThi varchar(10) NOT NULL,
  LT_SLDangKy int,
  LT_TrangThai nvarchar(20),
  LT_TenKyThi nvarchar(50),
  LT_NgayThi date,
  LT_MaPhongThi varchar(10) NOT NULL,
  LT_TGBatDau time,
  LT_TGKetThuc time
)
GO

CREATE TABLE PHEUTHANHTOAN (
  PTT_MaPhieu varchar(10) PRIMARY KEY,
  PTT_MaPhieuDK varchar(10) NOT NULL,
  PTT_NhanVienLap varchar(10) NOT NULL,
  PTT_NgayIn date,
  PTT_SoTienBanDau int,
  PTT_PhanTramGiam float,
  PTT_SoTienThanhToan int,
  PTT_HinhThucThanhToan nvarchar(50),
  PTT_ThoiHan date
)
GO

CREATE TABLE BAITHI (
  BT_MaBaiThi varchar(10) PRIMARY KEY,
  BT_MaKyThi varchar(10) NOT NULL,
  BT_SoBaoDanh varchar(10) NOT NULL,
  BT_ThoiGianLamBai time,
  BT_DiemSo float,
  BT_DonViCham varchar(10)
)
GO

CREATE TABLE PHIEUGIAHAN (
  PGH_MaPhieu varchar(10) PRIMARY KEY,
  PGH_MaPhieuDK varchar(10) NOT NULL,
  PGH_LyDoGiaHan nvarchar(100),
  PGH_SoTienThanhToan int,
  PGH_HinhThucThanhToan nvarchar(20),
  PGH_ThoiHan date
)
GO

CREATE TABLE CHUNGCHI (
  CC_MaBaiThi varchar(10),
  CC_MaKyThi varchar(10),
  CC_SoBaoDanh varchar(10),
  CC_NgayCap date,
  CC_ThoiHan date,
  CC_TrangThai nvarchar(20) CHECK (CC_TrangThai IN (N'Chưa nhận', N'Đã nhận'))
  PRIMARY KEY (CC_MaBaiThi, CC_MaKyThi)
)
GO

CREATE TABLE KYTHI (
  KT_MaKyThi varchar(10) PRIMARY KEY,
  KT_TenKyThi nvarchar(50),
  KT_LePhi int
)
GO

CREATE TABLE PHIEUDUTHI (
  PDT_MaPhieu varchar(10) PRIMARY KEY,
  PDT_MaPhieuDangKy varchar(10) NOT NULL,
  PDT_SoBaoDanh varchar(10) NOT NULL,
  PDT_MaLichThi varchar(10) NOT NULL,
  PDT_MaPhongThi varchar(10) NOT NULL
)
GO

CREATE TABLE DONVICHAMTHI (
  DVCT_MaDonVi varchar(10) PRIMARY KEY,
  DVCT_TenDonVi nvarchar(50)
)
GO

CREATE TABLE PHANCONG (
  PC_MaNhanVien varchar(10) PRIMARY KEY,
  PC_MaLichThi varchar(10) NOT NULL,
  PC_TrangThai nvarchar(20) CHECK (PC_TrangThai IN( N'Chưa diễn ra', N'Hoàn thành'))
)
GO

CREATE TABLE THONGBAO (
  TB_MaThongBao varchar(10) PRIMARY KEY,
  TB_MaNhanVienGui varchar(10) NOT NULL,
  TB_MaNhanVienNhan varchar(10) NOT NULL,
  TB_NoiDung nvarchar(200),
  TB_ThoiGianGui datetime
)
GO

ALTER TABLE NHANVIEN ADD FOREIGN KEY (NV_MaPhongBan) REFERENCES PHONGBAN (PB_MaPhongBan)
GO

ALTER TABLE KHACHHANGHTUDO ADD FOREIGN KEY (KHTD_MaKhachHang) REFERENCES KHACHHANG (KH_MaKhachHang)
GO

ALTER TABLE KHACHHANGDONVI ADD FOREIGN KEY (KHDV_MaKhachHang) REFERENCES KHACHHANG (KH_MaKhachHang)
GO

ALTER TABLE THISINH ADD FOREIGN KEY (TS_MaKhachHang) REFERENCES KHACHHANG (KH_MaKhachHang)
GO

ALTER TABLE PHIEUDANGKYDUTHI ADD FOREIGN KEY (PDKDT_MaKhachHang) REFERENCES KHACHHANG (KH_MaKhachHang)
GO

ALTER TABLE PHIEUDANGKYDUTHI ADD FOREIGN KEY (PDKDT_MaLichTHi) REFERENCES LICHTHI (LT_MaLichThi)
GO

ALTER TABLE PHIEUDANGKYDUTHI ADD FOREIGN KEY (PDKDT_MaNhanVienLap) REFERENCES NHANVIEN (NV_MaNhanVien)
GO

ALTER TABLE LICHTHI ADD FOREIGN KEY (LT_MaKyThi) REFERENCES KYTHI (KT_MaKyThi)
GO

ALTER TABLE LICHTHI ADD FOREIGN KEY (LT_MaPhongThi) REFERENCES PHONGTHI (PT_MaPhongThi)
GO

ALTER TABLE PHEUTHANHTOAN ADD FOREIGN KEY (PTT_MaPhieuDK) REFERENCES PHIEUDANGKYDUTHI (PDKDT_MaPhieu)
GO

ALTER TABLE PHEUTHANHTOAN ADD FOREIGN KEY (PTT_NhanVienLap) REFERENCES NHANVIEN (NV_MaNhanVien)
GO

ALTER TABLE BAITHI ADD FOREIGN KEY (BT_MaKyThi) REFERENCES KYTHI (KT_MaKyThi)
GO

ALTER TABLE BAITHI ADD FOREIGN KEY (BT_SoBaoDanh) REFERENCES THISINH (TS_SoBaoDanh)
GO

ALTER TABLE BAITHI ADD FOREIGN KEY (BT_DonViCham) REFERENCES DONVICHAMTHI (DVCT_MaDonVi)
GO

ALTER TABLE PHIEUGIAHAN ADD FOREIGN KEY (PGH_MaPhieuDK) REFERENCES PHIEUDANGKYDUTHI (PDKDT_MaPhieu)
GO

ALTER TABLE CHUNGCHI ADD FOREIGN KEY (CC_MaBaiThi) REFERENCES BAITHI (BT_MaBaiThi)
GO

ALTER TABLE PHIEUDUTHI ADD FOREIGN KEY (PDT_MaPhieuDangKy) REFERENCES PHIEUDANGKYDUTHI (PDKDT_MaPhieu)
GO

ALTER TABLE PHIEUDUTHI ADD FOREIGN KEY (PDT_SoBaoDanh) REFERENCES THISINH (TS_SoBaoDanh)
GO

ALTER TABLE PHIEUDUTHI ADD FOREIGN KEY (PDT_MaLichThi) REFERENCES LICHTHI (LT_MaLichThi)
GO

ALTER TABLE PHIEUDUTHI ADD FOREIGN KEY (PDT_MaPhongThi) REFERENCES PHONGTHI (PT_MaPhongThi)
GO

ALTER TABLE PHANCONG ADD FOREIGN KEY (PC_MaNhanVien) REFERENCES NHANVIEN (NV_MaNhanVien)
GO

ALTER TABLE PHANCONG ADD FOREIGN KEY (PC_MaLichThi) REFERENCES LICHTHI (LT_MaLichThi)
GO

ALTER TABLE THONGBAO ADD FOREIGN KEY (TB_MaNhanVienGui) REFERENCES NHANVIEN (NV_MaNhanVien)
GO

ALTER TABLE THONGBAO ADD FOREIGN KEY (TB_MaNhanVienNhan) REFERENCES NHANVIEN (NV_MaNhanVien)
GO

ALTER TABLE TAIKHOAN ADD FOREIGN KEY (TK_TenDangNhap) REFERENCES NHANVIEN (NV_MaNhanVien)
GO
-- Xóa database:
/*
use master;
drop database DB_TRUNGTAMTHI;
*/