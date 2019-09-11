using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Something.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
			ViewData["msg"] = "Hello,World!";
            return View();
        }
    }
}