using CrazyCalculatorCore;
using System;

namespace CrazyCalculatorLibrary
{
    public class CrazyCalculatorCoreLogic : ICrazyCalculatorCoreLogic
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Multiplication(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Division(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
