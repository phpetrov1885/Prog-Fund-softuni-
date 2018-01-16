using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqual
{
    class Program
    {
        static void Main(string[] args)
        {

            List<decimal> inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();

            List<decimal> result = new List<decimal>();
            decimal sum = 0;
            bool isSummed = true;
            int index = 0;
            while (isSummed)
            {
                isSummed = false;
                for (int i = 1; i < inputNumbers.Count; i++)
                {
                    if (inputNumbers[i] == inputNumbers[i - 1])
                    {
                        index = i - 1;
                        sum = inputNumbers[i] + inputNumbers[i - 1];
                        isSummed = true;
                        break;
                    }

                }
                if (isSummed)
                {
                    inputNumbers.RemoveRange(index, 2);
                    inputNumbers.Insert(index, sum);
                }

            }
            Console.WriteLine(string.Join(" ", inputNumbers));
        }
    }
}
