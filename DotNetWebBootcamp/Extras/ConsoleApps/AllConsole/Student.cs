namespace AllConsole
{
    internal class Student : Person
    {
        // variables
        int userAge = 29;
        string fullName = "Ali";

        
        public void Introduction()
        {
            Console.WriteLine($"Hello, {FullName}, \n your age is {userAge} \n");
        }
    }
}
