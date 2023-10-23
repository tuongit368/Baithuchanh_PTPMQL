using System.Net;
// Ho Va Ten : Dang Ngoc Tuong  || Ma Sinh Vien : 2121050140
using DemoMVC.Models;


using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(Person ps)
        {
            string strOutput = "Xin Chao" + ps.PersonId + " - " + ps.FullName + " - " + ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();
            
        }
    }
}