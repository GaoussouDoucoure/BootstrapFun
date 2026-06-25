//using BootstrapFun.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BootstrapFun.Controllers
{
    public class HomeController : Controller
    {
        

        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
