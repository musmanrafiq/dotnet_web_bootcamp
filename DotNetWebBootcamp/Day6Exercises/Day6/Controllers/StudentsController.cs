using Day6.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day6.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add() { return View(); }

        [HttpPost]
        public IActionResult Add(StudentModel model) 
        {
            return View(); 
        }
    }
}
