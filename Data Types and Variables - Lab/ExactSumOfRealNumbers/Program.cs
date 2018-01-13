using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < numCount; i++)
            {
                decimal digit = decimal.Parse(Console.ReadLine());
                sum += digit;
            }
            Console.WriteLine(sum);
        }
    }
}
