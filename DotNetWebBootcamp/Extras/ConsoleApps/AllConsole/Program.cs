
// dont ever put business logic inside startup class
using AllConsole;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Press a to exit or any other key to continue");

            ConsoleKeyInfo keyPressed = Console.ReadKey();

            if (keyPressed.KeyChar == 'a')
            {
                Environment.Exit(0);
            }

            //Person person = new Person();
            IPerson ali = new Student();
            ali.Introduction();

            IPerson teacher = new Teacher("Raza Ahmed", 50000);
            teacher.Introduction();

            //Person p = new Person();
        }
    }
}