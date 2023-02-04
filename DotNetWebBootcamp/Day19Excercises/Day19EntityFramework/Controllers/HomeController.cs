using Day19EntityFramework.Data;
using Day19EntityFramework.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace Day19EntityFramework.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            var claimsList = new List<Claim> {
                new Claim(ClaimTypes.Name, "ABC"),
                new Claim(ClaimTypes.Role, "Admin")
            };

            var claimIdentity = new ClaimsIdentity(claimsList, "login");
            var claimPrinciple = new ClaimsPrincipal(claimIdentity);
            await HttpContext.SignInAsync(claimPrinciple);


            var employee = new Employee { 
                Name = "Employee1",
                Address = "House # 11",
                PayDetail = new PayDetail
                {
                    Pay = 10000
                }
            };
            _context.Employees.Add(employee);
            _context.SaveChanges();

            var stuent1 = new Student
            {
                Name = "Student1",
                EnrolmentDate = DateTime.Now,
            };

            var stuent2 = new Student
            {
                Name = "Student1",
                EnrolmentDate = DateTime.Now,
            };

            var course1 = new Course
            {
                Title = "Course1",
            };

            var Course2 = new Course
            {
                Title = "Course2"
            };


            stuent1.StudentCourses.Add(new StudentCourse { Course = course1 });
            stuent1.StudentCourses.Add(new StudentCourse { Course = Course2 });
            stuent2.StudentCourses.Add(new StudentCourse { Course = Course2 });

            _context.Students.Add(stuent2);
            _context.Students.Add(stuent1);
            _context.SaveChanges();


            return View();
        }

        [HttpPost]
        public IActionResult Login(dynamic userModel)
        {

            //var user = _context.Employees.Where(x=>x.Name == userModel.Name).FirstOrDefault();

            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}