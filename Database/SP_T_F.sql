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