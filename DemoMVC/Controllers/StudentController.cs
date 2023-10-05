// Ho Va Ten : Dang Ngoc Tuong  || Ma Sinh Vien : 2121050140


using Microsoft.AspNetCore.Mvc;
using NewApp.Models;

namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
            
        }
        
        [HttpPost]

        public IActionResult Index(Student std)
        {
            string text = "StudentID: " + std.StudentID + " || " + "FullName: " + std.FullName
                          + " || " + "Address: " + std.Address + " || " + "Age: " + std.Age +" Tuoi";
            ViewBag.ThongBao = text;
            
            return View();

        }

    }
}