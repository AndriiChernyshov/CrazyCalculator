using System;
using CrazyCalculatorLibrary;
using CrazyStuff;

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

            CrazyStuff.CrazyTextFormatter textFormatter = new CrazyTextFormatter();
            var text = textFormatter.CharToText();

            Console.WriteLine(result);
            Console.WriteLine(coolResult.FormattedResult);
            Console.WriteLine(text);
        }
    }
}
