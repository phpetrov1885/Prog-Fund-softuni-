using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            PrintDigitReversed(number);
        }

        private static void PrintDigitReversed(string number)
        {
            char[] charArray = number.ToArray();
            Console.WriteLine(string.Join("", charArray.Reverse()));
        }
    }
}
