
using System.ComponentModel.Design;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index(string HoTen, float LuongCoBan, float HeSoLuong, float PhuCap)
        {
            int Luong = ( LuongCoBan*HeSoLuong + PhuCap );
            string ThongBao = "Họ và Tên: "+ HoTen + "Lương: " + Luong;

            ViewBag.ThongBao = ThongBao;
            return View();
        }
    }
}