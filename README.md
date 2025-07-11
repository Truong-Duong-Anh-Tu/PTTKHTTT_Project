### GIỚI THIỆU

Đây là project thiết kế hệ thống quản lý của một trung tâm tổ chức thi. Hỗ trợ việc đăng ký dự thi, lên kế hoạch tổ chức thi, quản lí kết quả thi và chứng chỉ.
Project này là đồ án môn học của môn Phân tích thiết kế hệ thống thông tin, nhóm 3 lớp 22_1.

### CHỨC NĂNG

Các role user chính: 
- Nhân viên tiếp nhận
- Nhân viên kế toán
- Nhân viên nhập liệu
- Nhân viên coi thi
- Quản trị hệ thống( admin)

Các chức năng chính
- Hiển thị thông tin nhân viên đăng nhập
- Tạo, quản lý phiếu đăng ký dự thi( tiếp nhận)
- Quản lý thí sinh( tiếp nhận)
- Tạo, quản lý phiếu thanh toán( kế toán) 
- Tạo, quản lý phiếu gia hạn( kế toán)
- Quản lý kết quả thi( nhập liệu)
- Quản lý chứng chỉ( tiếp nhận)
- Xem lịch phân công( coi thi)
- Gửi thông báo nội bộ
- Quản lý nhân viên( admin)
- Quản lý lịch phân công( admin)
- Quản lý kỳ thi( admin)
- Quản lý lịch thi( admin)
- Quản lý phòng thi( admin)
- Phát hành phiếu dự thi( admin)

### KIẾN TRÚC - CÔNG NGHỆ
- Sử dụng mô hình 3 lớp
- Ngôn ngữ C#
- Framework: .NET 9.0
- Hệ quản trị CSDL: SQL Server
 
### HƯỚNG DẪN CÀI ĐẶT
## Cài đặt CSDL
**Tạo sa user trong SQL SERVER**
- Connect vào SQL (dưới trang thái Window Authentication)
- Nhấp chuột phải vào dòng đầu tiên (SQL Server) => chọn Properities => Chọn Security, chọn SQL Server and Windows Authentication). Nhấn OK
- Nhấp chuột vào Security ở thanh Object Explorer và vào Logins => nhấp chuột phải vào *sa* và chọn Properities. Tại đây, nhập lại password là 123, và chọn Status là enabled. Nhấn OK.
- Sau khi thực hiện xong, vào thành Search của chỗ Start, tìm Services và chạy phần Services
- Tìm SQL SERVER (SQLEXPRESS), nhấn chuột phải và chọn restart.
- Chạy lại chương trình SQL SEVER, với authentication là SQL Server Authentication, login: sa, password: 123, chọn **Trust server certificate** để kết nối SQL thành công.

**Kết nối SQL SERVER và backend**
- Vào thanh Search ở Start, tìm SQL Server Configuration Management, chọn SQL Server Network Configuration, vào Protocol for SQLEXPRESS, chọn TCP/IP, phần Enabled chọn YES.
- IP Adress, kéo xuống tìm IPAll, đổi TCP Dynamic Ports = 1433. Nhấn OK
- Vào lại SQL Server Services, chọn restart SQL Server(SQLEXPRESS).

**Tạo Database**
Vào folder Database, lần lượt chạy các file sao theo thứ tự
- CSDL_PTTKHTTT.sql
- SP_F_T.sql
- InsertData.sql

## Build chương trình

- Clone repository của dự án từ GitHub (đã được đề cập ở trên).
- Mở file solution (.sln) bằng Visual Studio.
- Build dự án để Visual Studio tự động tải về các gói NuGet cần thiết.
- Nhấn F5 hoặc nút Start để chạy ứng dụng.

Nếu có Visual Studio, có thể mở file .sln và chạy với chế độ Start Without Debugging.

## CHẠY CHƯƠNG TRÌNH:
- Đăng nhập vào tài khoản trên hệ thống:
  + Admin: phanguyet@ttthi.vn
  + Nhân viên nhập liệu: ltnhat@ttthi.vn
  + Nhân viên tiếp nhận: ndthang@ttthi.vn
  + Nhân viên kế toán: hxphu@ttthi.vn
  + Nhân viên coi thi: ltcam@ttthi.vn


