using Microsoft.AspNetCore.Mvc;
using WebApplication1.BusinessServices;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }
    
        public IActionResult Index()
        {
            _studentService.Add(1);

            return View(_studentService.Get());
        }
    }
}
