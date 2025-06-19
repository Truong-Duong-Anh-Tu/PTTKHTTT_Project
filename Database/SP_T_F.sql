--Procedure - Trigger - Function
use DB_TRUNGTAMTHI;
go

--Kiem tra tai khoan
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

--Lay chuc vu cua tai khoan dang nhap
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