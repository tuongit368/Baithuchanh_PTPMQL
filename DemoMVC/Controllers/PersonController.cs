// Ho Va Ten : Dang Ngoc Tuong  || Ma Sinh Vien : 2121050140


using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}