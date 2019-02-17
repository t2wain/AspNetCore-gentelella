using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gentelella.Controllers
{
    public class ExtraController : Controller
    {
        [Route("page_403")]
        public IActionResult Page_403()
        {
            return View("~/Views/Shared/errors/page_403.cshtml");
        }

        [Route("page_404")]
        public IActionResult Page_404()
        {
            return View("~/Views/Shared/errors/page_404.cshtml");
        }

        [Route("page_500")]
        public IActionResult Page_500()
        {
            return View("~/Views/Shared/errors/page_500.cshtml");
        }

        [Route("plain_page")]
        public IActionResult Plain_Page()
        {
            return View("~/Views/Shared/plain_page.cshtml");
        }
    }
}