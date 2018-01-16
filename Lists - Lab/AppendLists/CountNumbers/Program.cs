using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int count = 1;
            int lastDigit = 0;

            inputNumbers.Sort();

            for (int i = 1; i < inputNumbers.Count; i++)
            {
                if (inputNumbers[i-1]==inputNumbers[i])
                {
                    count++;
                    lastDigit = inputNumbers[i];
                }
                else
                {
                    Console.WriteLine($"{inputNumbers[i-1]} -> {count}");
                    count = 1;
                }
            }
            Console.WriteLine($"{lastDigit} -> {count}");
        }
    }
}
