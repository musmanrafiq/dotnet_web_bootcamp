namespace Day2
{
    internal class Student : Person
    {

        public Student()
        {

        }
        public Student(int id, string name)
        {

        }
        public override void Introduce()
        {
            Console.WriteLine($"Hello, {FullName}, your Id is {Id}");
        }
    }
}
