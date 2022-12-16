using Day6.Models;
using Day6.Services;
using Microsoft.AspNetCore.Mvc;

namespace Day6.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            List<StudentModel> students = StudentService.GetAll();

            return View(students);
        }

        public IActionResult Add() { return View(); }

        [HttpPost]
        public IActionResult Add(StudentModel model) 
        {
            StudentService.Add(model);
            return RedirectToAction(nameof(Index));
        }
    }
}
