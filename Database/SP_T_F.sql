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