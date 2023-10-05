using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        // Khai bao cac phuong thuc 
        public IActionResult Index()
        {
            return View();
        }

        //nhan du lieu tu view gui len ( Bat buoc )
        [HttpPost]
        public IActionResult Index(string fname, string Email)
        {

            string thongbao = "FullName: " + fname + " || " + " Email:" + Email;
            ViewBag.ThongBao = thongbao; 
            return View();
        }
    }
}