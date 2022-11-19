
// dont ever put business logic inside startup class
using AllConsole;

public class Program
{
    public static void Main(string[] args)
    {
        //Person person = new Person();
        IPerson ali = new Student();
        ali.Introduction();

        IPerson teacher = new Teacher("Raza Ahmed", 50000);
        teacher.Introduction(); 
    }
}