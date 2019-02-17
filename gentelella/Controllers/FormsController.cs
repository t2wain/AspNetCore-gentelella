using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gentelella.Controllers
{
    public class FormsController : Controller
    {
        public IActionResult Form()
        {
            return View();
        }
        public IActionResult Form_Advanced()
        {
            return View();
        }
        public IActionResult Form_Buttons()
        {
            return View();
        }
        public IActionResult Form_Upload()
        {
            return View();
        }
        public IActionResult Form_Validation()
        {
            return View();
        }
        public IActionResult Form_Wizards()
        {
            return View();
        }
    }
}