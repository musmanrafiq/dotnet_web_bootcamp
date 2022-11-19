
// dont ever put business logic inside startup class
using AllConsole;

public class Program
{
    public static void Main(string[] args)
    {
        Student ali = new Student();
        ali.Introduction();

        Teacher teacher = new Teacher("Raza Ahmed", 50000);
        teacher.Introduction(); 
    }
}