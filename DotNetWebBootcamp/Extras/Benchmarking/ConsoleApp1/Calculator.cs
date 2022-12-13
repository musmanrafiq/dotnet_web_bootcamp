using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [MemoryDiagnoser(false)]
    public class Calculator
    {
        [Benchmark]
        public int Add()
        {
            int a =2,  b = 1;
            return a + b;
        }

        [Benchmark]
        public int Minus()
        {
            int a = 2, b = 1;
            return a + b;
        }
    }
}
