// See https://aka.ms/new-console-template for more information


using System;

namespace Day1Exercise
{

    public class Program
    {

        // variables
        static int userAge = 29;
        static string fullName = "This is my full name";
        static double salary = 1000.0;



        public static void Main(string[] args)
        {
            Console.WriteLine($"Hello, {fullName}, \n your age is {userAge}");

            /*foreach(char singleChar in fullName)
            {
                Console.Write(singleChar + "\n");
            }*/

            Console.WriteLine(fullName.Substring(fullName.IndexOf('m')));
        }
    }

}