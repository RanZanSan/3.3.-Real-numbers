using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmeticMean
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            int amountNumbers = 2;

            double arithmeticNumber = (firstNumber + secondNumber) / amountNumbers;

            Console.WriteLine(arithmeticNumber);
            Console.ReadKey();
        }
    }
}