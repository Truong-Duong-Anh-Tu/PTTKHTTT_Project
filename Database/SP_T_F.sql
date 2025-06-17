--Procedure - Trigger - Function
use DB_TRUNGTAMTHI;
go

--Kiem tra tai khoan
create or alter procedure usp_CheckTaiKhoan
	@username varchar(10),
	@password varchar(100)
as
begin
	set NOCOUNT ON;
	if exists (select 1 from TAIKHOAN where TK_TenDangNhap = @username and TK_MatKhau = @password)
		select cast(1 as bit) as IsValid;
	else
		select cast(0 as bit) as IsValid;
end;
go

declare @qw varchar(10) = 'NV001';
declare @op varchar(100) = '1234';

EXEC usp_CheckTaiKhoan @qw, @op;