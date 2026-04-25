# XÂY DỰNG WEBSITE GIỚI THIỆU CÁC LỄ HỘI CỦA NGƯỜI DÂN TỘC KHMER 

## Thông tin sinh viên

- **Họ và tên:** Nguyễn Duy Quang 
- **MSSV:** 170124700 
- **Lớp:** DK24TCC6 
- **Giảng viên hướng dẫn:** TS. Đoàn Phước Miền 

---

## 1. Giới thiệu đề tài

Đây là đồ án học phần Chuyên đề ASP.NET nhằm xây dựng ứng dụng website giới thiệu các lễ hội của người dân tộc Khmer.Hệ thống được phát triển dựa trên ngôn ngữ lập trình C# và công nghệ ASP.NET MVC

Đề tài hướng đến việc đạt được các mục tiêu:
- Nâng cao hiểu biết về ngôn ngữ lập trình C# và công nghệ ASP.NET MVC
- Củng cố kiến thức về phân tích thiết kế hướng đối tượng.

---

## 2. Mục tiêu của đề tài

- [Rèn luyện khả năng tự học và làm việc nhóm.
- Quản lý bài viết về quảng bá về các lễ hội của người dân tộc Khmer
- Quản lý thể loại bài viết.
- Đọc bài viết.

---

## 3. Công nghệ sử dụng

- **Ngôn ngữ lập trình:** C#.
- **Công nghệ:** ASP.NET MVC.
- **Ngôn ngữ thiết kế:** HTML, CSS và thư viện Boostrap.
- **Ngôn ngữ kịch bản:** JavaScript và thư viện JQuery.
- **Công cụ hỗ trợ:** Trình soạn thảo CKEditor và trình quản lý file CKFinder.
- **IDE:** Trình soạn thảo Visual Studio.
- **Cơ sở dữ liệu:** Hệ quản trị cơ sở dữ liệu SQL Server.
- **ORM:** Khuôn khổ ánh xạ quan hệ-đối tượng mã nguồn mở cho ADO.NET Entity Framework.

---

## 4. Chức năng chính của website

### 4.1 Độc giả
- Đăng ký tài khoản[.
- Đọc bài về giới thiệu về các lễ hội của dân tộc Khmer và quảng bá du lịch.
- Bình luận bài viết.
- Tìm kiếm bài viết.

### 4.2 Thành viên
- Đăng nhập và đăng xuất.
- Sử dụng các chức năng của độc giả.
- Viết bài giới thiệu về các lễ hội của dân tộc Khmer và quảng bá du lịch.
- Sửa bài viết của mình sau khi đăng tải.
- Xóa bài viết mình đã đăng.
- Xem danh sách bài viết của mình.

### 4.3 Quản trị viên
- Có thể sử dụng tất cả các chức năng của hệ thống.
- Thêm, sửa, xóa thể loại bài viết.
- Xem danh sách tài khoản người dùng trong hệ thống.
- Xóa thông tin người dùng (trừ tài khoản admin)].

---

## 5. Cấu trúc dữ liệu chính

Hệ thống sử dụng các bảng chính sau:
- **BaiViet:** Lưu trữ thông tin bài viết (MaBaiViet, TenBaiViet, NoiDung, AnhBia, NgayDang, NgayCapNhat, LuotThich, An, MaTheLoai, MaTaiKhoan).
- **DanhMuc:** Quản lý các danh mục lớn (MaDanhMuc, TenDanhMuc, SoLuongTheLoai).
- **TheLoai:** Quản lý thể loại chi tiết của bài viết (MaTheLoai, TenTheLoai, SoLuongBaiViet, MaDanhMuc).
- **TaiKhoan:** Lưu trữ thông tin người dùng và thành viên (MaTaiKhoan, MatKhau, HoTen, NgaySinh, GioiTinh, QueQuan, SDT, MaQuyen).
- **Quyen:** Quản lý phân quyền tài khoản trên hệ thống (MaQuyen, TenQuyen, MoTa).

---

## 6. Hướng phát triển trong tương lai

- Hỗ trợ đa ngôn ngữ.
- Tích hợp vị trí google map để khách hàng dễ dàng tìm đến các địa điểm tổ chức các lễ hội của dân tộc Khmer và quảng bá du lịch.
- Cải thiện hiệu năng khi lượng người dùng và dữ liệu ngày một nhiều lên.
- Tối ưu lại toàn bộ câu truy vấn, thiết kế lại toàn bộ cơ sở dữ liệu.
- Cập nhật giao diện thêm phần hiệu ứng thu hút hơn.
