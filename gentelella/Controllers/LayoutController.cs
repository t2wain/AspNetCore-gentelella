using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gentelella.Controllers
{
    public class LayoutController : Controller
    {
        [Route("fixed_sidebar")]
        public IActionResult Fixed_Sidebar()
        {
            return View("~/Views/Shared/fixed/fixed_sidebar.cshtml");
        }
        [Route("fixed_footer")]
        public IActionResult Fixed_Footer()
        {
            return View("~/Views/Shared/fixed/fixed_footer.cshtml");
        }
    }
}