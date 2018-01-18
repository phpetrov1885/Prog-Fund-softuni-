using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            inputNumbers = inputNumbers.OrderByDescending(s => s).Take(3).ToList();

            Console.WriteLine(string.Join(" ",inputNumbers));
        }
    }
}
