using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IOOPMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string inputEmail, string inputPassword)
        {
            if (inputEmail == "omar.khorari@hotmail.com" && inputPassword == "123456")
            {
                return View("../Dashboard/Index");
            }
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
