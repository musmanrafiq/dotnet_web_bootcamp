using EmailManagement.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmailManagement.WebApp.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        { 
        }

        public IActionResult Index()
        {
            ViewBag.PageName = "Usman";
            ViewData["CurrentUser"] = "Usman Rafiq";
            TempData["Testing"] = DateTime.Now;
            return View();
        }

        public IActionResult Privacy()
        {
            var inp = TempData["Testing"];
            TempData.Keep("Testing");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var inp = TempData["Testing"];
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}