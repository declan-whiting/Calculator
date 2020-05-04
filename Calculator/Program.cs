using Microsoft.Extensions.DependencyInjection;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var serviceProvider = new ServiceCollection()
            .AddTransient<IAddService, AddService>()
            .AddSingleton<ICalculator, Calculator>()
            .BuildServiceProvider();

            var calculator = serviceProvider.GetService<ICalculator>();
        }
    }
}
