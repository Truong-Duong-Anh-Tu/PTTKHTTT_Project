--Insert data
use DB_TRUNGTAMTHI;
go
	
INSERT INTO KHACHHANG (KH_MaKhachHang, KH_LoaiKhachHang, KH_Email, KH_SDT) 
VALUES
  ('KH00001', N'Tự do', 'r3a1w@example.com', '0311000231'),
  ('KH00002', N'Tự do', 'h5b2v@example.com', '0321000002'),
  ('KH00003', N'Tự do', 'o9dc3@example.com', '0340102003'),
  ('KH00004', N'Tự do', '3r4d4@example.com', '0367891904'),
  ('KH00005', N'Tự do', 'ggre5@example.com', '0875929482'),
  ('KH00006', N'Tự do', '5tqf6@example.com', '0769939183'),
  ('KH00007', N'Tự do', '3r43r@example.com', '0930009990'),
  ('KH00008', N'Tự do', 'r34h8@example.com', '0941002008'),
  ('KH00009', N'Tự do', '23ei9@example.com', '0761004009'),
  ('KH00010', N'Tự do', 'ssk10@example.com', '0340103009'),
  ('KH00011', N'Tự do', '22wf5@example.com', '0871003009'),
  ('KH00012', N'Tự do', 'zq3i8@example.com', '0341070209'),
  ('KH00013', N'Tự do', '5tep0@example.com', '0831050509'),
  ('KH00014', N'Tự do', '4nh7u@example.com', '0935624259'),
  ('KH00015', N'Tự do', '2was2@example.com', '0921040009'),
  ('KH00016', N'Tự do', 'p2wp3@example.com', '0811060309'),
  ('KH00017', N'Tự do', 'f2pp3@example.com', '0331000009'),
  ('KH00018', N'Tự do', 'k9s21@example.com', '0341012309'),
  ('KH00019', N'Tự do', 'n8new@example.com', '0821000238'),
  ('KH00020', N'Tự do', 'h9p23@example.com', '0941490391'),
  ('KHDV001', N'Đơn vị', 'contact@alpha.vn', '0396754382'),
  ('KHDV002', N'Đơn vị', 'contact@beta.vn', '0868443755'),
  ('KHDV003', N'Đơn vị', 'contact@gamma.vn', '0764562513'),
  ('KHDV004', N'Đơn vị', 'contact@delta.vn', '0968534261');
GO


INSERT INTO KHACHHANGHTUDO (KHTD_MaKhachHang, KHTD_HoTen) 
VALUES
  ('KH00001', N'Nguyễn Văn Minh'),
  ('KH00002', N'Trần Thị Bình'),
  ('KH00003', N'Lê Văn Chiến'),
  ('KH00004', N'Phạm Thị Dung'),
  ('KH00005', N'Nguyễn Quang Trường'),
  ('KH00006', N'Nguyễn Ngọc Thanh Vân'),
  ('KH00007', N'Đỗ Hữu Thành'),
  ('KH00008', N'Bùi Thái Tiến'),
  ('KH00009', N'Lê Nguyễn Trúc Ly'),
  ('KH00010', N'Đỗ Thị Lan'),
  ('KH00011', N'Đỗ Thị Ngọc Huyền'),
  ('KH00012', N'Lê Đức Duy'),
  ('KH00013', N'Vũ Tuyết Mai'),
  ('KH00014', N'Nguyễn Hoàng Hưng'),
  ('KH00015', N'Huỳnh Minh Thư'),
  ('KH00016', N'Lê Thị Ngọc Yến'),
  ('KH00017', N'Nguyễn Hồng Phong'),
  ('KH00018', N'Nguyễn Quốc Thiện'),
  ('KH00019', N'Đoàn Trà My'),
  ('KH00020', N'Trịnh Hoàng Khải');
GO

INSERT INTO KHACHHANGDONVI (KHDV_MaKhachHang, KHDV_TenDonVi) 
VALUES
  ('KHDV001', N'Trung tâm Alpha'),
  ('KHDV002', N'Học viện Beta'),
  ('KHDV003', N'Trường Gamma'),
  ('KHDV004', N'Trung tâm Delta');
GO

INSERT INTO THISINH (TS_SoBaoDanh, TS_MaKhachHang, TS_HoTen, TS_NgaySinh, TS_GioiTinh, TS_Email, TS_SDT, TS_CCCD)
VALUES
  ('TS00001', 'KH00001', N'Nguyễn Văn Minh', CONVERT(date, '01/04/2004', 103), N'Nam', 'r3a1w@example.com', '0311000231', '082306716472'),
  ('TS00002', 'KH00002', N'Lê Thành Quân', CONVERT(date, '21/05/2001', 103), N'Nam', 'u827e@example', '0987680821', '083309827645'),
  ('TS00003', 'KH00003', N'Nguyễn Thị Lệ Quyên', CONVERT(date, '09/07/2002', 103), N'Nữ', '8iew2@example', '0384650821', '084409883725'),
  ('TS00004', 'KH00004', N'Phạm Thị Dung', CONVERT(date, '19/12/2003', 103), N'Nữ', '3r4d4@example.com', '0367891904', '082209870541'),
  ('TS00005', 'KH00005', N'Lê Thị Phương Khanh', CONVERT(date, '19/12/2003', 103), N'Nữ', '9ui2u@example.com', '0768902748', '082304467891'),
  ('TS00006', 'KH00006', N'Trần Nhân Tâm', CONVERT(date, '09/11/2002', 103), N'Nam', '9io0d@example.com', '0345902748', '082208597941'),
  ('TS00007','KH00007',N'Đỗ Hữu Thành', CONVERT(date,'22/11/1988',103),N'Nam','3r43r@example.com', '0930009990','012345678907'),
  ('TS00008','KH00008',N'Bùi Thái Tiến', CONVERT(date,'30/06/1992',103),N'Nam','r34h8@example.com', '0941002008','012345678908'),
  ('TS00009','KH00009',N'Lê Nguyễn Trúc Hồng', CONVERT(date,'14/09/1995',103),N'Nữ','9oi8u@example.com', '0761044009','012345678909'),
  ('TS00010','KH00010',N'Đỗ Thị Lan', CONVERT(date,'27/03/1991',103),N'Nữ','ssk10@example.com', '0340103009','012345678910'),
  ('TS00011','KH00011',N'Nguyễn Như Mai', CONVERT(date,'02/01/1993',103),N'Nữ','90oi8@example.com', '0871002009','012345678911'),
  ('TS00012','KH00012',N'Lê Đức Duy', CONVERT(date,'09/10/1990',103),N'Nam','zq3i8@example.com', '0341070209','012345678912'),
  ('TS00013','KH00013',N'Vũ Tuyết Ngọc', CONVERT(date,'16/04/1994',103),N'Nữ','o90u7@example.com', '0831050609','012345678913'),
  ('TS00014','KH00014',N'Nguyễn Hoàng Hưng', CONVERT(date,'25/12/1988',103),N'Nam','4nh7u@example.com', '0935624259','012345678914'),
  ('TS00015','KH00015',N'Huỳnh Minh Thư', CONVERT(date,'11/11/1992',103),N'Nữ','2was2@example.com', '0921040009','012345678915'),
  ('TS00016','KH00016',N'Lê Thị Ngọc Yến', CONVERT(date,'19/08/1991',103),N'Nữ','p2wp3@example.com', '0811060309','012345678916'),
  ('TS00017','KH00017',N'Nguyễn Hồng Phong', CONVERT(date,'03/03/1990',103),N'Nam','f2pp3@example.com', '0331000009','012345678917'),
  ('TS00018','KH00018',N'Nguyễn Quốc Thiện', CONVERT(date,'29/09/1993',103),N'Nam','k9s21@example.com', '0341012309','012345678918'),
  ('TS00019','KH00019',N'Đoàn Trà My', CONVERT(date,'07/07/1994',103),N'Nữ','n8new@example.com', '0821000238','012345678919'),
  ('TS00020','KH00020',N'Trịnh Hoàng Khải', CONVERT(date,'21/05/1989',103),N'Nam','h9p23@example.com', '0941490391','012345678920');
GO

INSERT INTO PHONGBAN (PB_MaPhongBan, PB_TenPhongBan) 
VALUES
('PB001', N'Phòng Tiếp nhận'),
('PB002', N'Phòng Kế toán'),
('PB003', N'Phòng Nhập liệu'),
('PB004', N'Phòng Quản trị hệ thống'),
('PB005', N'Phòng Giám thị');
GO

INSERT INTO DONVICHAMTHI (DVCT_MaDonVi, DVCT_TenDonVi) VALUES
('DVCT01', N'Đơn vị A'),
('DVCT02', N'Đơn vị B'),
('DVCT03', N'Đơn vị C'),
('DVCT04', N'Đơn vị D'),
('DVCT05', N'Đơn vị E');
GO

INSERT INTO KYTHI (KT_MaKyThi, KT_TenKyThi, KT_LePhi) 
VALUES
('KT01', N'Kỳ thi tiếng Anh A2', 500000),
('KT02', N'Kỳ thi tiếng Anh B1', 700000),
('KT03', N'Kỳ thi Tin học văn phòng', 600000),
('KT04', N'Kỳ thi năng lực công chức', 800000),
('KT05', N'Kỳ thi tiếng Hàn TOPIK I', 900000);
GO

INSERT INTO PHONGTHI (PT_MaPhongThi, PT_HinhThuc, PT_SLThiSinhToiDa, PT_SLThiSinhToiTHieu, PT_SLNhanVienCoiThi) 
VALUES
('P001', N'Tự luận', 30, 10, 2),
('P002', N'Trắc nghiệm', 25, 8, 1),
('P003', N'Trác nghiệm-Tự luận', 40, 15, 3),
('P004', N'Trắc nghiệm', 20, 5, 1),
('P005', N'Trác nghiệm-Tự luận', 35, 12, 2);
GO

INSERT INTO NHANVIEN (NV_MaNhanVien, NV_TenNhanVien, NV_NgaySinh, NV_GioiTinh, NV_Email, NV_SDT, NV_CCCD, NV_DiaChi, NV_ChucVu, NV_Luong, NV_MaPhongBan)
VALUES
  ('NV001', N'Huỳnh Thị Trúc Phương', CONVERT(date, '01/01/1990', 103), N'Nữ',  'a7yw1@ttthi.vn', '0911111111', '012345678901', N'Hà Nội', N'Tiếp nhận', 8000000, 'PB001'),
  ('NV002', N'Phạm Phương Dung', CONVERT(date, '02/02/1992', 103), N'Nữ',  'b2ewj@ttthi.vn', '0922222222', '012345678902', N'Hà Nội', N'Tiếp nhận', 8500000, 'PB001'),
  ('NV003', N'Nguyễn Đình Thăng', CONVERT(date, '03/03/1991', 103), N'Nam', 'c3e2o@ttthi.vn','0933333333','012345678903', N'Hồ Chí Minh', N'Tiếp nhận', 8000000, 'PB001'),
  ('NV004', N'Ngô Văn Sơn', CONVERT(date, '04/04/1993', 103), N'Nam', 'd49fi@ttthi.vn','0944444444','012345678904', N'Hà Nội', N'Tiếp nhận', 8200000, 'PB001'),
  ('NV005', N'Đặng Thị Yến Nhi', CONVERT(date, '05/05/1989', 103), N'Nữ',  'e583i@ttthi.vn','0955555555','012345678905', N'Hải Phòng', N'Tiếp nhận', 8100000, 'PB001'),

  ('NV006', N'Nguyễn Võ Ngọc Huyền', CONVERT(date, '06/06/1990', 103), N'Nữ',  'f6i3u@ttthi.vn','0966666666','012345678906', N'Huế', N'Kế toán', 9000000, 'PB002'),
  ('NV007', N'Hoàng Xuân Phú', CONVERT(date, '07/07/1988', 103), N'Nam', 'g79ir@ttthi.vn','0977777777','012345678907', N'Đà Nẵng', N'Kế toán', 9200000, 'PB002'),
  ('NV008', N'Trần Nguyễn Thu Trang', CONVERT(date, '08/08/1991', 103), N'Nữ',  'h83k2@ttthi.vn','0988888888','012345678908', N'Hà Nam', N'Kế toán', 8900000, 'PB002'),
  ('NV009', N'Nguyễn Vinh Quang', CONVERT(date, '09/09/1987', 103), N'Nam', 'i99o2@ttthi.vn','0999999999','012345678909', N'Quảng Ninh', N'Kế toán', 8800000, 'PB002'),
  ('NV010', N'Phan Lê Thuỳ Dương', CONVERT(date, '10/10/1992', 103), N'Nữ',  'j103r@ttthi.vn','0900000000','012345678910', N'Ninh Bình', N'Kế toán', 8700000, 'PB002'),

  ('NV011', N'Vũ Đình Lưỡng', CONVERT(date, '11/11/1993', 103), N'Nam', 'k123e@ttthi.vn','0912345678','012345678911', N'HCM', N'Nhập liệu', 7000000, 'PB003'),
  ('NV012', N'Phạm Thị Hương Thảo', CONVERT(date, '12/12/1994', 103), N'Nữ', 'l12ee@ttthi.vn','0923456789','012345678912', N'HCM', N'Nhập liệu', 7100000, 'PB003'),
  ('NV013', N'Lê Thanh Nhật', CONVERT(date, '13/01/1995', 103), N'Nam', 'mytu7@ttthi.vn','0934567890','012345678913', N'Cần Thơ', N'Nhập liệu', 7200000, 'PB003'),
  ('NV014', N'Trần Nhật Thy', CONVERT(date, '14/02/1996', 103), N'Nữ',  'n142w@ttthi.vn','0945678901','012345678914', N'Cần Thơ', N'Nhập liệu', 7150000, 'PB003'),
  ('NV015', N'Lê Đăng Quang', CONVERT(date, '15/03/1990', 103), N'Nam', 'o15az@ttthi.vn','0956789012','012345678915', N'Đắk Lắk', N'Nhập liệu', 7300000, 'PB003'),

  ('NV016', N'Phạm Huỳnh Ánh Nguyệt', CONVERT(date, '16/04/1985', 103), N'Nữ',  'p1dr6@ttthi.vn','0967890123','012345678916', N'Hà Nội', N'Quản trị hệ thống', 10000000, 'PB004'),
  ('NV017', N'Nguyễn Đồng Thanh Hiệp', CONVERT(date, '17/05/1984', 103), N'Nam', 'q12r7@ttthi.vn','0978901234','012345678917', N'Hồ Chí Minh', N'Quản trị hệ thống', 10200000, 'PB004'),

  ('NV018', N'Bùi Thị Ánh Vân', CONVERT(date, '18/06/1991', 103), N'Nữ',  'r34tr@ttthi.vn','0989012345','012345678918', N'Nam Định', N'Nhập liệu', 7400000, 'PB003'),
  ('NV019', N'Lê Thanh Nhật', CONVERT(date, '19/07/1989', 103), N'Nam', 's192e@ttthi.vn','0990123456','012345678919', N'Hải Dương', N'Tiếp nhận', 8200000, 'PB001'),
  ('NV020', N'Đỗ Thùy Dung', CONVERT(date, '20/08/1990', 103), N'Nữ',  't2th2@ttthi.vn','0901234567','012345678920', N'Hà Giang', N'Kế toán', 8600000, 'PB002'),

  ('NV021', N'Nguyễn Văn An', CONVERT(date,'02/02/1987',103), N'Nam','u8u37@ttthi.vn', '0912345671','012345678921', N'Hà Nội', N'Coi thi', 7500000, 'PB005'),
  ('NV022', N'Trần Thị Bích', CONVERT(date,'15/05/1988',103), N'Nữ','mxka2@ttthi.vn', '0912345672','012345678922', N'Hải Phòng', N'Coi thi', 7600000, 'PB005'),
  ('NV023', N'Lê Thị Cẩm', CONVERT(date,'23/03/1990',103), N'Nữ','8u573@ttthi.vn', '0912345673','012345678923', N'Đà Nẵng', N'Coi thi', 7400000, 'PB005'),
  ('NV024', N'Phạm Văn Dũng', CONVERT(date,'30/07/1989',103), N'Nam','4rt65@ttthi.vn', '0912345674','012345678924', N'Huế', N'Coi thi', 7700000, 'PB005'),
  ('NV025', N'Hoàng Thị Hạnh', CONVERT(date,'11/11/1991',103), N'Nữ','4rt56@ttthi.vn', '0912345675','012345678925', N'Nghệ An', N'Coi thi', 7550000, 'PB005'),
  ('NV026', N'Vũ Đức Anh', CONVERT(date,'05/09/1986',103), N'Nam','0oxpa@ttthi.vn', '0912345676','012345678926', N'Quảng Ninh', N'Coi thi', 7650000, 'PB005'),
  ('NV027', N'Đặng Thị Mai', CONVERT(date,'19/12/1988',103), N'Nữ','3e5ea@ttthi.vn', '0912345677','012345678927', N'Nam Định', N'Coi thi', 7500000, 'PB005'),
  ('NV028', N'Bùi Văn Hùng', CONVERT(date,'27/06/1992',103), N'Nam','9o0y6@ttthi.vn', '0912345678','012345678928', N'Quảng Trị', N'Coi thi', 7800000, 'PB005'),
  ('NV029', N'Trịnh Thị Phương', CONVERT(date,'08/08/1987',103), N'Nữ','4r35t@ttthi.vn', '0912345679','012345678929', N'Hải Dương', N'Coi thi', 7450000, 'PB005'),
  ('NV030', N'Phan Văn Sơn', CONVERT(date,'14/04/1990',103), N'Nam','4rt56@ttthi.vn', '0912345680','012345678930', N'Thái Bình', N'Coi thi', 7600000, 'PB005'),
  ('NV031', N'Đỗ Thị Hoài', CONVERT(date,'22/02/1991',103), N'Nữ','4r52s@ttthi.vn', '0912345681','012345678931', N'Bắc Giang', N'Coi thi', 7550000, 'PB005'),
  ('NV032', N'Lê Thị Thanh', CONVERT(date,'09/10/1989',103), N'Nữ','8i90o@ttthi.vn', '0912345682','012345678932', N'Hà Tĩnh',    N'Coi thi', 7700000, 'PB003');
GO

INSERT INTO TAIKHOAN (TK_TenDangNhap, TK_MatKhau)
VALUES
	('NV001', '$2a$11$tufZ9fXXaVHHNKKuvC7ia.lWBAsmWjiLdZu0.LfElxG4Q1q0OtY1a'), --1234 - Tiếp nhận
	('NV016', '$2a$11$C8YcS5NffhMD4Bd3H0SGUeK.V9AI3K9XYu3qr4xIv8lx1USIQ8REK'), --1234 - Quản trị hệ thống
	('NV006', '$2a$11$C8YcS5NffhMD4Bd3H0SGUeK.V9AI3K9XYu3qr4xIv8lx1USIQ8REK'), --1234 - Kế toán
	('NV011', '$2a$11$C8YcS5NffhMD4Bd3H0SGUeK.V9AI3K9XYu3qr4xIv8lx1USIQ8REK'), --1234 - Nhập liệu
	('NV021', '$2a$11$tufZ9fXXaVHHNKKuvC7ia.lWBAsmWjiLdZu0.LfElxG4Q1q0OtY1a'); --1234 - Coi thi
GO

INSERT INTO THONGBAO (TB_MaThongBao, TB_MaNhanVienGui, TB_MaDoiTuongNhan, TB_ChuDe, TB_NoiDung, TB_ThoiGianGui) VALUES
('A3B4E9D3-1C2F-4A36-8B1F-7E5F6C3B8A6E', 'NV001', 'NV006', N'Họp', N'Chào bạn, mời tham dự cuộc họp lúc 14:00 hôm nay.', '2025-06-21 09:30:00'),
('5D2F37FA-8E09-4BD4-97B3-3E6F4320B2A5', 'NV001', 'NV007', N'Họp', N'Chào bạn, mời tham dự cuộc họp lúc 14:00 hôm nay.', '2025-06-21 09:30:00'),
('F0D0A519-43A0-4376-8326-BF5828D6C0E9', 'NV002', 'NV011', N'Xác nhận họp', N'Xác nhận đã nhận thông báo và sẽ tham gia đúng giờ.', '2025-06-21 10:00:00'),
('8B62A8CB-F915-493C-91AC-AEA31389B3D7', 'NV003', 'NV011', N'Báo cáo' , N'Báo cáo đã hoàn tất và gửi cho bạn xem qua.', '2025-06-20 16:45:00'),
('1071D9FC-1B18-4BA3-9D87-3C3F0AE1E9AF', 'NV011', 'NV003', N'Kiểm tra', N'Xin bạn kiểm tra hồ sơ nhân viên mới.', '2025-06-19 11:20:00'),
('27E31E9A-A994-4FD7-8DBF-A0D0C4F72701', 'NV011', 'NV004', N'Nhắc nhở', N'Nhắc bạn cập nhật tiến độ dự án đến cuối tuần.', '2025-06-18 15:00:00'),
('34B6D27B-27DD-4F12-A89A-059EBF064F77', 'NV016', 'NV002', N'Phản hồi', N'Progress đã xong 80%, đang đợi phản hồi.', '2025-06-18 16:30:00'),
('67DF5E9C-2E3B-4D35-B154-933D1767E0DE', 'NV012', 'PB003', N'Phản hồi', N'Nhập liệu thông tin người này: \n a, \n b', '2025-03-12 15:30:00');
GO

drop table THONGBAO;
