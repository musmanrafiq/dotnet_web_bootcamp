namespace Day2
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Person trainer = new Trainer();
            trainer.Introduce();

            Person student = new Student(1, "Usman");

            student.Introduce();

            
        }
    }
}