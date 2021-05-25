using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstDigitAfterDot
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = Convert.ToDouble(Console.ReadLine());
            double firstNumberAfterDot = number * 10;
            int firstNumber = (int)firstNumberAfterDot % 10;

            Console.WriteLine(firstNumber);
        }
    }
}