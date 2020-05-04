using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator : ICalculator
    {
        public Calculator(IAddService addService)
        {
            Add = addService;
            Run();
        }

        public IAddService Add { get; }

        private void Run()
        {
            Console.WriteLine("Please enter a number:");
            var a = Console.ReadLine();
            Console.WriteLine("Please enter a number:");
            var b = Console.ReadLine();
            var result = Add.Add(int.Parse(a), int.Parse(b));
            Console.WriteLine($"The sum of {a} plus {b} is {result}");
        }
    }
}
