namespace FirstPublishedApp
{
    internal class Program
    {// variables
        static int userAge = 29;
        static string fullName = "This is my full name";
        static double salary = 1000.0;

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter character e to exit, else to continue");

                ConsoleKeyInfo input = Console.ReadKey();
                if(input.KeyChar == 'e')
                {
                    Environment.Exit(0);
                }
                Console.WriteLine($"Hello, {fullName}, \n your age is {userAge}");
            }
        }
    }
}