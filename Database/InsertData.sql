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
('KT03', N'Kỳ thi Tin học văn phòng MOC', 600000),
('KT04', N'Kỳ thi tiếng Anh TOEIC', 800000),
('KT05', N'Kỳ thi tiếng Anh TOEFL', 800000),
('KT06', N'Kỳ thi tiếng Anh SAT', 900000),
('KT07', N'Kỳ thi tiếng Anh IELTS', 1000000),
('KT08', N'Kỳ thi tiếng Anh PET', 800000),
('KT09', N'Kỳ thi Tin học IC3', 650000);
GO

INSERT INTO PHONGTHI (PT_MaPhongThi, PT_HinhThuc, PT_SLThiSinhToiDa, PT_SLThiSinhToiThieu, PT_SLNhanVienCoiThi) 
VALUES
('P001', N'Tự luận', 30, 10, 2),
('P002', N'Trắc nghiệm', 25, 8, 2),
('P003', N'Trắc nghiệm-Tự luận', 40, 15, 3),
('P004', N'Trắc nghiệm', 30, 5, 2),
('P005', N'Trắc nghiệm-Tự luận', 35, 12, 2),
('P006', N'Tự luận', 30, 12, 2);
GO

INSERT INTO NHANVIEN (NV_MaNhanVien, NV_TenNhanVien, NV_NgaySinh, NV_GioiTinh, NV_Email, NV_SDT, NV_CCCD, NV_DiaChi, NV_ChucVu, NV_Luong, NV_MaPhongBan, NV_MatKhau)
VALUES
  ('NV001', N'Huỳnh Thị Trúc Phương', CONVERT(date, '01/01/1990', 103), N'Nữ',  'httphuong@ttthi.vn', '0911111111', '012345678901', N'Hà Nội', N'Tiếp nhận', 8000000, 'PB001', '$2a$11$tufZ9fXXaVHHNKKuvC7ia.lWBAsmWjiLdZu0.LfElxG4Q1q0OtY1a'),
  ('NV002', N'Phạm Phương Dung', CONVERT(date, '02/02/1992', 103), N'Nữ',  'ppdung@ttthi.vn', '0922222222', '012345678902', N'Hà Nội', N'Tiếp nhận', 8500000, 'PB001', '$2a$11$tufZ9fXXaVHHNKKuvC7ia.lWBAsmWjiLdZu0.LfElxG4Q1q0OtY1a'),
  ('NV003', N'Nguyễn Đình Thăng', CONVERT(date, '03/03/1991', 103), N'Nam', 'ndthang@ttthi.vn','0933333333','012345678903', N'Hồ Chí Minh', N'Tiếp nhận', 8000000, 'PB001', '$2a$11$tufZ9fXXaVHHNKKuvC7ia.lWBAsmWjiLdZu0.LfElxG4Q1q0OtY1a'),
  ('NV004', N'Ngô Văn Sơn', CONVERT(date, '04/04/1993', 103), N'Nam', 'nvson@ttthi.vn','0944444444','012345678904', N'Hà Nội', N'Tiếp nhận', 8200000, 'PB001', '$2a$11$tufZ9fXXaVHHNKKuvC7ia.lWBAsmWjiLdZu0.LfElxG4Q1q0OtY1a'),
  ('NV005', N'Đặng Thị Yến Nhi', CONVERT(date, '05/05/1989', 103), N'Nữ',  'dtynhi@ttthi.vn','0955555555','012345678905', N'Hải Phòng', N'Tiếp nhận', 8100000, 'PB001', '$2a$11$tufZ9fXXaVHHNKKuvC7ia.lWBAsmWjiLdZu0.LfElxG4Q1q0OtY1a'),

  ('NV006', N'Nguyễn Võ Ngọc Huyền', CONVERT(date, '06/06/1990', 103), N'Nữ',  'nvnhuyen@ttthi.vn','0966666666','012345678906', N'Huế', N'Kế toán', 9000000, 'PB002', '$2a$11$C8YcS5NffhMD4Bd3H0SGUeK.V9AI3K9XYu3qr4xIv8lx1USIQ8REK'),
  ('NV007', N'Hoàng Xuân Phú', CONVERT(date, '07/07/1988', 103), N'Nam', 'hxphu@ttthi.vn','0977777777','012345678907', N'Đà Nẵng', N'Kế toán', 9200000, 'PB002', '$2a$11$C8YcS5NffhMD4Bd3H0SGUeK.V9AI3K9XYu3qr4xIv8lx1USIQ8REK'),
  ('NV008', N'Trần Nguyễn Thu Trang', CONVERT(date, '08/08/1991', 103), N'Nữ',  'tnttrang@ttthi.vn','0988888888','012345678908', N'Hà Nam', N'Kế toán', 8900000, 'PB002', '$2a$11$C8YcS5NffhMD4Bd3H0SGUeK.V9AI3K9XYu3qr4xIv8lx1USIQ8REK'),
  ('NV009', N'Nguyễn Vinh Quang', CONVERT(date, '09/09/1987', 103), N'Nam', 'nvquang@ttthi.vn','0999999999','012345678909', N'Quảng Ninh', N'Kế toán', 8800000, 'PB002', '$2a$11$C8YcS5NffhMD4Bd3H0SGUeK.V9AI3K9XYu3qr4xIv8lx1USIQ8REK'),
  ('NV010', N'Phan Lê Thuỳ Dương', CONVERT(date, '10/10/1992', 103), N'Nữ',  'pltduong@ttthi.vn','0900000000','012345678910', N'Ninh Bình', N'Kế toán', 8700000, 'PB002', '$2a$11$C8YcS5NffhMD4Bd3H0SGUeK.V9AI3K9XYu3qr4xIv8lx1USIQ8REK'),

  ('NV011', N'Vũ Đình Lưỡng', CONVERT(date, '11/11/1993', 103), N'Nam', 'vdluong@ttthi.vn','0912345678','012345678911', N'HCM', N'Nhập liệu', 7000000, 'PB003', '$2a$11$C8YcS5NffhMD4Bd3H0SGUeK.V9AI3K9XYu3qr4xIv8lx1USIQ8REK'),
  ('NV012', N'Phạm Thị Hương Thảo', CONVERT(date, '12/12/1994', 103), N'Nữ', 'ptpthao@ttthi.vn','0923456789','012345678912', N'HCM', N'Nhập liệu', 7100000, 'PB003', '$2a$11$C8YcS5NffhMD4Bd3H0SGUeK.V9AI3K9XYu3qr4xIv8lx1USIQ8REK'),
  ('NV013', N'Lê Thanh Nhật', CONVERT(date, '13/01/1995', 103), N'Nam', 'ltnhat@ttthi.vn','0934567890','012345678913', N'Cần Thơ', N'Nhập liệu', 7200000, 'PB003', '$2a$11$C8YcS5NffhMD4Bd3H0SGUeK.V9AI3K9XYu3qr4xIv8lx1USIQ8REK'),
  ('NV014', N'Trần Nhật Thy', CONVERT(date, '14/02/1996', 103), N'Nữ',  'tnthy@ttthi.vn','0945678901','012345678914', N'Cần Thơ', N'Nhập liệu', 7150000, 'PB003', '$2a$11$C8YcS5NffhMD4Bd3H0SGUeK.V9AI3K9XYu3qr4xIv8lx1USIQ8REK'),
  ('NV015', N'Lê Đăng Quang', CONVERT(date, '15/03/1990', 103), N'Nam', 'ldquang@ttthi.vn','0956789012','012345678915', N'Đắk Lắk', N'Nhập liệu', 7300000, 'PB003', '$2a$11$C8YcS5NffhMD4Bd3H0SGUeK.V9AI3K9XYu3qr4xIv8lx1USIQ8REK'),

  ('NV016', N'Phạm Huỳnh Ánh Nguyệt', CONVERT(date, '16/04/1985', 103), N'Nữ',  'phanguyet@ttthi.vn','0967890123','012345678916', N'Hà Nội', N'Quản trị hệ thống', 10000000, 'PB004', '$2a$11$C8YcS5NffhMD4Bd3H0SGUeK.V9AI3K9XYu3qr4xIv8lx1USIQ8REK'),
  ('NV017', N'Nguyễn Đồng Thanh Hiệp', CONVERT(date, '17/05/1984', 103), N'Nam', 'ndthiep@ttthi.vn','0978901234','012345678917', N'Hồ Chí Minh', N'Quản trị hệ thống', 10200000, 'PB004', '$2a$11$C8YcS5NffhMD4Bd3H0SGUeK.V9AI3K9XYu3qr4xIv8lx1USIQ8REK'),

  ('NV018', N'Bùi Thị Ánh Vân', CONVERT(date, '18/06/1991', 103), N'Nữ',  'btavan@ttthi.vn','0989012345','012345678918', N'Nam Định', N'Nhập liệu', 7400000, 'PB003', '$2a$11$C8YcS5NffhMD4Bd3H0SGUeK.V9AI3K9XYu3qr4xIv8lx1USIQ8REK'),
  ('NV019', N'Lê Thanh Nhật', CONVERT(date, '19/07/1989', 103), N'Nam', 'ltnhat@ttthi.vn','0990123456','012345678919', N'Hải Dương', N'Tiếp nhận', 8200000, 'PB001', '$2a$11$tufZ9fXXaVHHNKKuvC7ia.lWBAsmWjiLdZu0.LfElxG4Q1q0OtY1a'),
  ('NV020', N'Đỗ Thùy Dung', CONVERT(date, '20/08/1990', 103), N'Nữ',  'dtdung@ttthi.vn','0901234567','012345678920', N'Hà Giang', N'Kế toán', 8600000, 'PB002', '$2a$11$C8YcS5NffhMD4Bd3H0SGUeK.V9AI3K9XYu3qr4xIv8lx1USIQ8REK'),

  ('NV021', N'Nguyễn Văn An', CONVERT(date,'02/02/1987',103), N'Nam','nvan@ttthi.vn', '0912345671','012345678921', N'Hà Nội', N'Coi thi', 7500000, 'PB005', '$2a$11$tufZ9fXXaVHHNKKuvC7ia.lWBAsmWjiLdZu0.LfElxG4Q1q0OtY1a'),
  ('NV022', N'Trần Thị Bích', CONVERT(date,'15/05/1988',103), N'Nữ','ttbich@ttthi.vn', '0912345672','012345678922', N'Hải Phòng', N'Coi thi', 7600000, 'PB005', '$2a$11$tufZ9fXXaVHHNKKuvC7ia.lWBAsmWjiLdZu0.LfElxG4Q1q0OtY1a'),
  ('NV023', N'Lê Thị Cẩm', CONVERT(date,'23/03/1990',103), N'Nữ','ltcam@ttthi.vn', '0912345673','012345678923', N'Đà Nẵng', N'Coi thi', 7400000, 'PB005', '$2a$11$tufZ9fXXaVHHNKKuvC7ia.lWBAsmWjiLdZu0.LfElxG4Q1q0OtY1a'),
  ('NV024', N'Phạm Văn Dũng', CONVERT(date,'30/07/1989',103), N'Nam','pvdung@ttthi.vn', '0912345674','012345678924', N'Huế', N'Coi thi', 7700000, 'PB005', '$2a$11$tufZ9fXXaVHHNKKuvC7ia.lWBAsmWjiLdZu0.LfElxG4Q1q0OtY1a'),
  ('NV025', N'Hoàng Thị Hạnh', CONVERT(date,'11/11/1991',103), N'Nữ','hthanh@ttthi.vn', '0912345675','012345678925', N'Nghệ An', N'Coi thi', 7550000, 'PB005', '$2a$11$tufZ9fXXaVHHNKKuvC7ia.lWBAsmWjiLdZu0.LfElxG4Q1q0OtY1a'),
  ('NV026', N'Vũ Đức Anh', CONVERT(date,'05/09/1986',103), N'Nam','vdanh@ttthi.vn', '0912345676','012345678926', N'Quảng Ninh', N'Coi thi', 7650000, 'PB005', '$2a$11$tufZ9fXXaVHHNKKuvC7ia.lWBAsmWjiLdZu0.LfElxG4Q1q0OtY1a'),
  ('NV027', N'Đặng Thị Mai', CONVERT(date,'19/12/1988',103), N'Nữ','dtmai@ttthi.vn', '0912345677','012345678927', N'Nam Định', N'Coi thi', 7500000, 'PB005', '$2a$11$tufZ9fXXaVHHNKKuvC7ia.lWBAsmWjiLdZu0.LfElxG4Q1q0OtY1a'),
  ('NV028', N'Bùi Văn Hùng', CONVERT(date,'27/06/1992',103), N'Nam','bvhung@ttthi.vn', '0912345678','012345678928', N'Quảng Trị', N'Coi thi', 7800000, 'PB005', '$2a$11$tufZ9fXXaVHHNKKuvC7ia.lWBAsmWjiLdZu0.LfElxG4Q1q0OtY1a'),
  ('NV029', N'Trịnh Thị Phương', CONVERT(date,'08/08/1987',103), N'Nữ','ttphuong@ttthi.vn', '0912345679','012345678929', N'Hải Dương', N'Coi thi', 7450000, 'PB005', '$2a$11$tufZ9fXXaVHHNKKuvC7ia.lWBAsmWjiLdZu0.LfElxG4Q1q0OtY1a'),
  ('NV030', N'Phan Văn Sơn', CONVERT(date,'14/04/1990',103), N'Nam','pvson@ttthi.vn', '0912345680','012345678930', N'Thái Bình', N'Coi thi', 7600000, 'PB005', '$2a$11$tufZ9fXXaVHHNKKuvC7ia.lWBAsmWjiLdZu0.LfElxG4Q1q0OtY1a'),
  ('NV031', N'Đỗ Thị Hoài', CONVERT(date,'22/02/1991',103), N'Nữ','dthoai@ttthi.vn', '0912345681','012345678931', N'Bắc Giang', N'Coi thi', 7550000, 'PB005', '$2a$11$tufZ9fXXaVHHNKKuvC7ia.lWBAsmWjiLdZu0.LfElxG4Q1q0OtY1a'),
  ('NV032', N'Lê Thị Thanh', CONVERT(date,'09/10/1989',103), N'Nữ','ltthanh@ttthi.vn', '0912345682','012345678932', N'Hà Tĩnh', N'Coi thi', 7700000, 'PB005', '$2a$11$tufZ9fXXaVHHNKKuvC7ia.lWBAsmWjiLdZu0.LfElxG4Q1q0OtY1a');
GO

INSERT INTO THONGBAO (TB_MaThongBao, TB_MaNhanVienGui, TB_MaDoiTuongNhan, TB_ChuDe, TB_NoiDung, TB_ThoiGianGui) 
VALUES
  ('A3B4E9D3-1C2F-4A36-8B1F-7E5F6C3B8A6E', 'NV001', 'NV006', N'Họp', N'Chào bạn, mời tham dự cuộc họp lúc 14:00 hôm nay.', '2025-06-21 09:30:00'),
  ('5D2F37FA-8E09-4BD4-97B3-3E6F4320B2A5', 'NV001', 'NV007', N'Họp', N'Chào bạn, mời tham dự cuộc họp lúc 14:00 hôm nay.', '2025-06-21 09:30:00'),
  ('F0D0A519-43A0-4376-8326-BF5828D6C0E9', 'NV002', 'NV011', N'Xác nhận họp', N'Xác nhận đã nhận thông báo và sẽ tham gia đúng giờ.', '2025-06-21 10:00:00'),
  ('8B62A8CB-F915-493C-91AC-AEA31389B3D7', 'NV003', 'NV011', N'Báo cáo' , N'Báo cáo đã hoàn tất và gửi cho bạn xem qua.', '2025-06-20 16:45:00'),
  ('1071D9FC-1B18-4BA3-9D87-3C3F0AE1E9AF', 'NV011', 'NV003', N'Kiểm tra', N'Xin bạn kiểm tra hồ sơ nhân viên mới.', '2025-06-19 11:20:00'),
  ('27E31E9A-A994-4FD7-8DBF-A0D0C4F72701', 'NV011', 'NV004', N'Nhắc nhở', N'Nhắc bạn cập nhật tiến độ dự án đến cuối tuần.', '2025-06-18 15:00:00'),
  ('34B6D27B-27DD-4F12-A89A-059EBF064F77', 'NV016', 'NV002', N'Phản hồi', N'Progress đã xong 80%, đang đợi phản hồi.', '2025-06-18 16:30:00'),
  ('67DF5E9C-2E3B-4D35-B154-933D1767E0DE', 'NV012', 'PB003', N'Phản hồi', N'Nhập liệu thông tin người này: \n a, \n b', '2025-03-12 15:30:00');
GO

INSERT INTO LICHTHI
  (LT_MaLichThi, LT_MaKyThi, LT_SLDangKy, LT_TrangThai, LT_TenKyThi, LT_NgayThi, LT_MaPhongThi, LT_TGBatDau, LT_TGKetThuc)
VALUES
  ('LT01', 'KT01', 20, N'Chưa thi', N'Kỳ thi tiếng Anh A2',
   '2025-08-20', 'P001', '08:00:00', '10:00:00'),
  ('LT02', 'KT02', 18, N'Chưa thi', N'Kỳ thi tiếng Anh B1',
   '2025-07-21', 'P002', '13:00:00', '15:00:00'),
  ('LT03', 'KT03', 25, N'Chưa thi', N'Kỳ thi Tin học văn phòng MOC',
   '2025-07-15', 'P003', '09:00:00', '11:30:00'),
  ('LT04', 'KT04', 23, N'Chưa thi', N'Kỳ thi tiếng Anh TOEIC',
   '2025-07-17', 'P004', '14:00:00', '17:00:00'),
  ('LT05', 'KT09', 15, N'Chưa thi', N'Kỳ thi Tin học IC3',
   '2025-08-05', 'P005', '08:30:00', '10:30:00'),
  ('LT06', 'KT01', 17, N'Chưa thi', N'Kỳ thi tiếng Anh A2',
   '2025-08-20', 'P001', '08:00:00', '10:00:00'),
  ('LT07', 'KT05', 17, N'Đã thi', N'Kỳ thi tiếng Anh TOEFL',
   '2025-06-20', 'P006', '08:00:00', '10:00:00');
GO

INSERT INTO PHIEUDANGKYDUTHI 
(PDKDT_MaPhieu, PDKDT_ThoiGianLap, PDKDT_DiaChiChuyenPhat, PDKDT_TrangThaiThanhToan, PDKDT_MaKhachHang, PDKDT_MaLichThi, PDKDT_MaNhanVienLap)
VALUES
  ('PDK00001', '2025-06-01', N'12 Nguyễn Văn Cừ, Hà Nội', N'Đã thanh toán', 'KH00001', 'LT01', 'NV001'),
  ('PDK00002', '2025-06-02', N'45 Trần Phú, Hà Nội', N'Đã thanh toán', 'KH00002', 'LT01', 'NV002'),
  ('PDK00003', '2025-06-03', N'98 Lê Lợi, Đà Nẵng', N'Đã thanh toán', 'KH00003', 'LT02', 'NV003'),
  ('PDK00004', '2025-06-03', N'22 Phan Đình Phùng, Huế', N'Đã thanh toán', 'KH00004', 'LT02', 'NV004'),
  ('PDK00005', '2025-06-04', N'36 Điện Biên Phủ, Hải Phòng', N'Đã thanh toán', 'KH00005', 'LT03', 'NV005'),
  ('PDK00006', '2025-06-04', N'88 Nguyễn Huệ, Cần Thơ', N'Đã thanh toán', 'KH00006', 'LT03', 'NV001'),
  ('PDK00007', '2025-06-05', N'10 Trưng Nữ Vương, HCM', N'Đã thanh toán', 'KH00007', 'LT06', 'NV002'),
  ('PDK00008', '2025-06-06', N'49 Pasteur, HCM', N'Đã thanh toán', 'KH00008', 'LT06', 'NV003'),
  ('PDK00009', '2025-06-07', N'52 Lý Tự Trọng, Hà Nội', N'Đã thanh toán', 'KH00009', 'LT05', 'NV004'),
  ('PDK00010', '2025-06-07', N'33 Nguyễn Tri Phương, ĐN', N'Đã thanh toán', 'KH00010', 'LT05', 'NV005'),

  ('PDK00011', '2025-06-11', N'12 Nguyễn Văn Cừ, Hà Nội', N'Chưa thanh toán', 'KH00011', 'LT01', 'NV001'),
  ('PDK00012', '2025-06-12', N'45 Trần Phú, Hà Nội', N'Chưa thanh toán', 'KH00012', 'LT01', 'NV002'),
  ('PDK00013', '2025-06-13', N'98 Lê Lợi, Đà Nẵng', N'Thanh toán gia hạn', 'KH00013', 'LT02', 'NV003'),
  ('PDK00014', '2025-06-12', N'22 Phan Đình Phùng, Huế', N'Chưa thanh toán', 'KH00014', 'LT02', 'NV004'),
  ('PDK00015', '2025-06-01', N'36 Điện Biên Phủ, Hải Phòng', N'Chưa thanh toán', 'KH00015', 'LT03', 'NV005'),
  ('PDK00016', '2025-06-02', N'88 Nguyễn Huệ, Cần Thơ', N'Chưa thanh toán', 'KH00016', 'LT03', 'NV001'),
  ('PDK00017', '2025-06-02', N'10 Trưng Nữ Vương, HCM', N'Thanh toán gia hạn', 'KH00017', 'LT06', 'NV002'),
  ('PDK00018', '2025-06-04', N'49 Pasteur, HCM', N'Chưa thanh toán', 'KH00018', 'LT06', 'NV003'),
  ('PDK00019', '2025-06-01', N'52 Lý Tự Trọng, Hà Nội', N'Chưa thanh toán', 'KH00019', 'LT05', 'NV004'),
  ('PDK00020', '2025-06-02', N'33 Nguyễn Tri Phương, ĐN', N'Chưa thanh toán', 'KH00020', 'LT05', 'NV005'),

  ('PDKD0001', '2025-06-12', N'23/3B Hùng Vương, HCM', N'Đã thanh toán', 'KHDV001', 'LT04', 'NV002'),
  ('PDKD0002', '2025-06-13', N'13/9 Nam Kỳ Khởi Nghĩa, Hà Nội', N'Chưa thanh toán', 'KHDV002', 'LT06', 'NV002')
GO

INSERT INTO PHIEUTHANHTOAN 
  (PTT_MaPhieu, PTT_MaPhieuDK, PTT_NhanVienLap, PTT_NgayIn, 
   PTT_SoTienBanDau, PTT_PhanTramGiam, PTT_SoTienThanhToan, 
   PTT_HinhThucThanhToan, PTT_ThoiHan, PTT_GhiChu)
VALUES
  -- PDK00001
  ('PTT00001','PDK00001','NV001','2025-06-01',
    500000, 0, 500000, N'Tiền mặt',
    '2025-07-01', N''),
  -- PDK00002
  ('PTT00002','PDK00002','NV002','2025-06-02',
    500000, 0, 500000, N'Tiền mặt',
    '2025-07-02', N''),
  -- PDK00003
  ('PTT00003','PDK00003','NV003','2025-06-03',
    700000, 0, 700000, N'Tiền mặt',
    '2025-07-03', N''),
  -- PDK00004
  ('PTT00004','PDK00004','NV004','2025-06-03',
    700000, 0, 700000, N'Tiền mặt',
    '2025-07-03', N''),
  -- PDK00005
  ('PTT00005','PDK00005','NV005','2025-06-04',
    600000, 0, 600000, N'Tiền mặt',
    '2025-07-04', N''),
  -- PDK00006
  ('PTT00006','PDK00006','NV001','2025-06-04',
    600000, 0, 600000, N'Tiền mặt',
    '2025-07-04', N''),
  -- PDK00007
  ('PTT00007','PDK00007','NV002','2025-06-05',
    800000, 0, 800000, N'Tiền mặt',
    '2025-07-05', N''),
  -- PDK00008
  ('PTT00008','PDK00008','NV003','2025-06-06',
    800000, 0, 800000, N'Tiền mặt',
    '2025-07-06', N''),
  -- PDK00009
  ('PTT00009','PDK00009','NV004','2025-06-07',
    900000, 0, 900000, N'Tiền mặt',
    '2025-07-07', N''),
  -- PDK00010
  ('PTT00010','PDK00010','NV005','2025-06-07',
    900000, 0, 900000, N'Tiền mặt',
    '2025-07-07', N''),
  -- PDKD0001 (Áp dụng 10% giảm giá)
  ('PTT00011','PDKD0001','NV002','2025-06-12',
    18400000, 0.2, 14720000, N'Chuyển khoản',
    '2025-07-12', N'Giảm 10% giá kỳ thi');
GO

INSERT INTO THISINH (TS_SoBaoDanh, TS_MaPhieuDangKy, TS_HoTen, TS_NgaySinh, TS_GioiTinh, TS_Email, TS_SDT, TS_CCCD)
VALUES
  ('TS00001', 'PDK00001', N'Nguyễn Văn Minh', CONVERT(date, '01/04/2004', 103), N'Nam', 'r3a1w@example.com', '0311000231', '082306716472'),
  ('TS00002', 'PDK00002', N'Lê Thành Quân', CONVERT(date, '21/05/2001', 103), N'Nam', 'u827e@example', '0987680821', '083309827645'),
  ('TS00003', 'PDK00003', N'Nguyễn Thị Lệ Quyên', CONVERT(date, '09/07/2002', 103), N'Nữ', '8iew2@example', '0384650821', '084409883725'),
  ('TS00004', 'PDK00004', N'Phạm Thị Dung', CONVERT(date, '19/12/2003', 103), N'Nữ', '3r4d4@example.com', '0367891904', '082209870541'),
  ('TS00005', 'PDK00005', N'Lê Thị Phương Khanh', CONVERT(date, '19/12/2003', 103), N'Nữ', '9ui2u@example.com', '0768902748', '082304467891'),
  ('TS00006', 'PDK00006', N'Trần Nhân Tâm', CONVERT(date, '09/11/2002', 103), N'Nam', '9io0d@example.com', '0345902748', '082208597941'),
  ('TS00007', 'PDK00007', N'Đỗ Hữu Thành', CONVERT(date,'22/11/2003',103), N'Nam','3r43r@example.com', '0930009990','012345678907'),
  ('TS00008', 'PDK00008', N'Bùi Thái Tiến', CONVERT(date,'30/06/2001',103), N'Nam','r34h8@example.com', '0941002008','012345678908'),
  ('TS00009', 'PDK00009', N'Lê Nguyễn Trúc Hồng', CONVERT(date,'14/09/1999',103), N'Nữ','9oi8u@example.com', '0761044009','012345678909'),
  ('TS00010', 'PDK00010', N'Đỗ Thị Lan', CONVERT(date,'27/03/1997',103), N'Nữ','ssk10@example.com', '0340103009','012345678910'),
  ('TS00011', 'PDK00011', N'Nguyễn Như Mai', CONVERT(date,'02/01/1999',103), N'Nữ','90oi8@example.com', '0871002009','012345678911'),
  ('TS00012', 'PDK00012', N'Lê Đức Duy', CONVERT(date,'09/10/2000',103), N'Nam','zq3i8@example.com', '0341070209','012345678912'),
  ('TS00013', 'PDK00013', N'Vũ Tuyết Ngọc', CONVERT(date,'16/04/2004',103), N'Nữ','o90u7@example.com', '0831050609','012345678913'),
  ('TS00014', 'PDK00014', N'Nguyễn Hoàng Hưng', CONVERT(date,'25/12/1998',103), N'Nam','4nh7u@example.com', '0935624259','012345678914'),
  ('TS00015', 'PDK00015', N'Huỳnh Minh Thư', CONVERT(date,'11/11/2001',103), N'Nữ','2was2@example.com', '0921040009','012345678915'),
  ('TS00016', 'PDK00016', N'Lê Thị Ngọc Yến', CONVERT(date,'19/08/2000',103), N'Nữ','p2wp3@example.com', '0811060309','012345678916'),
  ('TS00017', 'PDK00017', N'Nguyễn Hồng Phong', CONVERT(date,'03/03/2005',103), N'Nam','f2pp3@example.com', '0331000009','012345678917'),
  ('TS00018', 'PDK00018', N'Nguyễn Quốc Thiện', CONVERT(date,'29/09/2001',103), N'Nam','k9s21@example.com', '0341012309','012345678918'),
  ('TS00019', 'PDK00019', N'Đoàn Trà My', CONVERT(date,'07/07/2007',103), N'Nữ','n8new@example.com', '0821000238','012345678919'),
  ('TS00020', 'PDK00020',N'Trịnh Hoàng Khải', CONVERT(date,'21/05/2010',103), N'Nam','h9p23@example.com', '0941490391','012345678920'),
 
  ('TSD00001', 'PDKD0001', N'Đinh Phương Mai', CONVERT(date,'11/04/1999',103), N'Nữ','dư9q23@example.com', '0873618913','012345678921'),
  ('TSD00002', 'PDKD0001', N'Lưu Trung Kiên', CONVERT(date,'01/02/2000',103), N'Nam','0od23@example.com', '0974718495','012345678922'),
  ('TSD00003', 'PDKD0001', N'Mạc Thị Thảo', CONVERT(date,'04/02/2001',103), N'Nữ','9diwq@example.com', '0193758361','012345678923'),
  ('TSD00004', 'PDKD0001', N'Kiều Thu Trang', CONVERT(date,'13/05/2002',103), N'Nữ','8i39s@example.com', '0492718583','012345678924'),
  ('TSD00005', 'PDKD0001', N'Trương Công Phúc', CONVERT(date,'14/12/2001',103), N'Nam','9d0ow@example.com', '0820983899','012345678925'),
  ('TSD00006', 'PDKD0001', N'Hồ Sỹ Tuấn', CONVERT(date,'21/03/2004',103), N'Nam','05o9x@example.com', '0561240148','012345678926'),
  ('TSD00007', 'PDKD0001', N'Tạ Quang Vinh', CONVERT(date,'06/05/2001',103), N'Nam','d0sdos@example.com', '0358129170','012345678927'),
  ('TSD00008', 'PDKD0001', N'Ngô Thúy Hằng', CONVERT(date,'15/09/2002',103), N'Nữ','đosjw@example.com', '0704056190','012345678928'),
  ('TSD00009', 'PDKD0001', N'Đặng Quốc Huy', CONVERT(date,'22/02/2003',103), N'Nam','hoasoaks@example.com', '0707426454','012345678929'),
  ('TSD00010', 'PDKD0001', N'Mai Xuân Trường', CONVERT(date,'17/04/2003',103), N'Nam','hsqo@example.com', '0786383603','012345678930'),
  ('TSD00011', 'PDKD0001', N'Nguyễn Thanh Huyền Trang', CONVERT(date,'11/07/2007',103), N'Nữ','9d92js@example.com', '0841509206','012345678931'),
  ('TSD00012', 'PDKD0001', N'Nguyễn Thị Hoài Diệu', CONVERT(date,'15/01/1998',103), N'Nữ','9ejssxz@example.com', '0707469223','012345678932'),	
  ('TSD00013', 'PDKD0001', N'Lê Vỹ Minh', CONVERT(date,'13/09/1996',103), N'Nam','e9jxsx@example.com', '0388260829','012345678933'),
  ('TSD00014', 'PDKD0001', N'Võ Hoài Phương', CONVERT(date,'08/06/2001',103), N'Nữ','23us8du@example.com', '0848958780','012345678934'),
  ('TSD00015', 'PDKD0001', N'Đoàn Nguyễn Minh Nguyệt', CONVERT(date,'12/10/2005',103), N'Nữ','d92o0d@example.com', '0770497229','012345678935'),
  ('TSD00016', 'PDKD0001', N'Bùi Kim Ngọc', CONVERT(date,'21/05/2011',103), N'Nữ','x9aoq@example.com', '0344057539','012345678936'),
  ('TSD00017', 'PDKD0001', N'Nguyễn Phương Mai', CONVERT(date,'11/03/2004',103),N'Nữ','02eopzx@example.com', '0866498678','012345678937'),
  ('TSD00018', 'PDKD0001', N'Trịnh Nhật Tân', CONVERT(date,'10/01/2007',103),N'Nam','02paxj@example.com', '0820111885','012345678938'),
  ('TSD00019', 'PDKD0001', N'Trần Nguyễn Anh Ngọc', CONVERT(date,'30/06/2008',103),N'Nam','8ei3dw@example.com', '0861407047','012345678939'),
  ('TSD00020', 'PDKD0001', N'Lại Hoàng Giang', CONVERT(date,'31/05/2006',103),N'Nam','xmakd2@example.com', '0562201841','012345678940'),
  ('TSD00021', 'PDKD0001', N'Hoàng Tuấn Phong', CONVERT(date,'29/07/2001',103),N'Nam','xzkxnqi@example.com', '0941490391','012345678941'),
  ('TSD00022', 'PDKD0001', N'Phùng Ngọc Điệp', CONVERT(date,'02/01/2004',103),N'Nữ','24knzzx@example.com', '0336292789','012345678942'),
  ('TSD00023', 'PDKD0001', N'Phạm Vũ Nhã Trâm', CONVERT(date,'20/08/2003',103),N'Nữ','d02idap@example.com', '0333874352','012345678943'),

  ('TSD00024', 'PDKD0002', N'Phạm Minh Anh', CONVERT(date, '14/02/2000', 103), N'Nữ', 'mjcsih14@example.com', '0324567890', '012345678944'),
  ('TSD00025', 'PDKD0002', N'Ngô Văn Dũng', CONVERT(date, '03/11/1999', 103), N'Nam', 'dudsogo03@example.com', '0387654321', '012345678945'),
  ('TSD00026', 'PDKD0002', N'Lê Thị Bích Ngọc', CONVERT(date, '27/06/2001', 103), N'Nữ', 'bidsooc27@example.com', '0761234567', '012345678946'),
  ('TSD00027', 'PDKD0002', N'Võ Hoàng Long', CONVERT(date, '19/09/2002', 103), N'Nam', 'hd20ng19@example.com', '0842345678', '012345678947'),
  ('TSD00028', 'PDKD0002', N'Trần Thị Hạnh', CONVERT(date, '05/05/2003', 103), N'Nữ', 'hadiw2n05@example.com', '0913456789', '012345678948'),
  ('TSD00029', 'PDKD0002', N'Đinh Văn Phú', CONVERT(date, '12/12/1998', 103), N'Nam', 'vad29s2@example.com', '0334567012', '012345678949'),
  ('TSD00030', 'PDKD0002', N'Bùi Thị Thuỳ Linh', CONVERT(date, '23/03/2000', 103), N'Nữ', 'sdj82h23@example.com', '0356789012', '012345678950'),
  ('TSD00031', 'PDKD0002', N'Phan Công Hậu', CONVERT(date, '01/08/2001', 103), N'Nam', 'cod20s1@example.com', '0901234567', '012345678951'),
  ('TSD00032', 'PDKD0002', N'Hoàng Thị Ánh', CONVERT(date, '17/10/1997', 103), N'Nữ', 'd2dkwg17@example.com', '0822345678', '012345678952'),
  ('TSD00033', 'PDKD0002', N'Lưu Minh Tuấn', CONVERT(date, '29/04/2002', 103), N'Nam', 'md929@example.com', '0323456789', '012345678953'),
  ('TSD00034', 'PDKD0002', N'Nguyễn Thị Thanh Vân', CONVERT(date, '08/07/1999', 103), N'Nữ', 'th20san08@example.com', '0934567123', '012345678954'),
  ('TSD00035', 'PDKD0002', N'Trương Hữu Phúc', CONVERT(date, '21/01/2000', 103), N'Nam', 'huusiw1@example.com', '0345678123', '012345678955'),
  ('TSD00036', 'PDKD0002', N'Vũ Thị Diễm My', CONVERT(date, '11/11/2003', 103), N'Nữ', 'ddsd21@example.com', '0902345678', '012345678956'),
  ('TSD00037', 'PDKD0002', N'Phạm Xuân Kiên', CONVERT(date, '06/06/1998', 103), N'Nam', 'qqkeen06@example.com', '0763456789', '012345678957'),
  ('TSD00038', 'PDKD0002', N'Đỗ Thị Thanh Hằng', CONVERT(date, '25/02/2001', 103), N'Nữ', 'tdsd2qw5@example.com', '0384567123', '012345678958'),
  ('TSD00039', 'PDKD0002', N'Lê Văn Hoài', CONVERT(date, '15/09/1997', 103), N'Nam', 'dwwds15@example.com', '0815678123', '012345678959'),
  ('TSD00040', 'PDKD0002', N'Huỳnh Thị Ngọc Mai', CONVERT(date, '30/12/2002', 103), N'Nữ', 'ngfw220@example.com', '0946789012', '012345678960'),
  ('TSD00041', 'PDKD0002', N'Nguyễn Công Thắng', CONVERT(date, '09/03/1999', 103), N'Nam', 'con2ang09@example.com', '0356789123', '012345678961'),
  ('TSD00042', 'PDKD0002', N'Trần Thị Kim Oanh', CONVERT(date, '18/08/2000', 103), N'Nữ', 'kd2q18@example.com', '0327890123', '012345678962'),
  ('TSD00043', 'PDKD0002', N'Phùng Văn Đức', CONVERT(date, '02/10/2001', 103), N'Nam', 'wiocx2@example.com', '0903456789', '012345678963');
GO
-- DELETE FROM PHIEUDUTHI
INSERT INTO PHIEUDUTHI 
(PDT_MaPhieu, PDT_MaPhieuDangKy, PDT_SoBaoDanh, PDT_MaLichThi, PDT_MaPhongThi)
VALUES
  ('PDT003', 'PDK00003', 'TS00003', 'LT02', 'P002'),
  ('PDT004', 'PDK00004', 'TS00004', 'LT02', 'P002'),
  ('PDT005', 'PDK00005', 'TS00005', 'LT03', 'P003'),
  ('PDT006', 'PDK00006', 'TS00006', 'LT03', 'P003'),

  ('PDTD00001', 'PDKD0001', 'TSD00001', 'LT04', 'P004'),
  ('PDTD00002', 'PDKD0001', 'TSD00002', 'LT04', 'P004'),
  ('PDTD00003', 'PDKD0001', 'TSD00003', 'LT04', 'P004'),
  ('PDTD00004', 'PDKD0001', 'TSD00004', 'LT04', 'P004'),
  ('PDTD00005', 'PDKD0001', 'TSD00005', 'LT04', 'P004'),
  ('PDTD00006', 'PDKD0001', 'TSD00006', 'LT04', 'P004'),
  ('PDTD00007', 'PDKD0001', 'TSD00007', 'LT04', 'P004'),
  ('PDTD00008', 'PDKD0001', 'TSD00008', 'LT04', 'P004'),
  ('PDTD00009', 'PDKD0001', 'TSD00009', 'LT04', 'P004'),
  ('PDTD00010', 'PDKD0001', 'TSD00010', 'LT04', 'P004'),
  ('PDTD00011', 'PDKD0001', 'TSD00011', 'LT04', 'P004'),
  ('PDTD00012', 'PDKD0001', 'TSD00012', 'LT04', 'P004'),
  ('PDTD00013', 'PDKD0001', 'TSD00013', 'LT04', 'P004'),
  ('PDTD00014', 'PDKD0001', 'TSD00014', 'LT04', 'P004'),
  ('PDTD00015', 'PDKD0001', 'TSD00015', 'LT04', 'P004'),
  ('PDTD00016', 'PDKD0001', 'TSD00016', 'LT04', 'P004'),
  ('PDTD00017', 'PDKD0001', 'TSD00017', 'LT04', 'P004'),
  ('PDTD00018', 'PDKD0001', 'TSD00018', 'LT04', 'P004');
GO

/*
delete from CHUNGCHI
delete from PHIEUDUTHI
*/

INSERT INTO PHIEUGIAHAN(PGH_MaPhieu, PGH_MaPhieuDK, PGH_LyDoGiaHan, PGH_SoTienThanhToan, PGH_HinhThucThanhToan, PGH_ThoiHan, PHG_TrangThai)
VALUES 
  ('GH00001', 'PDK00013', N'Muốn hoãn ngày thi khác cho phong thủy', 90000, N'Tiền mặt', '2025-07-15', N'Chưa thanh toán')

INSERT INTO PHANCONG (PC_MaNhanVien, PC_MaLichThi, PC_TrangThai)
VALUES
  ('NV021', 'LT01', N'Chưa diễn ra'),
  ('NV022', 'LT02', N'Chưa diễn ra'),
  ('NV023', 'LT03', N'Chưa diễn ra'),
  ('NV027', 'LT03', N'Chưa diễn ra'),
  ('NV024', 'LT04', N'Chưa diễn ra'),
  ('NV025', 'LT05', N'Chưa diễn ra'),
  ('NV026', 'LT06', N'Chưa diễn ra'),
  ('NV027', 'LT07', N'Hoàn thành'),
  ('NV028', 'LT01', N'Chưa diễn ra'),
  ('NV029', 'LT02', N'Chưa diễn ra'),
  ('NV030', 'LT03', N'Chưa diễn ra'),
  ('NV031', 'LT04', N'Chưa diễn ra'),
  ('NV032', 'LT05', N'Chưa diễn ra');
GO

/*
select * from PHIEUDUTHI

INSERT INTO BAITHI(BT_MaBaiThi, BT_MaLichThi, BT_SoBaoDanh, BT_ThoiGianLamBai, BT_DiemSo, BT_DonViCham)
VALUES
  ('BTT00001', 'LT06', 'TSD00024', '00:00:00', 0, 'DVCT02'),
  ('BTT00002', 'LT06', 'TSD00025', '00:00:00', 0, 'DVCT02'),
  ('BTT00003', 'LT06', 'TSD00026', '00:00:00', 0, 'DVCT02'),
  ('BTT00004', 'LT06', 'TSD00027', '00:00:00', 0, 'DVCT02'),
  ('BTT00005', 'LT06', 'TSD00028', '00:00:00', 0, 'DVCT02'),
  ('BTT00006', 'LT06', 'TSD00029', '00:00:00', 0, 'DVCT02'),
  ('BTT00007', 'LT06', 'TSD00030', '00:00:00', 0, 'DVCT02');
GO

select * from BAITHI
*/


/*
INSERT INTO BAITHI
  (BT_MaBaiThi, BT_MaLichThi, BT_SoBaoDanh, BT_ThoiGianLamBai, BT_DiemSo, BT_DonViCham)
VALUES
  -- Đợt thi LT01
  ('BT0001', 'LT01', 'TS00001', '01:30:00',  7.5, 'DVCT01'),
  ('BT0002', 'LT01', 'TS00002', '01:45:00',  8.2, 'DVCT02'),
  ('BT0003', 'LT01', 'TS00003', '02:00:00',  6.9, 'DVCT01'),
  ('BT0004', 'LT01', 'TS00004', '01:20:00',  9.0, 'DVCT02'),
  ('BT0005', 'LT01', 'TS00005', '01:50:00',  5.5, 'DVCT01'),
  ('BT0006', 'LT01', 'TS00006', '02:10:00',  8.7, 'DVCT02'),
  ('BT0007', 'LT01', 'TS00007', '01:40:00',  7.8, 'DVCT01'),
  ('BT0008', 'LT01', 'TS00008', '01:35:00',  6.3, 'DVCT02'),
  ('BT0009', 'LT01', 'TS00009', '01:55:00',  9.5, 'DVCT01'),
  ('BT0010', 'LT01', 'TS00010', '02:00:00', 10.0, 'DVCT02'),

  -- Đợt thi LT02
  ('BT0011', 'LT02', 'TS00011', '01:25:00',  8.0, 'DVCT01'),
  ('BT0012', 'LT02', 'TS00012', '01:30:00',  7.2, 'DVCT02'),
  ('BT0013', 'LT02', 'TS00013', '01:45:00',  6.8, 'DVCT01'),
  ('BT0014', 'LT02', 'TS00014', '02:05:00',  9.1, 'DVCT02'),
  ('BT0015', 'LT02', 'TS00015', '01:50:00',  5.9, 'DVCT01'),
  ('BT0016', 'LT02', 'TS00016', '01:35:00',  8.4, 'DVCT02'),
  ('BT0017', 'LT02', 'TS00017', '01:40:00',  7.6, 'DVCT01'),
  ('BT0018', 'LT02', 'TS00018', '02:10:00',  6.5, 'DVCT02'),
  ('BT0019', 'LT02', 'TS00019', '01:55:00',  9.3, 'DVCT01'),
  ('BT0020', 'LT02', 'TS00020', '02:00:00', 10.0, 'DVCT02');
GO
*/


/*
-- Xóa các bảng phụ thuộc trước
DELETE FROM PHANCONG;
DELETE FROM PHIEUDUTHI;
DELETE FROM PHIEUTHANHTOAN;
DELETE FROM THISINH;
DELETE FROM PHIEUGIAHAN;
DELETE FROM PHIEUDANGKYDUTHI;
DELETE FROM THONGBAO;
DELETE FROM LICHTHI;

-- Xóa các bảng gốc (ít phụ thuộc hơn)
DELETE FROM NHANVIEN;
DELETE FROM PHONGBAN;
DELETE FROM KHACHHANGHTUDO;
DELETE FROM KHACHHANGDONVI;
DELETE FROM KHACHHANG;
DELETE FROM KYTHI;
DELETE FROM DONVICHAMTHI;
DELETE FROM PHONGTHI;

GO
*/