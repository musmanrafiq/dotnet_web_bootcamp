using BenchmarkDotNet.Running;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculator c = new Calculator();
            BenchmarkRunner.Run<Calculator>();
        }
    }
}