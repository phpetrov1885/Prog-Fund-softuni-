using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string binary = Convert.ToString(input, 2);
            string hexDecimal = input.ToString("X");

            Console.WriteLine(hexDecimal);
            Console.WriteLine(binary);
        }
    }
}
