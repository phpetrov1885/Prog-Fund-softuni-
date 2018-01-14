using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            int result = GetMultipleOfEvensAndOdds(number);

            Console.WriteLine(result);
        }

        static int GetMultipleOfEvensAndOdds(int number)
        {
            int oddSum = GetSumOfOddNums(number);
            int evenSum = GetSumOfEvenNums(number);
            return oddSum * evenSum;
        }

        static int GetSumOfOddNums(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int lastNum = number % 10;
                if (lastNum % 2 != 0)
                {
                    sum += lastNum;
                }

                number /= 10;
            }
            return sum;
        }

        static int GetSumOfEvenNums(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int lastNum = number % 10;
                if (lastNum % 2 == 0)
                {
                    sum += lastNum;
                }

                number /= 10;
            }
            return sum;
        }
    }
}
