using System.Net.Mime;
using System.Security.AccessControl;
using System.Net;
// using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Data;
using DemoMVC.Models;

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

        [HttpPost]

        public IActionResult Index(Person ps)
        {
            string strOutput = "PersonId: " + ps.PersonId + " - " + "FullName: " + ps.FullName + " - " + "Address: " + ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();
            
        }
    }
}

