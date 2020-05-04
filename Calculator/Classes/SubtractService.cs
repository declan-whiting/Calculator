using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Classes
{
    public class SubtractService : ISubtractService
    {
        public int Subtract(int a, int b) => a - b;
    }
}
