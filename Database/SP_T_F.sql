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

	select ts.TS_SoBaoDanh, ts.TS_HoTen, ts.TS_CCCD, ts.TS_NgaySinh, ts.TS_GioiTinh, bt.BT_DiemSo, bt.BT_MaLichThi
	from BAITHI as bt join THISINH as ts on bt.BT_SoBaoDanh = ts.TS_SoBaoDanh
					  join LICHTHI as lt on bt.BT_MaLichThi = lt.LT_MaLichThi
	where lt.LT_MaKyThi = @examtest
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

--TRIGGER
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
                NV_MaPhongBan
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
                @MaPhongBan
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

CREATE OR ALTER PROCEDURE usp_GetAllPhongBan
AS
BEGIN
    SELECT PB_MaPhongBan, PB_TenPhongBan
    FROM PHONGBAN
    ORDER BY PB_TenPhongBan
END;
GO

CREATE OR ALTER PROCEDURE usp_GetLastEmployeeId
AS
BEGIN
    SELECT TOP 1 NV_MaNhanVien
    FROM NHANVIEN
    WHERE NV_MaNhanVien LIKE 'NV%'
    ORDER BY NV_MaNhanVien DESC
END;
GO

CREATE OR ALTER PROCEDURE usp_DeleteNhanVien
    @MaNhanVien VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Xóa các bản ghi tham chiếu đến nhân viên này
        DELETE FROM PHANCONG WHERE PC_MaNhanVien = @MaNhanVien;
        DELETE FROM THONGBAO WHERE TB_MaNhanVienGui = @MaNhanVien;
        DELETE FROM PHEUTHANHTOAN WHERE PTT_NhanVienLap = @MaNhanVien;
        DELETE FROM PHIEUDANGKYDUTHI WHERE PDKDT_MaNhanVienLap = @MaNhanVien;

        -- Cuối cùng, xóa nhân viên
        DELETE FROM NHANVIEN WHERE NV_MaNhanVien = @MaNhanVien;

        COMMIT TRANSACTION;
        SELECT 1 AS Result; -- Trả về 1 nếu thành công
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        SELECT 0 AS Result; -- Trả về 0 nếu có lỗi
    END CATCH;
END;
GO