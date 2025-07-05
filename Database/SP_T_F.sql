--Procedure - Trigger - Function

--STORE PROCEDURE
use DB_TRUNGTAMTHI;
go

--Kiểm tra tài khoản
create or alter procedure usp_GetPasswordOfUsername
	@email varchar(100),
	@password varchar(100) OUTPUT
as
begin
	set NOCOUNT ON;
	
	select @password = NV_MatKhau
	from NHANVIEN
	where NV_Email = @email;
end;
go

--Lấy chức vụ của nhân viên dựa vào mã nhân viên
create or alter procedure usp_GetRoleOfUser
	@username varchar(10),
	@role nvarchar(20) OUTPUT
as
begin
	set NOCOUNT ON;

	select @role = nv.NV_ChucVu
	from NHANVIEN as nv
	where nv.NV_MaNhanVien = @username
end;
go

--Lấy thông tin tài khoản đăng nhập
create or alter procedure usp_GetInfomationOfUser
	@username varchar(10)
as
begin
	set NOCOUNT ON;

	select * 
	from NHANVIEN
	where NV_MaNhanVien = @username
end;
go

--Tạo thông báo
create or alter procedure usp_CreateNotification
	@sender varchar(10),
	@recipient varchar(10),
	@subject nvarchar(50),
	@body nvarchar(200)
as
begin
	declare @sendTime datetime;

	set @sendTime = getdate();

	insert into THONGBAO(TB_MaNhanVienGui, TB_MaDoiTuongNhan, TB_ChuDe, TB_NoiDung, TB_ThoiGianGui)
	values(@sender, @recipient, @subject, @body, @sendTime)

end
go

--Hiển thị thông tin kết quả thi của thí sinh dựa vào kỳ thi
create or alter procedure usp_ThongTinKetQuaThi
	@examtest varchar(10)
as
begin
	set NOCOUNT ON;

	select ts.TS_SoBaoDanh, ts.TS_HoTen, ts.TS_CCCD, ts.TS_NgaySinh, ts.TS_GioiTinh, bt.BT_MaBaiThi, bt.BT_DiemSo, bt.BT_MaLichThi
	from BAITHI as bt join THISINH as ts on bt.BT_SoBaoDanh = ts.TS_SoBaoDanh
					  join LICHTHI as lt on bt.BT_MaLichThi = lt.LT_MaLichThi
	where lt.LT_MaKyThi = @examtest
end
go

--Cập nhật thông tin về thời gian làm bài, điểm thi và đơn vi chấm thi vào bài thi
create or alter procedure usp_CapNhatKetQuaThi
	@mabaithi varchar(10),
	@diemso float,
	@thoigian time,
	@donvicham varchar(10)
as
begin
	set NOCOUNT ON;

	if not exists( select 1 from BAITHI where BT_MaBaiThi = @mabaithi)
	begin
		print(N'Bài thi này không tồn tại.')
		return
	end
	else
	begin
		update BAITHI
		set BT_DiemSo = coalesce(@diemso, BT_DiemSo),
		    BT_DonViCham = coalesce(@donvicham, BT_DonViCham),
			BT_ThoiGianLamBai = coalesce(@thoigian, BT_ThoiGianLamBai)
		where BT_MaBaiThi = @mabaithi
	end
end
go


--Xóa bài thi
create or alter procedure usp_XoaBaiThi
	@mabaithi varchar(10)
as
begin
	set NOCOUNT ON;

	if not exists( select 1 from BAITHI where BT_MaBaiThi = @mabaithi)
	begin
		print(N'Bài thi này không tồn tại.')
		return
	end
	if exists( select 1 from CHUNGCHI where CC_MaBaiThi = @mabaithi)
	begin
		print(N'Bài thi đã được cấp chứng chỉ, hãy xóa chứng chỉ liên quan trước.')
		return
	end
	else
	begin
		delete from BAITHI
		where BT_MaBaiThi = @mabaithi
	end
end
go
/*
--Lấy danh sách lịch thi và giờ thi
create or alter procedure usp_ThongTinKetQuaThiNew
	@examdate varchar(10)
as
begin
	set NOCOUNT ON;

	select lt_
end
go

--Them thong tin bai thi
create or alter procedure usp_ThemBaiThi
	@examcode varchar(10),
	@examtest varchar(10),
	@candidate varchar(10),
	@examtime time,
	@point float,
	@examunit varchar(10)

as
begin
	set NOCOUNT ON;

	insert into BAITHI (BT_MaBaiThi, BT_MaKyThi, BT_SoBaoDanh, BT_ThoiGianLamBai, BT_DiemSo, BT_DonViCham)
	values(@examcode, @examtest, @candidate, @examtime, @point, @examunit)
end
go

--Cap nhat thong tin bai thi
create or alter procedure usp_CapNhatBaiThi
	@examcode varchar(10),
	@examtest varchar(10),
	@candidate varchar(10),
	@examtime time,
	@point float,
	@examunit varchar(10)

as
begin
	set NOCOUNT ON;

	if not exists(select * from BAITHI where BT_MaBaiThi = @examcode)
    begin
        print(N'Bai Thi khong ton tai')
        return
    end

	else
    begin
        update BAITHI
        set BT_MaKyThi = coalesce(@examtest, BT_MaKyThi),
            BT_SoBaoDanh = coalesce(@candidate, BT_SoBaoDanh),
            BT_ThoiGianLamBai = coalesce(@examtime, BT_ThoiGianLamBai),
            BT_DiemSo = coalesce(@point, BT_DiemSo), 
            BT_DonViCham = coalesce(@examunit, BT_DonViCham)
        where BT_MaBaiThi = @examcode;
    end
end
go
*/

--Xoa bai thi





---------------------------------------------------------------------------------------------------------------------------------------------------------

--CAC STORED PROCEDURE LIEN QUAN DEN KE TOAN

--Lay thong tin danh sach phieu thu (dang ki, gia han, thanh cong) ket hop tim kiem (TAB QUAN LI PHIEU THU, MUC DANH SACH CHO TAO PHIEU THU)
--drop procedure usp_GetReceiptTable
create or alter procedure usp_GetReceiptTable
	@search nvarchar(50) = NULL
as
begin
	set NOCOUNT on;

	select pdk.PDKDT_MaPhieu as MaPhieu, COALESCE(khtd.KHTD_HoTen, khdv.KHDV_TenDonVi) AS HoTen, pdk.PDKDT_MaKhachHang as MaKhachHang, lt.LT_TenKyThi as TenKyThi, kt.KT_LePhi as LePhi,  pdk.PDKDT_ThoiGianLap as NgayDangKy
	from PHIEUDANGKYDUTHI as pdk
	LEFT JOIN KHACHHANGHTUDO AS khtd ON pdk.PDKDT_MaKhachHang = khtd.KHTD_MaKhachHang
    LEFT JOIN KHACHHANGDONVI AS khdv ON pdk.PDKDT_MaKhachHang = khdv.KHDV_MaKhachHang
	join THISINH as ts on pdk.PDKDT_MaPhieu = ts.TS_MaPhieuDangKy
	join LICHTHI as lt on pdk.PDKDT_MaLichThi = lt.LT_MaLichThi
	join KYTHI as kt on lt.LT_MaKyThi = kt.KT_MaKyThi
	join KHACHHANG as kh on pdk.PDKDT_MaKhachHang = kh.KH_MaKhachHang
	WHERE (@search IS NULL 
       OR ts.TS_HoTen LIKE '%' + @search + '%' 
	   OR pdk.PDKDT_MaPhieu LIKE '%' + @search + '%')
	AND NOT EXISTS (
        SELECT 1 
        FROM PHIEUTHANHTOAN ptt
		WHERE ptt.PTT_MaPhieuDK = pdk.PDKDT_MaPhieu
    )
	order by pdk.PDKDT_ThoiGianLap
end;
go

/*
select * from PHIEUDANGKYDUTHI
select * from PHIEUTHANHTOAN

EXEC usp_GetReceiptTable @search = N'Ngọc';
go
EXEC usp_GetReceiptTable;
go
*/


--Lay thong tin danh sach phieu yeu cau gia han ket hop tim kiem (PREVIEW PHIEU THU/PHIEU THANH TOAN)
--drop procedure usp_GetRenewalRequestTable
create or alter procedure usp_GetRenewalRequestTable
	@search nvarchar(50) = NULL
as
begin
	set NOCOUNT on;
	select PDKDT_MaPhieu as MaPhieu, PDKDT_MaKhachHang as MaKH, KT_TenKyThi as TenKyThi, PDKDT_MaLichThi as MaLichThiMoi
	from PHIEUDANGKYDUTHI
	join THISINH on PDKDT_MaPhieu = TS_MaPhieuDangKy
	join LICHTHI on PDKDT_MaLichThi = LT_MaLichThi
	join KYTHI on LT_MaKyThi = KT_MaKyThi
	WHERE (@search IS NULL 
       OR TS_HoTen LIKE '%' + @search + '%' 
       OR TS_SoBaoDanh LIKE '%' + @search + '%'
	   OR PDKDT_MaPhieu LIKE '%' + @search + '%')
	and PDKDT_TrangThaiThanhToan = N'Thanh toán gia hạn'
	AND (
            SELECT COUNT(*) 
            FROM PHIEUGIAHAN
            WHERE PGH_MaPhieuDK = PDKDT_MaPhieu
        ) <= 2
	order by PDKDT_ThoiGianLap
end;
go

/*
select * from PHIEUGIAHAN

EXEC usp_GetRenewalRequestTable;
go
EXEC usp_GetRenewalRequestTable @search = N'Quyên';
go
*/



--Them thong tin phieu thu vao bang PHIEUTHANHTOAN
--drop procedure usp_InsertIntoPaycheckTable
create or alter procedure usp_InsertIntoPaycheckTable
	@maphieudk varchar(10),
	@nvlap varchar(10),
	@sotienbandau int,
	@phtramgiam float,
	@hinhthuc nvarchar(50),
	@ghichu nvarchar(200)
as
BEGIN
    SET NOCOUNT ON;

    DECLARE @newMaPhieu varchar(10);
    DECLARE @maxNumber int;
	DECLARE @sotienthanhtoan int;
	DECLARE @ngayin date = CAST(GETDATE() AS date);
	DECLARE @thoihan date = DATEADD(month, 1, @ngayin);

	SET @sotienthanhtoan = @sotienbandau*(1-@phtramgiam);

    -- Tìm số thứ tự lớn nhất hiện tại trong PTT_MaPhieu
    SELECT @maxNumber = ISNULL(MAX(CAST(SUBSTRING(PTT_MaPhieu, 4, 5) AS int)), 0)
    FROM PHIEUTHANHTOAN;

    -- Tăng số thứ tự lên 1 và định dạng thành PTTXXXXX
    SET @newMaPhieu = 'PTT' + RIGHT('00000' + CAST(@maxNumber + 1 AS varchar(5)), 5);

    -- Chèn dữ liệu vào bảng PHIEUTHANHTOAN
    INSERT INTO PHIEUTHANHTOAN 
        (PTT_MaPhieu, PTT_MaPhieuDK, PTT_NhanVienLap, PTT_NgayIn, PTT_SoTienBanDau, PTT_PhanTramGiam, PTT_SoTienThanhToan, PTT_HinhThucThanhToan, PTT_ThoiHan, PTT_GhiChu)
    VALUES 
        (@newMaPhieu, @maphieudk, @nvlap, @ngayin, @sotienbandau, @phtramgiam, @sotienthanhtoan, @hinhthuc, @thoihan, @ghichu);
	UPDATE PHIEUDANGKYDUTHI SET PDKDT_TrangThaiThanhToan = N'Chưa thanh toán' WHERE PDKDT_MaPhieu = @maphieudk;
END;
GO

/*
delete from PHIEUTHANHTOAN where PTT_MaPhieu = 'PTT00011';
delete from PHIEUTHANHTOAN where PTT_MaPhieu = 'PTT00012';

UPDATE PHIEUDANGKYDUTHI SET PDKDT_TrangThaiThanhToan = N'Đã thanh toán' WHERE PDKDT_MaPhieu = 'PDKD0001';

INSERT INTO PHIEUTHANHTOAN 
  (PTT_MaPhieu, PTT_MaPhieuDK, PTT_NhanVienLap, PTT_NgayIn, 
   PTT_SoTienBanDau, PTT_PhanTramGiam, PTT_SoTienThanhToan, 
   PTT_HinhThucThanhToan, PTT_ThoiHan, PTT_GhiChu)
VALUES
  -- PDKD0001 (Áp dụng 10% giảm giá)
  ('PTT00011','PDKD0001','NV002','2025-06-12',
    18400000, 0.2, 14720000, N'Chuyển khoản',
    '2025-07-12', N'Giảm 10% giá kỳ thi');

select * from PHIEUTHANHTOAN
select * from PHIEUDANGKYDUTHI where PDKDT_MaPhieu = 'PDKD0001'
*/

/*
EXEC usp_InsertIntoPaycheckTable
	@maphieudk = 'PDKD0001',
	@nvlap = 'NV002',
	@sotienbandau = 18400000,
	@phtramgiam = 0.2,
	@hinhthuc = N'Chuyển khoản',
	@ghichu = N'Giảm 10% giá kỳ thi';
go
*/



--Lay thong tin danh sach phieu thu (chua thanh toan, da thanh toan) (TAB QUAN LI PHIEU THU, MUC PHIEU THU DA TAO)
--drop procedure usp_GetPaycheckTable
create or alter procedure usp_GetPaycheckTable
as
begin
	select PTT_MaPhieu as MaPhieuTT,
	PTT_MaPhieuDK as MaPhieu,
	PTT_SoTienBanDau as SoTienBanDau,
	PTT_PhanTramGiam as PhanTramGiam,
	PTT_SoTienThanhToan as SoTienThanhToan,
	PTT_HinhThucThanhToan as HinhThuc,
	PTT_ThoiHan as ThoiHan,
	PDKDT_TrangThaiThanhToan as TrangThai
	from PHIEUTHANHTOAN
	join PHIEUDANGKYDUTHI on PDKDT_MaPhieu = PTT_MaPhieuDK
	where PDKDT_TrangThaiThanhToan != N'Thanh toán gia hạn'
end;
go

/*
exec usp_GetPaycheckTable;
go
*/



--Lay thong tin danh sach phieu gia han da tao (TAB QUAN LI PHIEU GIA HAN, MUC PHIEU GIA HAN DA TAO)
--drop procedure usp_GetCreatedRenewals
create or alter procedure usp_GetCreatedRenewals
as
begin
	select *
	from PHIEUGIAHAN
	join PHIEUDANGKYDUTHI on PDKDT_MaPhieu = PGH_MaPhieuDK
end;
go



-------------------------------------------------------------------
-- Phần của QUẢN TRỊ HỆ THỐNG
GO
--- Lấy tất cả các nhân viên
CREATE OR ALTER PROCEDURE usp_GetAllNhanVien
AS
BEGIN
    SELECT 
        NV_MaNhanVien as N'Mã NV', 
        NV_TenNhanVien as N'Họ Tên', 
        NV_NgaySinh as N'Ngày Sinh',
        NV_GioiTinh as N'Giới Tính',
        NV_Email as N'Email',
        NV_SDT as N'SĐT',
        NV_CCCD as N'CCCD',
        NV_DiaChi as N'Địa Chỉ',
        NV_ChucVu as N'Chức Vụ',
        NV_Luong as N'Lương',
        PB_TenPhongBan as N'Phòng Ban'
    FROM NHANVIEN 
    INNER JOIN PHONGBAN ON NHANVIEN.NV_MaPhongBan = PHONGBAN.PB_MaPhongBan
END;
GO

--- Tìm kiếm nhân viên theo các trường Mã nhân viên, tên nhân viên, chức vụ, phòng ban
CREATE OR ALTER PROCEDURE usp_SearchNhanVien
    @searchTerm NVARCHAR(100)
AS
BEGIN
    SELECT 
        NV_MaNhanVien as N'Mã NV', 
        NV_TenNhanVien as N'Họ Tên', 
        NV_NgaySinh as N'Ngày Sinh',
        NV_GioiTinh as N'Giới Tính',
        NV_Email as N'Email',
        NV_SDT as N'SĐT',
        NV_CCCD as N'CCCD',
        NV_DiaChi as N'Địa Chỉ',
        NV_ChucVu as N'Chức Vụ',
        NV_Luong as N'Lương',
        PB_TenPhongBan as N'Phòng Ban'
    FROM NHANVIEN 
    INNER JOIN PHONGBAN ON NHANVIEN.NV_MaPhongBan = PHONGBAN.PB_MaPhongBan
    WHERE NV_MaNhanVien LIKE '%' + @searchTerm + '%'
       OR NV_TenNhanVien LIKE '%' + @searchTerm + '%'
       OR NV_ChucVu LIKE '%' + @searchTerm + '%'
       OR PB_TenPhongBan LIKE '%' + @searchTerm + '%'
END;
GO
-- Thêm vào bảng NHANVIEN
CREATE OR ALTER PROCEDURE usp_AddNhanVien
    @MaNhanVien NVARCHAR(10),
    @TenNhanVien NVARCHAR(100),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(10),
    @Email NVARCHAR(100),
    @SDT CHAR(10),
    @CCCD CHAR(12),
    @DiaChi NVARCHAR(200),
    @ChucVu NVARCHAR(50),
    @Luong INT,
    @MaPhongBan NVARCHAR(10)
AS
BEGIN
    IF DATEDIFF(YEAR, @NgaySinh, GETDATE()) < 18
        OR (DATEDIFF(YEAR, @NgaySinh, GETDATE()) = 18 AND DATEADD(YEAR, 18, @NgaySinh) > GETDATE())
    BEGIN
        -- Nếu không đủ tuổi, báo lỗi và dừng lại ngay lập tức
        RAISERROR(N'Nhân viên phải đủ 18 tuổi trở lên!', 16, 1);
        RETURN;
    END

    BEGIN TRY
        BEGIN TRANSACTION
            -- Kiểm tra xem nhân viên đã tồn tại chưa
            IF EXISTS (SELECT 1 FROM NHANVIEN WHERE NV_MaNhanVien = @MaNhanVien)
            BEGIN
                RAISERROR(N'Mã nhân viên đã tồn tại!', 16, 1)
                RETURN
            END

            -- Thêm nhân viên mới
            INSERT INTO NHANVIEN (
                NV_MaNhanVien, 
                NV_TenNhanVien,
                NV_NgaySinh,
                NV_GioiTinh,
                NV_Email,
                NV_SDT,
                NV_CCCD,
                NV_DiaChi,
                NV_ChucVu,
                NV_Luong,
                NV_MaPhongBan,
				NV_MatKhau
            )
            VALUES (
                @MaNhanVien,
                @TenNhanVien,
                @NgaySinh,
                @GioiTinh,
                @Email,
                @SDT,
                @CCCD,
                @DiaChi,
                @ChucVu,
                @Luong,
                @MaPhongBan,
				'1234'
            )
            
            -- Trả về 1 nếu thành công
            SELECT 1 AS Result
        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        -- Trả về 0 và thông báo lỗi nếu thất bại
        SELECT 
            0 AS Result,
            ERROR_MESSAGE() AS ErrorMessage
        RETURN
    END CATCH
END;
GO


-- Chỉnh sửa nhân viên
CREATE OR ALTER PROCEDURE usp_UpdateNhanVien
    @MaNhanVien NVARCHAR(10),
    @TenNhanVien NVARCHAR(100),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(10),
    @Email NVARCHAR(100),
    @SDT NVARCHAR(20),
    @CCCD NVARCHAR(20),
    @DiaChi NVARCHAR(200),
    @ChucVu NVARCHAR(50),
    @Luong INT,
    @MaPhongBan NVARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    IF DATEDIFF(YEAR, @NgaySinh, GETDATE()) < 18
        OR (DATEDIFF(YEAR, @NgaySinh, GETDATE()) = 18 AND DATEADD(YEAR, 18, @NgaySinh) > GETDATE())
    BEGIN
        -- Nếu không đủ tuổi, báo lỗi và dừng lại
        RAISERROR(N'Nhân viên phải đủ 18 tuổi trở lên!', 16, 1);
        RETURN -1; -- Trả về một mã lỗi riêng biệt
    END
    UPDATE NHANVIEN
    SET
        NV_TenNhanVien = @TenNhanVien,
        NV_NgaySinh = @NgaySinh,
        NV_GioiTinh = @GioiTinh,
        NV_Email = @Email,
        NV_SDT = @SDT,
        NV_CCCD = @CCCD,
        NV_DiaChi = @DiaChi,
        NV_ChucVu = @ChucVu,
        NV_Luong = @Luong,
        NV_MaPhongBan = @MaPhongBan
    WHERE NV_MaNhanVien = @MaNhanVien;

    IF @@ROWCOUNT = 1
        RETURN 1; -- Thành công
    ELSE
        RETURN 0; -- Thất bại (không tìm thấy mã NV)
END
GO
--- Lấy tất cả phòng ban
CREATE OR ALTER PROCEDURE usp_GetAllPhongBan
AS
BEGIN
    SELECT PB_MaPhongBan, PB_TenPhongBan
    FROM PHONGBAN
    ORDER BY PB_TenPhongBan
END;
GO

-- Lấy mã nhân viên đầu tiên
CREATE OR ALTER PROCEDURE usp_GetLastEmployeeId
AS
BEGIN
    SELECT TOP 1 NV_MaNhanVien
    FROM NHANVIEN
    WHERE NV_MaNhanVien LIKE 'NV%'
    ORDER BY NV_MaNhanVien DESC
END;
GO

-- Lấy toàn bộ phân công của các nhân viên coi thi
CREATE OR ALTER PROCEDURE usp_GetPhanCong
AS
BEGIN
	SELECT 
        kt.KT_TenKyThi AS N'Tên Kỳ Thi', 
        lt.LT_NgayThi AS N'Ngày Thi', 
        lt.LT_MaPhongThi AS N'Phòng Thi', 
        lt.LT_TGBatDau AS N'Giờ Bắt Đầu', 
	    lt.LT_TGKetThuc AS N'Giờ Kết Thúc', 
        nv.NV_MaNhanVien AS N'Mã Nhân Viên', 
        nv.NV_TenNhanVien AS N'Tên Nhân Viên', 
        pc.PC_TrangThai AS N'Trạng Thái',
        lt.LT_MaLichThi -- Thêm cột này để dùng cho việc cập nhật
	FROM PHANCONG pc JOIN NHANVIEN nv ON nv.NV_MaNhanVien = pc.PC_MaNhanVien
	JOIN LICHTHI lt ON lt.LT_MaLichThi = pc.PC_MaLichThi
	JOIN KYTHI kt ON kt.KT_MaKyThi = lt.LT_MaKyThi
END;
GO

-- Xóa nhân viên
CREATE OR ALTER PROCEDURE usp_DeleteNhanVien
    @MaNhanVien VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Vô hiệu hóa các ràng buộc khóa ngoại
        ALTER TABLE THISINH NOCHECK CONSTRAINT ALL;
        ALTER TABLE PHIEUTHANHTOAN NOCHECK CONSTRAINT ALL;
        ALTER TABLE PHIEUGIAHAN NOCHECK CONSTRAINT ALL;
        ALTER TABLE PHIEUDUTHI NOCHECK CONSTRAINT ALL;

        -- Xóa các bản ghi tham chiếu
        DELETE FROM THONGBAO WHERE TB_MaNhanVienGui = @MaNhanVien;
        DELETE FROM PHANCONG WHERE PC_MaNhanVien = @MaNhanVien;
        DELETE FROM PHIEUTHANHTOAN WHERE PTT_NhanVienLap = @MaNhanVien;
        DELETE FROM PHIEUDANGKYDUTHI WHERE PDKDT_MaNhanVienLap = @MaNhanVien;

        -- Kích hoạt lại các ràng buộc
        ALTER TABLE THISINH CHECK CONSTRAINT ALL;
        ALTER TABLE PHIEUTHANHTOAN CHECK CONSTRAINT ALL;
        ALTER TABLE PHIEUGIAHAN CHECK CONSTRAINT ALL;
        ALTER TABLE PHIEUDUTHI CHECK CONSTRAINT ALL;

        -- Xóa nhân viên
        DELETE FROM NHANVIEN WHERE NV_MaNhanVien = @MaNhanVien;

        COMMIT TRANSACTION;
        SELECT 1 AS Result;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT ERROR_MESSAGE();
        SELECT 0 AS Result;
    END CATCH;
END;
GO

-- Chỉnh sửa thông tin phân công
CREATE OR ALTER PROCEDURE usp_UpdatePhanCong
    @MaLichThi VARCHAR(10),
    @MaNhanVienCu VARCHAR(10),
    @MaNhanVienMoi VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        -- Cập nhật mã nhân viên trong bảng PHANCONG
        UPDATE PHANCONG
        SET PC_MaNhanVien = @MaNhanVienMoi
        WHERE PC_MaLichThi = @MaLichThi AND PC_MaNhanVien = @MaNhanVienCu;

        SELECT 1 AS Result; -- Trả về 1 nếu thành công
    END TRY
    BEGIN CATCH
        SELECT 0 AS Result; -- Trả về 0 nếu thất bại
    END CATCH;
END;
GO

--- Lấy tên nhân viên theo mã nhân viên
CREATE OR ALTER PROCEDURE usp_GetTenNhanVien
    @MaNhanVien VARCHAR(10)
AS
BEGIN
    SELECT NV_TenNhanVien FROM NHANVIEN WHERE NV_MaNhanVien = @MaNhanVien;
END;
GO

-- Xóa thông tin phân công
CREATE OR ALTER PROCEDURE usp_DeletePhanCong
    @MaLichThi VARCHAR(10),
    @MaNhanVien VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        DELETE FROM PHANCONG
        WHERE PC_MaLichThi = @MaLichThi AND PC_MaNhanVien = @MaNhanVien;
        SELECT 1 AS Result; -- Trả về 1 nếu thành công
    END TRY
    BEGIN CATCH
        SELECT 0 AS Result; -- Trả về 0 nếu thất bại
    END CATCH;
END;
GO

GO
-- Lấy danh sách lịch thi theo kỳ thi
CREATE OR ALTER PROCEDURE usp_GetLichThiByKyThi
    @MaKyThi VARCHAR(10)
AS
BEGIN
    SELECT LT_MaLichThi, 
           CONVERT(varchar, LT_NgayThi, 103) + ' - Ca lúc ' + CONVERT(varchar(5), LT_TGBatDau, 108) AS DisplayText,
           LT_MaPhongThi,
           LT_NgayThi,
           LT_TGBatDau,
           LT_TGKetThuc
    FROM LICHTHI
    WHERE LT_MaKyThi = @MaKyThi AND LT_TrangThai = N'Chưa thi';
END;

GO
-- Lấy danh sách nhân viên coi thi chưa được phân công cho một lịch thi cụ thể
CREATE OR ALTER PROCEDURE usp_GetAvailableNhanVienForLichThi
AS
BEGIN
    SELECT NV_MaNhanVien AS N'Mã NV', NV_TenNhanVien AS N'Tên NV'
    FROM NHANVIEN
    WHERE NV_ChucVu = N'Coi thi';
END;

GO
-- Thêm một phân công mới
CREATE OR ALTER PROCEDURE usp_AddPhanCong
    @MaLichThi VARCHAR(10),
    @MaNhanVien VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM PHANCONG WHERE PC_MaLichThi = @MaLichThi AND PC_MaNhanVien = @MaNhanVien)
    BEGIN
        RAISERROR(N'Nhân viên này đã được phân công cho lịch thi này.', 16, 1);
        RETURN;
    END

    INSERT INTO PHANCONG (PC_MaNhanVien, PC_MaLichThi, PC_TrangThai)
    VALUES (@MaNhanVien, @MaLichThi, N'Chưa diễn ra');
END;
GO

-- Lấy thông tin lịch thi
CREATE OR ALTER PROCEDURE usp_GetLichThi
AS
BEGIN
    SELECT 
        lt.LT_MaLichThi AS N'Mã Lịch Thi',
        kt.KT_TenKyThi AS N'Tên Kỳ Thi',
        lt.LT_NgayThi AS N'Ngày Thi',
        lt.LT_MaPhongThi AS N'Phòng Thi',
        lt.LT_TGBatDau AS N'Giờ Bắt Đầu',
        lt.LT_TGKetThuc AS N'Giờ Kết Thúc',
        lt.LT_SLDangKy AS N'Số Lượng Đã Đăng Ký',
        CASE 
            -- Đang diễn ra
            WHEN GETDATE() BETWEEN CAST(lt.LT_NgayThi AS DATETIME) + CAST(lt.LT_TGBatDau AS DATETIME) 
                               AND CAST(lt.LT_NgayThi AS DATETIME) + CAST(lt.LT_TGKetThuc AS DATETIME) 
            THEN N'Đang thi'
            -- Đã kết thúc
            WHEN GETDATE() > CAST(lt.LT_NgayThi AS DATETIME) + CAST(lt.LT_TGKetThuc AS DATETIME) 
            THEN N'Đã thi'
            -- Chưa diễn ra
            ELSE N'Chưa thi'
        END AS N'Trạng Thái'
    FROM 
        LICHTHI lt
    JOIN 
        KYTHI kt ON lt.LT_MaKyThi = kt.KT_MaKyThi
    ORDER BY 
        lt.LT_NgayThi DESC, lt.LT_TGBatDau DESC;
END;
GO

-- Update kỳ thi
CREATE OR ALTER PROCEDURE usp_UpdateKyThi
    @MaKyThi VARCHAR(10),
    @TenKyThi NVARCHAR(100),
    @LePhi MONEY
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        UPDATE KYTHI
        SET
            KT_TenKyThi = @TenKyThi,
            KT_LePhi = @LePhi
        WHERE
            KT_MaKyThi = @MaKyThi;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO

-- Thêm kỳ thi
CREATE OR ALTER PROCEDURE usp_AddKyThi
    @MaKyThi VARCHAR(10),
    @TenKyThi NVARCHAR(100),
    @LePhi MONEY
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        INSERT INTO KYTHI (KT_MaKyThi, KT_TenKyThi, KT_LePhi)
        VALUES (@MaKyThi, @TenKyThi, @LePhi);
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO

-- Xóa kỳ thi
CREATE OR ALTER PROCEDURE usp_DeleteKyThi
    @MaKyThi VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        -- Chỉ xóa nếu không có lịch thi nào liên quan để đảm bảo toàn vẹn dữ liệu
        IF NOT EXISTS (SELECT 1 FROM LICHTHI WHERE LT_MaKyThi = @MaKyThi)
        BEGIN
            DELETE FROM KYTHI
            WHERE KT_MaKyThi = @MaKyThi;
        END
        ELSE
        BEGIN
            RAISERROR('Không thể xóa kỳ thi này vì đã có lịch thi liên quan.', 16, 1);
        END
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO

-- Lấy kì thi đầu tiên
CREATE OR ALTER PROCEDURE usp_GetLastKyThiId
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP 1 KT_MaKyThi
    FROM KYTHI
    ORDER BY CAST(SUBSTRING(KT_MaKyThi, 3, LEN(KT_MaKyThi)) AS INT) DESC;
END
GO

-- Lấy toàn bộ phòng thi
CREATE OR ALTER PROCEDURE usp_GetAllPhongThi
AS
BEGIN
     SET NOCOUNT ON;
    SELECT * FROM PHONGTHI;
END
GO

-- Lấy lịch thi theo phòng thi
CREATE OR ALTER PROCEDURE usp_GetLichThiByPhongThi
    @MaPhongThi VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        LT_MaLichThi AS 'Mã Lịch Thi',
        KT_TenKyThi AS 'Tên Kỳ Thi',
        LT_NgayThi AS 'Ngày Thi',
        LT_TGBatDau AS 'Giờ Bắt Đầu',
        LT_TGKetThuc AS 'Giờ Kết Thúc',
        LT_TrangThai AS 'Trạng Thái'
    FROM LICHTHI
    JOIN KYTHI ON LICHTHI.LT_MaKyThi = KYTHI.KT_MaKyThi
    WHERE LT_MaPhongThi = @MaPhongThi;
END
GO

-- Thêm phòng thi
CREATE OR ALTER PROCEDURE usp_AddPhongThi
    @PT_MaPhongThi VARCHAR(10),
    @PT_HinhThuc NVARCHAR(50),
    @PT_SLThiSinhToiDa INT,
    @PT_SLThiSinhToiThieu INT,
    @PT_SLNhanVienCoiThi INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        INSERT INTO PHONGTHI (PT_MaPhongThi, PT_HinhThuc, PT_SLThiSinhToiDa, PT_SLThiSinhToiThieu, PT_SLNhanVienCoiThi)
        VALUES (@PT_MaPhongThi, @PT_HinhThuc, @PT_SLThiSinhToiDa, @PT_SLThiSinhToiThieu, @PT_SLNhanVienCoiThi);
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO

-- Lấy phòng thi đầu tiên
CREATE OR ALTER PROCEDURE usp_GetLastPhongThiId
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP 1 PT_MaPhongThi
    FROM PHONGTHI
    ORDER BY CAST(SUBSTRING(PT_MaPhongThi, 2, LEN(PT_MaPhongThi)) AS INT) DESC;
END
GO

-- Chỉnh sửa phòng thi
CREATE OR ALTER PROCEDURE usp_UpdatePhongThi
    @PT_MaPhongThi VARCHAR(10),
    @PT_HinhThuc NVARCHAR(50),
    @PT_SLThiSinhToiDa INT,
    @PT_SLThiSinhToiThieu INT,
    @PT_SLNhanVienCoiThi INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        UPDATE PHONGTHI
        SET 
            PT_HinhThuc = @PT_HinhThuc,
            PT_SLThiSinhToiDa = @PT_SLThiSinhToiDa,
            PT_SLThiSinhToiThieu = @PT_SLThiSinhToiThieu,
            PT_SLNhanVienCoiThi = @PT_SLNhanVienCoiThi
        WHERE 
            PT_MaPhongThi = @PT_MaPhongThi;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO

-- Xóa phòng thi
CREATE OR ALTER PROCEDURE usp_DeletePhongThi
    @PT_MaPhongThi VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    -- Kiểm tra ràng buộc khóa ngoại trước khi xóa
    IF EXISTS (SELECT 1 FROM LICHTHI WHERE LT_MaPhongThi = @PT_MaPhongThi)
    BEGIN
        RAISERROR('Không thể xóa phòng thi này vì đã có lịch thi liên quan.', 16, 1);
        RETURN;
    END

    BEGIN TRY
        DELETE FROM PHONGTHI
        WHERE PT_MaPhongThi = @PT_MaPhongThi;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO

-- Lấy mã lịch thi cuối cùng
CREATE OR ALTER PROCEDURE usp_GetLastLichThiId
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP 1 LT_MaLichThi
    FROM LICHTHI
    ORDER BY CAST(SUBSTRING(LT_MaLichThi, 3, LEN(LT_MaLichThi)) AS INT) DESC;
END
GO

-- Thêm một lịch thi mới
CREATE OR ALTER PROCEDURE usp_AddLichThi
    @MaLichThi VARCHAR(10),
    @MaKyThi VARCHAR(10),
    @SLDangKy INT,
    @TrangThai NVARCHAR(20),
    @TenKyThi NVARCHAR(50),
    @NgayThi DATE,
    @MaPhongThi VARCHAR(10),
    @TGBatDau TIME,
    @TGKetThuc TIME
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO LICHTHI (LT_MaLichThi, LT_MaKyThi, LT_SLDangKy, LT_TrangThai, LT_TenKyThi, LT_NgayThi, LT_MaPhongThi, LT_TGBatDau, LT_TGKetThuc)
    VALUES (@MaLichThi, @MaKyThi, @SLDangKy, @TrangThai, @TenKyThi, @NgayThi, @MaPhongThi, @TGBatDau, @TGKetThuc);
END
GO

-- Cập nhật thông tin Lịch thi
CREATE OR ALTER PROCEDURE usp_UpdateLichThi
    @MaLichThi VARCHAR(10),
    @NgayThi DATE,
    @SLDangKy INT,
    @TGBatDau TIME,
    @TGKetThuc TIME
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        UPDATE LICHTHI
        SET 
            LT_NgayThi = @NgayThi,
            LT_SLDangKy = @SLDangKy,
            LT_TGBatDau = @TGBatDau,
            LT_TGKetThuc = @TGKetThuc
        WHERE 
            LT_MaLichThi = @MaLichThi;
        SELECT 1 AS Result;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Result;
    END CATCH
END
GO

-- Xóa Lịch Thi
CREATE OR ALTER PROCEDURE usp_DeleteLichThi
    @MaLichThi VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Kiểm tra xem có bản ghi nào trong PHIEUDANGKYDUTHI tham chiếu đến lịch thi này không
    IF EXISTS (SELECT 1 FROM PHIEUDANGKYDUTHI WHERE PDKDT_MaLichThi = @MaLichThi)
    BEGIN
        RAISERROR('Không thể xóa lịch thi này vì đã có thí sinh đăng ký.', 16, 1);
        SELECT 0 AS Result;
        RETURN;
    END

    -- Kiểm tra xem có bản ghi nào trong PHANCONG tham chiếu đến lịch thi này không
    IF EXISTS (SELECT 1 FROM PHANCONG WHERE PC_MaLichThi = @MaLichThi)
    BEGIN
        RAISERROR('Không thể xóa lịch thi này vì đã được phân công cho nhân viên.', 16, 1);
        SELECT 0 AS Result;
        RETURN;
    END

    BEGIN TRY
        DELETE FROM LICHTHI WHERE LT_MaLichThi = @MaLichThi;
        SELECT 1 AS Result;
    END TRY
    BEGIN CATCH
        SELECT 0 AS Result;
    END CATCH
END
GO

-- Lấy danh sách phòng thi trống theo ngày
CREATE OR ALTER PROCEDURE usp_GetAvailablePhongThiByDate
    @NgayThi DATE
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM PHONGTHI
    WHERE PT_MaPhongThi NOT IN (
        SELECT LT_MaPhongThi 
        FROM LICHTHI 
        WHERE LT_NgayThi = @NgayThi
    );
END
GO
-- Lấy phòng ban theo tên phòng ban
CREATE OR ALTER PROCEDURE usp_GetPhongBanByTenPhongBan 
	@TenPhongBan NVARCHAR(100)
AS
BEGIN
	SELECT * FROM PHONGBAN pb WHERE pb.PB_TenPhongBan = @TenPhongBan;
END;
GO

-- Cập nhật tất cả các phân công sau khi qua ngày
CREATE OR ALTER PROCEDURE usp_UpdateAllExamStatus
AS
BEGIN
    SET NOCOUNT ON;

    -- Lấy thời gian hiện tại
    DECLARE @Now DATETIME = GETDATE();

    -- Cập nhật trạng thái trong bảng PHANCONG
    -- Đồng bộ trạng thái từ LICHTHI
    UPDATE PC
    SET PC_TrangThai = N'Hoàn thành'
    FROM PHANCONG AS PC
    JOIN LICHTHI AS LT ON PC.PC_MaLichThi = LT.LT_MaLichThi
    WHERE (CAST(LT.LT_NgayThi AS DATETIME) + CAST(LT.LT_TGKetThuc AS DATETIME)) < @Now;
END
GO
-- HẾT PHẦN QUẢN TRỊ HỆ THỐNG
------------------------------------------------------




---------------------------------------------------------------------------------------------------------------------------------------------------------





--TRIGGER

--Trigger kiểm tra mã người nhận trong THONGBAO có thuộc bảng NHANVIEN hoặc PHONGBAN không 
create or alter trigger utg_CheckDoiTuong
on THONGBAO
after INSERT, UPDATE
as
begin
	set nocount on;
	if exists( select 1 from inserted i 
			   where not exists(select 1 from NHANVIEN where i.TB_MaDoiTuongNhan = NV_MaNhanVien)
			      and not exists(select 1 from PHONGBAN where i.TB_MaDoiTuongNhan = PB_MaPhongBan))
	begin
		RAISERROR(N'Mã người nhận không tồn tại trong SINHVIEN hoặc PHONGBAN', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
	end
end
go

--Trigger tự động cập nhật trang thái lịch thi sau khi qua thời gian thi
create or alter trigger utg_UpdateTrangThai
on LICHTHI
after insert, update
as
begin	
	set nocount on;

	update lt
    set LT_TrangThai = N'Đã thi'
    from LICHTHI lt
    inner join inserted i
        on lt.LT_MaLichThi = i.LT_MaLichThi
    where
        lt.LT_TrangThai = N'Chưa thi' -- chỉ cập nhật khi là "Chưa thi"
        and (
            -- ngày thi đã qua
            lt.LT_NgayThi < convert(date, getdate())
            or
            -- hoặc là ngày thi hôm nay nhưng giờ kết thúc đã trễ hơn bây giờ
            (
                lt.LT_NgayThi = CONVERT(date, getdate())
                AND
                -- nối ngày + giờ kết thúc thành datetime để so sánh
                cast(convert(varchar(10), lt.LT_NgayThi, 120) + ' ' + convert(varchar(8), lt.LT_TGKetThuc, 108) as datetime) < getdate()
            )
        );
end;
go


--drop trigger utg_CheckDoiTuong;


--Trigger tự động tạo thông tin BAITHI khi tạo phiếu dự thi
create or alter trigger utg_CreateBaiThi
on PHIEUDUTHI
after INSERT, UPDATE
as
begin
	set nocount on;

	insert into BAITHI (BT_MaBaiThi, BT_MaLichThi, BT_SoBaoDanh, BT_ThoiGianLamBai)
    select
        left(replace(newid(), '-', ''), 10) AS MaBaiThi,
        i.PDT_MaLichThi,
        i.PDT_SoBaoDanh,
		'00:00:00'
    from inserted as i
	where not exists( select 1 from BAITHI as bt where i.PDT_MaLichThi = bt.BT_MaLichThi 
											     and i.PDT_SoBaoDanh = bt.BT_SoBaoDanh);
/*
	delete b
    from
        BAITHI b
        inner join deleted d
            on b.BT_MaLichThi = d.PDT_MaLichThi
           and b.BT_SoBaoDanh = d.PDT_SoBaoDanh
        inner join inserted i
            ON i.PDT_MaPhieu = d.PDT_MaPhieu
*/

	update BAITHI
	set BT_MaLichThi = i.PDT_MaLichThi
	FROM 
    BAITHI AS b
    inner join deleted as d
        on b.BT_SoBaoDanh = d.PDT_SoBaoDanh
       and b.BT_MaLichThi = d.PDT_MaLichThi
    inner join inserted as i
        on i.PDT_SoBaoDanh = d.PDT_SoBaoDanh
       and i.PDT_MaPhieu   = d.PDT_MaPhieu
	where i.PDT_MaLichThi <> d.PDT_MaLichThi
end;
go

--Trigger tự động xóa bài thi khi xóa phiếu đăng ký
create or alter trigger utg_DeleteBaiThi
on PHIEUDUTHI
after DELETE
as
begin
	set nocount on;

	delete b
    from
        BAITHI b
        inner join deleted d
            on b.BT_MaLichThi = d.PDT_MaLichThi
           and b.BT_SoBaoDanh = d.PDT_SoBaoDanh
end;
go

--Trigger tự động tạo chứng chỉ khi cập nhật điểm thi 
create or alter trigger utg_CreateChungChi
on BAITHI
after UPDATE
as
begin
	set nocount on;

	insert into CHUNGCHI(CC_MaBaiThi, CC_MaKyThi, CC_SoBaoDanh, CC_NgayCap, CC_ThoiHan, CC_TrangThai)
	select i.BT_MaBaiThi, lt.LT_MaKyThi, i.BT_SoBaoDanh, cast(getdate() as date) as CC_NgayCap, dateadd(year, 2, cast(getdate() as date)) as CC_ThoiHan, N'Chưa nhận' as CC_TrangThai
	from inserted as i inner join LICHTHI as lt on i.BT_MaLichThi = lt.LT_MaLichThi 
					   left join deleted as d on d.BT_MaBaiThi = i.BT_MaBaiThi
	where i.BT_DiemSo is not null and (d.BT_DiemSo is null or d.BT_DiemSo <> i.BT_DiemSo)  
		  and not exists ( select 1 FROM CHUNGCHI c where c.CC_MaBaiThi = i.BT_MaBaiThi and c.CC_MaKyThi = lt.LT_MaKyThi);

	delete c
	from CHUNGCHI as c join deleted as d on c.CC_MaBaiThi = d.BT_MaBaiThi
					   left join inserted as i on i.BT_MaBaiThi = d.BT_MaBaiThi
	where d.BT_DiemSo is not null and i.BT_DiemSo is null;
	
end;