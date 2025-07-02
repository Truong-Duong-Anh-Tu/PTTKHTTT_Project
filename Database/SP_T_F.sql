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

--Xem lịch phân công
create or alter procedure usp_XemLichPhanCong
as
begin
	set nocount on;
	select pc.PC_MaLichThi, kt.KT_TenKyThi, pc.PC_MaNhanVien, lt.LT_MaPhongThi, lt.LT_NgayThi, lt.LT_TGBatDau, pc.PC_TrangThai
	from PHANCONG as pc join LICHTHI as lt on pc.PC_MaLichThi = lt.LT_MaLichThi
						join KYTHI as kt on kt.KT_MaKyThi = lt.LT_MaKyThi
end
go
 

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


CREATE OR ALTER PROCEDURE usp_GetPhanCong
AS
BEGIN
	SELECT kt.KT_TenKyThi, lt.LT_NgayThi, lt.LT_MaPhongThi, lt.LT_TGBatDau, 
	lt.LT_TGKetThuc, nv.NV_MaNhanVien , nv.NV_TenNhanVien, pc.PC_TrangThai
	FROM PHANCONG pc JOIN NHANVIEN nv ON nv.NV_MaNhanVien = pc.PC_MaNhanVien
	JOIN LICHTHI lt ON lt.LT_MaLichThi = pc.PC_MaLichThi
	JOIN KYTHI kt ON kt.KT_MaKyThi = lt.LT_MaKyThi
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

--Tra cứu phiếu đăng ký (thông tin cơ bản)
CREATE PROCEDURE TraCuuPhieuDangKyCoBan 
    @MaPhieu VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        -- Tên khách hàng: tùy loại
        CASE 
            WHEN KH.KH_LoaiKhachHang = N'Tự do' THEN KHTD.KHTD_HoTen
            WHEN KH.KH_LoaiKhachHang = N'Đơn vị' THEN KHDV.KHDV_TenDonVi
        END AS TenKhachHang,

        KH.KH_Email,
        KH.KH_SDT,
        KH.KH_LoaiKhachHang,
        PDK.PDKDT_ThoiGianLap,
        KT.KT_TenKyThi,
        LT.LT_NgayThi,
        PDK.PDKDT_DiaChiChuyenPhat,
        PDK.PDKDT_TrangThaiThanhToan,
        NV.NV_TenNhanVien AS NhanVienTaoPhieu

    FROM PHIEUDANGKYDUTHI PDK
    INNER JOIN KHACHHANG KH ON PDK.PDKDT_MaKhachHang = KH.KH_MaKhachHang
    LEFT JOIN KHACHHANGHTUDO KHTD ON KH.KH_MaKhachHang = KHTD.KHTD_MaKhachHang
    LEFT JOIN KHACHHANGDONVI KHDV ON KH.KH_MaKhachHang = KHDV.KHDV_MaKhachHang
    INNER JOIN LICHTHI LT ON PDK.PDKDT_MaLichThi = LT.LT_MaLichThi
    INNER JOIN KYTHI KT ON LT.LT_MaKyThi = KT.KT_MaKyThi
    INNER JOIN NHANVIEN NV ON PDK.PDKDT_MaNhanVienLap = NV.NV_MaNhanVien

    WHERE PDK.PDKDT_MaPhieu = @MaPhieu
END
GO