using Microsoft.AspNetCore.Mvc;

namespace Day6.Controllers
{
    public class D6Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
