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
- Vào thư mục **Relase** chạy 1 trong 2 file (.msi hoặc setup.exe)  
- Nhấn Next khi cửa sổ này xuất hiện  
<img width="618" height="506" alt="image" src="https://github.com/user-attachments/assets/676663c6-379e-4d8d-8d66-204456d0182c" />  
- Chọn đường dẫn để lưu chương trình ở mục Folder. (có thể nhấn Browse … để tìm đường dẫn thích hợp). Chọn Everyone nếu muốn cài đặt chương trình trên tất cả các User, hoặc Just me nếu chỉ cài đặt tên User hiện tại đang đăng nhập trên máy tính. Sau đó nhấn Next   
<img width="616" height="506" alt="image" src="https://github.com/user-attachments/assets/2ebac3a6-465d-4b70-86c1-6272f58e7c64" />  
- Nhấn Next khi thông báo này xuất hiện   
<img width="616" height="505" alt="image" src="https://github.com/user-attachments/assets/3900a995-4ad3-4535-ae44-8a8651eaf212" />  
- Nếu có thông báo cảnh báo cài đặt ứng dụng không tin cậy( hay các thông báo tương tự từ hệ điều hành), nhấn Yes/OK.  
- Khi có cửa sổ này hiện lên thì quá trình cài đặt đã hoàn tất. Nhấn Close để thoát.  
<img width="614" height="509" alt="image" src="https://github.com/user-attachments/assets/ef7a10b5-68ca-420a-8d5d-1faffb80db44" />  
Trong thư mục đã chọn ở trên, chạy file .exe để khởi động chương trình  

Nếu có Visual Studio, có thể mở file .sln và chạy với chế độ Start Without Debugging.



