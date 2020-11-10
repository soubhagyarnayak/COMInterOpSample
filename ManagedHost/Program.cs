using ManagedCOMService;
using System;

namespace ManagedHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator calc = new Calculator();
            calc.Add(10, 20);
            Console.ReadKey();
        }
    }
}
