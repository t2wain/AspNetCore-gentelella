using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gentelella.Controllers
{
    public class UIController : Controller
    {
        public IActionResult Calendar()
        {
            return View();
        }
        public IActionResult General_Elements()
        {
            return View();
        }
        public IActionResult Glyphicons()
        {
            return View();
        }
        public IActionResult Icons()
        {
            return View();
        }
        public IActionResult Inbox()
        {
            return View();
        }
        public IActionResult Invoice()
        {
            return View();
        }
        public IActionResult Media_Gallery()
        {
            return View();
        }
        public IActionResult Typography()
        {
            return View();
        }
        public IActionResult Widgets()
        {
            return View();
        }
    }
}