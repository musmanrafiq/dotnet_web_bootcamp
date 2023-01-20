using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day19EntityFramework.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

       public DbSet<Employee> Employees { get; set; }
    }

    //[Table()]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
