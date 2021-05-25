using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amountInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitNumber = Convert.ToInt32(Console.ReadLine());
            double kilobyteNumber = bitNumber / (Math.Pow(2, 13));

            Console.WriteLine(kilobyteNumber);
            Console.ReadKey();
        }
    }
}