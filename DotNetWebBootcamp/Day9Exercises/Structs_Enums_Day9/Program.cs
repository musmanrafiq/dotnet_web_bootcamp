namespace Structs_Enums_Day9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Position firstPosition = new Position(10, 20);
            Position secondPosition = firstPosition;
            firstPosition.X = 100;
            /*
            Console.WriteLine(secondPosition.X);
            Console.WriteLine(firstPosition.X);
            */

            foreach(var singleValue in Enum.GetValues(typeof(Role)))
            {
                Console.WriteLine((byte)singleValue);
            }
           

        }
    }
}