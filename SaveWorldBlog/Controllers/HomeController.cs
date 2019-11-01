using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SaveWorldBlog.Controllers
{
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Articles()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
