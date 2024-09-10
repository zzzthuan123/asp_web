using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BaiTap02()
        {
            var sanpham = new SanPhamViewModel()
            {
                TenSanPham = "Giày Thể Thao",
                GiaBan = 60,
                AnhMoTa = "/images/the-thao-nam-chat-10.jpg"
            };

            return View(sanpham);
        }
    }
}
