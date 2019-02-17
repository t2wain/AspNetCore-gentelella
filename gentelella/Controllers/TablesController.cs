using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gentelella.Controllers
{
    public class TablesController : Controller
    {
        public IActionResult Tables()
        {
            return View();
        }
        public IActionResult Tables_Dynamic()
        {
            return View();
        }
    }
}