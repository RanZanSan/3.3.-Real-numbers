using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            double radius = Convert.ToDouble(Console.ReadLine());

            double areaOfCircle = pi * (Math.Pow(radius, 2));

            Console.WriteLine(areaOfCircle);
            Console.ReadKey();
        }
    }
}