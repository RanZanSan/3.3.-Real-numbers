using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perimeterRightTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double oneLeg = Convert.ToDouble(Console.ReadLine());
            double legTwo = Convert.ToDouble(Console.ReadLine());
            double perimeter = oneLeg + legTwo + Math.Sqrt(Math.Pow(oneLeg, 2) + Math.Pow(legTwo, 2));

            Console.WriteLine(perimeter);
            Console.ReadKey();
        }
    }
}