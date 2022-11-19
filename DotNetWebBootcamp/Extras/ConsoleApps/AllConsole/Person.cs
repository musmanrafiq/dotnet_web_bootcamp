namespace AllConsole
{
    internal class Person
    {
        public string FullName { get; set; } = string.Empty;

        //public abstract void GetHeight();
        public virtual void Introduction()
        {
            Console.WriteLine($"Hello, {FullName}");
        }
    }
}
