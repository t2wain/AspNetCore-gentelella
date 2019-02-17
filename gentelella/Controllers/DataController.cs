using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gentelella.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Chartjs()
        {
            return View();
        }
        public IActionResult Chartjs2()
        {
            return View();
        }
        public IActionResult Echarts()
        {
            return View();
        }
        public IActionResult Morisjs()
        {
            return View();
        }
        public IActionResult Other_Charts()
        {
            return View();
        }
    }
}