using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 1; i < num * 2; i++)
            {

                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    result += i;
                }
            }
            Console.WriteLine($"Sum: {result}");
        }
    }
}
