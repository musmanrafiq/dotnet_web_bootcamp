using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day19EntityFramework.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        
       public DbSet<Employee> Employees { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

    }

    //[Table()]
    public class Employee
    {
        public Employee()
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }
        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Address { get; set; }

        public int PayDetailId { get; set; }
        public PayDetail PayDetail { get; set; }

        public HashSet<Address> Addresss { get; set; }
    }

    public class Address
    {
        public int Id { get; set; }
        public string House { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }  

    }
    public class PayDetail
    {
        public int Id { get; set; }
        public int Pay { get; set; }
        [ForeignKey("Employee")]
        public int Eid { get; set; }
        public Employee Employee { get; set; }
    }

    public class Student
    {
        public Student()
        {
            //StudentCourses = new List<StudentCourse>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime EnrolmentDate { get; set; }
        //public ICollection<StudentCourse> StudentCourses { get; set; } 
    }

    public class Course
    {
        public Course()
        {
            //StudentCourses = new List<StudentCourse>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public int CreditHours { get; set; }

        //public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
