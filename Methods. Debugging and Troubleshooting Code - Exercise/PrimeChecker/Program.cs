using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            n = Math.Abs(n);

            Console.WriteLine(IfTheNumberIsPRime(n));
        }

        private static bool IfTheNumberIsPRime(long n)
        {

            if (n == 1 || n == 0)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }
            for (long i = 2; i <= Math.Ceiling(Math.Sqrt(n)); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

