using System;
using CrazyCalculatorLibrary;

namespace CrazyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CrazyCalculatorLibrary.CrazyCalculatorCoreLogic calculator = new CrazyCalculatorLibrary.CrazyCalculatorCoreLogic();
            var result = calculator.Addition(1, 2);


            CrazyCalculatorLibrary.CrazyCalculatorCoolResult calculatorWithCoolResult = new CrazyCalculatorCoolResult();
            var coolResult = calculatorWithCoolResult.Addition(1, 2);

            Console.WriteLine(result);
            Console.WriteLine(coolResult.FormattedResult);
        }
    }
}
