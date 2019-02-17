using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gentelella.Controllers
{
    public class AdditionalController : Controller
    {
        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult Ecommerce()
        {
            return View();
        }
        public IActionResult Pricing()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult Project_Detail()
        {
            return View();
        }
        public IActionResult Projects()
        {
            return View();
        }
    }
}