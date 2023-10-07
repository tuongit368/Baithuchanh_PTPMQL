
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
            
            return View();
        }
    }
}