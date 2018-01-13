using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int sum = 0;
            int digit = 0;
            bool isEqual = false;

            for (int i = 1; i <= input; i++)
            {
                digit = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isEqual = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{digit} -> {isEqual}");
                sum = 0;
                i = digit;
            }
        }
    }
}
