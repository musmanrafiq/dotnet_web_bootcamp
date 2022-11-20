using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Person
    {
        // variables
        public int Id { get; set; } = 1;
        public string FullName { get; set; } = "Usman";

        public virtual void Introduce()
        {
            Console.WriteLine($"Hello Person, {FullName}, your Id is {Id}");
        }
    }
}
