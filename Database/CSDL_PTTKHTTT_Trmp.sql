CREATE DATABASE DB_TRUNGTAMTHI ON
    (Name = DB_TrungTamThi_data, 
    FileName = 'D:\SQL_Data\DB_TrungTamThi_data.mdf')
LOG ON
    (Name = DB_TrungTamThi_log,
    FileName = 'D:\SQL_Data\DB_TrungTamThi_log.ldf');
go

use DB_TRUNGTAMTHI;
go

CREATE TABLE NHANVIEN (
  NV_MaNhanVien varchar(10) PRIMARY KEY NOT NULL,
  NV_TenNhanVien nvarchar(50),
  NV_NgaySinh date,
  NV_GioiTinh nvarchar(3),
  NV_Email char(50),
  NV_SDT char(10),
  NV_CCCD char(12),
  NV_DiaChi nvarchar(100),
  NV_ChucVu nvarchar(20),
  NV_Luong int,
  NV_MaPhongBan varchar(10) NOT NULL
)
GO

CREATE TABLE PHONGBAN (
  PB_MaPhongBan varchar(10) PRIMARY KEY,
  PB_TenPhongBan nvarchar(50)
)
GO

CREATE TABLE KHACHHANG (
  KH_MaKhachHang varchar(10) PRIMARY KEY NOT NULL,
  KH_LoaiKhachHang nvarchar(20),
  KH_Email char,
  KH_SDT char
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
  TS_HoTen nvarchar(50),
  TS_NgaySinh date,
  TS_GioiTinh nvarchar(3),
  TS_Email char,
  TS_SDT char,
  TS_CCCD char
)
GO

CREATE TABLE PHIEUDANGKYDUTHI (
  PDKDT_MaPhieu varchar(10) PRIMARY KEY NOT NULL,
  PDKDT_ThoiGianLap date,
  PDKDT_DiaChiChuyenPhat nvarchar(100),
  PDKDT_TrangThaiThanhToan nvarchar(20),
  PDKDT_MaKhachHang varchar(10) NOT NULL,
  PDKDT_MaLichTHi varchar(10) NOT NULL,
  PDKDT_MaNhanVienLap varchar(10) NOT NULL
)
GO

CREATE TABLE PHONGTHI (
  PT_MaPhongThi varchar(10) PRIMARY KEY,
  PT_HinhThuc nvarchar(30),
  PT_SLThiSinhToiDa int,
  PT_SLThiSinhToiTHieu int,
  PT_SLNhanVienCoiThi int,
  PT_TinhTrang nvarchar(20)
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
  DVCT_TenDonVi nvarchar(60)
)
GO

CREATE TABLE PHANCONG (
  PC_MaNhanVien varchar(10) PRIMARY KEY,
  PC_MaLichThi varchar(10) NOT NULL
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

INSERT INTO PHONGBAN (PB_MaPhongBan, PB_TenPhongBan) VALUES
('PB01', N'Phòng Tiếp nhận'),
('PB02', N'Phòng Kế toán'),
('PB03', N'Phòng Nhập liệu'),
('PB04', N'Phòng Quản trị hệ thống');

INSERT INTO DONVICHAMTHI (DVCT_MaDonVi, DVCT_TenDonVi) VALUES
('DVCT01', N'Trường Đại học A'),
('DVCT02', N'Trường Đại học B'),
('DVCT03', N'Trung tâm khảo thí Quốc gia'),
('DVCT04', N'Trường Cao đẳng C'),
('DVCT05', N'Trung tâm Giáo dục thường xuyên D');

INSERT INTO KYTHI (KT_MaKyThi, KT_TenKyThi, KT_LePhi) VALUES
('KT01', N'Kỳ thi tiếng Anh A2', 500000),
('KT02', N'Kỳ thi tiếng Anh B1', 700000),
('KT03', N'Kỳ thi Tin học văn phòng', 600000),
('KT04', N'Kỳ thi năng lực công chức', 800000),
('KT05', N'Kỳ thi tiếng Hàn TOPIK I', 900000);

INSERT INTO PHONGTHI (PT_MaPhongThi, PT_HinhThuc, PT_SLThiSinhToiDa, PT_SLThiSinhToiTHieu, PT_SLNhanVienCoiThi, PT_TinhTrang) VALUES
('P001', N'Trực tiếp', 30, 10, 2, N'Sẵn sàng'),
('P002', N'Trực tuyến', 25, 8, 1, N'Sẵn sàng'),
('P003', N'Trực tiếp', 40, 15, 3, N'Bảo trì'),
('P004', N'Trực tuyến', 20, 5, 1, N'Sẵn sàng'),
('P005', N'Trực tiếp', 35, 12, 2, N'Đang thi');

INSERT INTO NHANVIEN (NV_MaNhanVien, NV_TenNhanVien, NV_NgaySinh, NV_GioiTinh, NV_Email, NV_SDT, NV_CCCD, NV_DiaChi, NV_ChucVu, NV_Luong, NV_MaPhongBan)
VALUES
('NV01', N'Nguyễn Văn A', '1990-01-01', N'Nam', 'a1@ttthi.vn', '0911111111', '012345678901', N'Hà Nội', N'Tiếp nhận', 8000000, 'PB01'),
('NV02', N'Trần Thị B', '1992-02-02', N'Nữ', 'b2@ttthi.vn', '0922222222', '012345678902', N'Hà Nội', N'Tiếp nhận', 8500000, 'PB01'),
('NV03', N'Lê Văn C', '1991-03-03', N'Nam', 'c3@ttthi.vn', '0933333333', '012345678903', N'Hồ Chí Minh', N'Tiếp nhận', 8000000, 'PB01'),
('NV04', N'Phạm Thị D', '1993-04-04', N'Nữ', 'd4@ttthi.vn', '0944444444', '012345678904', N'Hà Nội', N'Tiếp nhận', 8200000, 'PB01'),
('NV05', N'Hoàng Văn E', '1989-05-05', N'Nam', 'e5@ttthi.vn', '0955555555', '012345678905', N'Hải Phòng', N'Tiếp nhận', 8100000, 'PB01'),

('NV06', N'Nguyễn Thị F', '1990-06-06', N'Nữ', 'f6@ttthi.vn', '0966666666', '012345678906', N'Huế', N'Kế toán', 9000000, 'PB02'),
('NV07', N'Vũ Văn G', '1988-07-07', N'Nam', 'g7@ttthi.vn', '0977777777', '012345678907', N'Đà Nẵng', N'Kế toán', 9200000, 'PB02'),
('NV08', N'Đặng Thị H', '1991-08-08', N'Nữ', 'h8@ttthi.vn', '0988888888', '012345678908', N'Hà Nam', N'Kế toán', 8900000, 'PB02'),
('NV09', N'Tô Văn I', '1987-09-09', N'Nam', 'i9@ttthi.vn', '0999999999', '012345678909', N'Quảng Ninh', N'Kế toán', 8800000, 'PB02'),
('NV10', N'Bùi Thị J', '1992-10-10', N'Nữ', 'j10@ttthi.vn', '0900000000', '012345678910', N'Ninh Bình', N'Kế toán', 8700000, 'PB02'),

('NV11', N'Đỗ Văn K', '1993-11-11', N'Nam', 'k11@ttthi.vn', '0912345678', '012345678911', N'HCM', N'Nhập liệu', 7000000, 'PB03'),
('NV12', N'Ngô Thị L', '1994-12-12', N'Nữ', 'l12@ttthi.vn', '0923456789', '012345678912', N'HCM', N'Nhập liệu', 7100000, 'PB03'),
('NV13', N'Trịnh Văn M', '1995-01-13', N'Nam', 'm13@ttthi.vn', '0934567890', '012345678913', N'Cần Thơ', N'Nhập liệu', 7200000, 'PB03'),
('NV14', N'Cao Thị N', '1996-02-14', N'Nữ', 'n14@ttthi.vn', '0945678901', '012345678914', N'Cần Thơ', N'Nhập liệu', 7150000, 'PB03'),
('NV15', N'Hà Văn O', '1990-03-15', N'Nam', 'o15@ttthi.vn', '0956789012', '012345678915', N'Đắk Lắk', N'Nhập liệu', 7300000, 'PB03'),

('NV16', N'Phan Thị P', '1985-04-16', N'Nữ', 'p16@ttthi.vn', '0967890123', '012345678916', N'Hà Nội', N'Quản trị hệ thống', 10000000, 'PB04'),
('NV17', N'Lương Văn Q', '1984-05-17', N'Nam', 'q17@ttthi.vn', '0978901234', '012345678917', N'Hồ Chí Minh', N'Quản trị hệ thống', 10200000, 'PB04'),

('NV18', N'Trần Thị R', '1991-06-18', N'Nữ', 'r18@ttthi.vn', '0989012345', '012345678918', N'Nam Định', N'Nhập liệu', 7400000, 'PB03'),
('NV19', N'Phạm Văn S', '1989-07-19', N'Nam', 's19@ttthi.vn', '0990123456', '012345678919', N'Hải Dương', N'Tiếp nhận', 8200000, 'PB01'),
('NV20', N'Lý Thị T', '1990-08-20', N'Nữ', 't20@ttthi.vn', '0901234567', '012345678920', N'Hà Giang', N'Kế toán', 8600000, 'PB02');

-- Xóa database:
/*
use master;
drop database DB_TRUNGTAMTHI;
*/

/*USE master;
GO

ALTER DATABASE DB_TRUNGTAMTHI SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO

DROP DATABASE DB_TRUNGTAMTHI;
GO*/
