using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            bool isSummed = false;

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    var sum = inputArray[i] + inputArray[j];
                    if (inputArray.Contains(sum))
                    {
                        Console.WriteLine($"{inputArray[i]} + {inputArray[j]} == {sum}");
                        isSummed = true;
                    }
                }
            }
            if (!isSummed)
            {
                Console.WriteLine("No");
            }
        }
    }
}
