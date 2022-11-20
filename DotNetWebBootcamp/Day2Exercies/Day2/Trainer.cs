using System.Runtime.CompilerServices;

namespace Day2
{
    internal sealed class Trainer : Person
    {

        private int _salary = 10000;
        public int Salary { 
            get { return _salary; } 
            private set { _salary = value; } 
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hello, {FullName}, your Id is {Id}");
        }
    }
}
