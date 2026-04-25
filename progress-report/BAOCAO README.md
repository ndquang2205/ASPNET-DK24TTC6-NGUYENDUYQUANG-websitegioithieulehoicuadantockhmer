# [cite_start]XÂY DỰNG WEBSITE GIỚI THIỆU CÁC LỄ HỘI CỦA NGƯỜI DÂN TỘC KHMER [cite: 4]

## Thông tin sinh viên

- [cite_start]**Họ và tên:** Nguyễn Duy Quang [cite: 6]
- [cite_start]**MSSV:** 170124700 [cite: 7]
- [cite_start]**Lớp:** DK24TCC6 [cite: 8]
- **Giảng viên hướng dẫn:** TS. [cite_start]Đoàn Phước Miền [cite: 13]

---

## 1. Giới thiệu đề tài

[cite_start]Đây là đồ án học phần Chuyên đề ASP.NET nhằm xây dựng ứng dụng website giới thiệu các lễ hội của người dân tộc Khmer[cite: 3, 4, 150]. [cite_start]Hệ thống được phát triển dựa trên ngôn ngữ lập trình C# và công nghệ ASP.NET MVC[cite: 164, 165].

Đề tài hướng đến việc đạt được các mục tiêu:
- [cite_start]Nâng cao hiểu biết về ngôn ngữ lập trình C# và công nghệ ASP.NET MVC[cite: 152].
- [cite_start]Củng cố kiến thức về phân tích thiết kế hướng đối tượng[cite: 153].

---

## 2. Mục tiêu của đề tài

- [cite_start]Rèn luyện khả năng tự học và làm việc nhóm[cite: 154].
- [cite_start]Quản lý bài viết về quảng bá về các lễ hội của người dân tộc Khmer[cite: 156].
- [cite_start]Quản lý thể loại bài viết[cite: 157].
- [cite_start]Đọc bài viết[cite: 158].

---

## 3. Công nghệ sử dụng

- [cite_start]**Ngôn ngữ lập trình:** C#[cite: 164].
- [cite_start]**Công nghệ:** ASP.NET MVC[cite: 165].
- [cite_start]**Ngôn ngữ thiết kế:** HTML, CSS và thư viện Boostrap[cite: 166, 167].
- [cite_start]**Ngôn ngữ kịch bản:** JavaScript và thư viện JQuery[cite: 168].
- [cite_start]**Công cụ hỗ trợ:** Trình soạn thảo CKEditor và trình quản lý file CKFinder[cite: 169].
- [cite_start]**IDE:** Trình soạn thảo Visual Studio[cite: 170].
- [cite_start]**Cơ sở dữ liệu:** Hệ quản trị cơ sở dữ liệu SQL Server[cite: 171].
- [cite_start]**ORM:** Khuôn khổ ánh xạ quan hệ-đối tượng mã nguồn mở cho ADO.NET Entity Framework[cite: 172].

---

## 4. Chức năng chính của website

### 4.1 Độc giả
- [cite_start]Đăng ký tài khoản[cite: 199].
- [cite_start]Đọc bài về giới thiệu về các lễ hội của dân tộc Khmer và quảng bá du lịch[cite: 199].
- [cite_start]Bình luận bài viết[cite: 297].
- [cite_start]Tìm kiếm bài viết[cite: 189].

### 4.2 Thành viên
- [cite_start]Đăng nhập và đăng xuất[cite: 202].
- [cite_start]Sử dụng các chức năng của độc giả[cite: 199].
- [cite_start]Viết bài giới thiệu về các lễ hội của dân tộc Khmer và quảng bá du lịch[cite: 199].
- [cite_start]Sửa bài viết của mình sau khi đăng tải[cite: 234].
- [cite_start]Xóa bài viết mình đã đăng[cite: 243].
- [cite_start]Xem danh sách bài viết của mình[cite: 252].

### 4.3 Quản trị viên
- [cite_start]Có thể sử dụng tất cả các chức năng của hệ thống[cite: 199].
- [cite_start]Thêm, sửa, xóa thể loại bài viết[cite: 183, 185, 187].
- [cite_start]Xem danh sách tài khoản người dùng trong hệ thống[cite: 279].
- [cite_start]Xóa thông tin người dùng (trừ tài khoản admin)[cite: 288].

---

## 5. Cấu trúc dữ liệu chính

[cite_start]Hệ thống sử dụng các bảng chính sau[cite: 305]:
- [cite_start]**BaiViet:** Lưu trữ thông tin bài viết (MaBaiViet, TenBaiViet, NoiDung, AnhBia, NgayDang, NgayCapNhat, LuotThich, An, MaTheLoai, MaTaiKhoan)[cite: 305].
- [cite_start]**DanhMuc:** Quản lý các danh mục lớn (MaDanhMuc, TenDanhMuc, SoLuongTheLoai)[cite: 305].
- [cite_start]**TheLoai:** Quản lý thể loại chi tiết của bài viết (MaTheLoai, TenTheLoai, SoLuongBaiViet, MaDanhMuc)[cite: 305].
- [cite_start]**TaiKhoan:** Lưu trữ thông tin người dùng và thành viên (MaTaiKhoan, MatKhau, HoTen, NgaySinh, GioiTinh, QueQuan, SDT, MaQuyen)[cite: 305].
- [cite_start]**Quyen:** Quản lý phân quyền tài khoản trên hệ thống (MaQuyen, TenQuyen, MoTa)[cite: 305].

---

## 6. Hướng phát triển trong tương lai

- [cite_start]Hỗ trợ đa ngôn ngữ[cite: 328].
- [cite_start]Tích hợp vị trí google map để khách hàng dễ dàng tìm đến các địa điểm tổ chức các lễ hội của dân tộc Khmer và quảng bá du lịch[cite: 328].
- [cite_start]Cải thiện hiệu năng khi lượng người dùng và dữ liệu ngày một nhiều lên[cite: 329].
- [cite_start]Tối ưu lại toàn bộ câu truy vấn, thiết kế lại toàn bộ cơ sở dữ liệu[cite: 330].
- [cite_start]Cập nhật giao diện thêm phần hiệu ứng thu hút hơn[cite: 330].