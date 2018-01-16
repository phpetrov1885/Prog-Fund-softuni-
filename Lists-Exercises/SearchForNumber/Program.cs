using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchForNumber
{
    class Program
    {
        static void Main()
        {
            List<int> inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] manipulations = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int count = manipulations[0];

            inputNumbers = inputNumbers.Take(count).ToList();
            inputNumbers.RemoveRange(0, manipulations[1]);
            int numberToFind = manipulations[2];

            if (inputNumbers.Contains(numberToFind))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}

