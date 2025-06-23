--Procedure - Trigger - Function

--STORE PROCEDURE
use DB_TRUNGTAMTHI;
go

--Kiểm tra tài khoản
create or alter procedure usp_GetPasswordOfUsername
	@username varchar(10),
	@password varchar(100) OUTPUT
as
begin
	set NOCOUNT ON;
	
	select @password = TK_MatKhau
	from TAIKHOAN
	where TK_TenDangNhap = @username;
end;
go

--Lấy chức vụ của tài khoản đang đăng nhập
create or alter procedure usp_GetRoleOfUser
	@username varchar(10),
	@role nvarchar(20) OUTPUT
as
begin
	set NOCOUNT ON;

	select @role = nv.NV_ChucVu
	from TAIKHOAN as tk join NHANVIEN as nv on tk.TK_TenDangNhap = nv.NV_MaNhanVien
	where nv.NV_MaNhanVien = @username
end;
go

--Lay thong tin cua tai khoan dang nhap
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

--drop trigger utg_CheckDoiTuong;