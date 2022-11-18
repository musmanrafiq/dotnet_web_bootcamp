// See https://aka.ms/new-console-template for more information


public class Program
{

    // variables
    int userAge = 29;
    static string fullName = "This is my full name";
    double salary = 1000.0;



    public static void Main(string[] args)
    {
        Console.WriteLine($"Hello, {fullName}, \n your age is {29}");

        /*foreach(char singleChar in fullName)
        {
            Console.Write(singleChar + "\n");
        }*/

        Console.WriteLine(fullName.Substring(fullName.IndexOf('m')));
    }
}

