using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fractionalPart
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = Convert.ToDouble(Console.ReadLine());
            double fractionalNumber = number - (int)number;

            Console.WriteLine(fractionalNumber);
            Console.ReadKey();
        }
    }
}