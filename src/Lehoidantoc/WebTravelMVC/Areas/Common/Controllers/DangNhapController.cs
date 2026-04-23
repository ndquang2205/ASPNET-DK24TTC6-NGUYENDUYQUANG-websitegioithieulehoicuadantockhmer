using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenDuyQuang.Models;

namespace NguyenDuyQuang.Areas.Common.Controllers
{
    public class DangNhapController : Controller
    {
        EFTravel db = new EFTravel();

        // GET: Hiển thị trang đăng nhập
        public ActionResult DangNhap()
        {
            return View();
        }

        // POST: Xử lý đăng nhập
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DangNhap(FormCollection f)
        {
            // Kiểm tra tên đăng nhập và mật khẩu
            string ssTaiKhoan = f["txtTaiKhoan"].ToString();
            string ssMatKhau = f["txtMatKhau"].ToString();
            
            if (ssTaiKhoan == "" && ssMatKhau == "")
            {
                ModelState.AddModelError("", "Vui lòng nhập tên đăng nhập và mật khẩu của bạn !");
            }
            else if (ssTaiKhoan == "")
            {
                ModelState.AddModelError("", "Bạn không được bỏ trống tên đăng nhập !");
            }
            else if (ssMatKhau == "")
            {
                ModelState.AddModelError("", "Bạn không được bỏ trống mật khẩu !");
            }
            else
            {
                var tk = db.TaiKhoans.SingleOrDefault(n => n.MaTaiKhoan == ssTaiKhoan && n.MatKhau == ssMatKhau);

                if (tk == null)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại trong hệ thống hoặc sai mật khẩu!");
                    return View();
                }
                else
                {
                    // Đăng nhập với quyền là ban quản trị
                    if(tk.MaQuyen == 1)
                    {
                        Session["TaiKhoanNV"] = tk;
                        Session["TaiKhoanKH"] = null;
                        return Redirect("/Common/Home/Index");
                    }
                    
                    // Đăng nhập với quyền là khách hàng
                    if (tk.MaQuyen == 2)
                    {
                        Session["TaiKhoanNV"] = null;
                        Session["TaiKhoanKH"] = tk;
                        return Redirect("/Common/Home/Index"); // Đã mở khóa cho khách hàng
                    }
                }
            }
            return View();
        }

        // GET: Hiển thị trang đăng ký
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }

        // POST: Xử lý đăng ký tài khoản khách hàng
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DangKy(TaiKhoan tk)
        {
            if (ModelState.IsValid)
            {
                // Kiểm tra xem tên tài khoản đã tồn tại chưa
                var check = db.TaiKhoans.SingleOrDefault(s => s.MaTaiKhoan == tk.MaTaiKhoan);
                if (check == null)
                {
                    // Gán mặc định quyền là Khách hàng (MaQuyen = 2)
                    tk.MaQuyen = 2;
                    
                    db.TaiKhoans.Add(tk);
                    db.SaveChanges();
                    
                    // Đăng ký xong chuyển hướng về trang đăng nhập
                    return RedirectToAction("DangNhap");
                }
                else
                {
                    ViewBag.error = "Tên đăng nhập này đã tồn tại, vui lòng chọn tên khác!";
                    return View(tk);
                }
            }
            return View(tk);
        }

        // Đăng xuất cho Admin
        public ActionResult DangXuatAdmin()
        {
            Session["TaiKhoanNV"] = null;
            return RedirectToAction("Index", "Home");
        }

        // Đăng xuất cho Khách hàng
        public ActionResult DangXuatKH()
        {
            Session["TaiKhoanKH"] = null;
            return RedirectToAction("DangNhap", "DangNhap");
        }
    }
}