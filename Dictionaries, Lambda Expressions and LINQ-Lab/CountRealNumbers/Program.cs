using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double,int> numbers = new SortedDictionary<double, int>();

            double[] inputArr = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();

            foreach (double num in inputArr)
            {
                if (numbers.ContainsKey(num))
                {
                    numbers[num]++;
                }
                else
                {
                    numbers[num] = 1;
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
