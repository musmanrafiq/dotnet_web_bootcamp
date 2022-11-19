using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllConsole
{
    internal class Teacher : IPerson
    {
        // variables
        public double Salary { get; set; } = 1000;
        public string FullName { get; set; }

        public Teacher(string fullName, int salary)
        {
            this.FullName = fullName;
            this.Salary = salary;
        }

        public void Introduction()
        {
            Console.WriteLine($"Hello, {FullName}, \n" +
                $"and your salary is : {Salary}");
        }
    }
}
