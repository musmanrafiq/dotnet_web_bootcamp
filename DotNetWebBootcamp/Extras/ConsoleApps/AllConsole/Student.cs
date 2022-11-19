namespace AllConsole
{
    internal class Student : IPerson
    {
        // variables
        int userAge = 29;
        public string FullName { get; set; }

        
        public void Introduction()
        {
            Console.WriteLine($"Hello, {FullName}, \n your age is {userAge} \n");
        }
    }
}
