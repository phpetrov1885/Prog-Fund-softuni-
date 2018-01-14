using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            List<int> primeNumbers = new List<int>();

            var allPrimeNumbers = FindPrimeNumbers(startNumber, endNumber, primeNumbers);
            Console.WriteLine(string.Join(", ", allPrimeNumbers));
        }

        private static List<int> FindPrimeNumbers(int startNumber, int endNumber, List<int> primeNumbers)
        {
            bool isPrime = false;
            int something = 0;
            for (int i = startNumber; i <= endNumber; i++)
            {

                for (int j = 2; j <= endNumber; j++)
                {

                    if (i == j)
                    {
                        continue;
                    }
                    if (i % j == 0 || i == 1)
                    {
                        isPrime = false;
                        break;
                    }
                    else
                    {
                        isPrime = true;

                    }
                }
                if (isPrime)
                {
                    primeNumbers.Add(i);
                }

            }
            return primeNumbers;
        }
    }
}

