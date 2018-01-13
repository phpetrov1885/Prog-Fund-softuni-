using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            for (int col = 2; col <= numb; col++)
            {
                bool isPrime = true;
                for (int row = 2; row <= Math.Sqrt(col); row++)
                {
                    if (col % row == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{col} -> {isPrime}");
            }
        }
    }
}
