using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int tempCount = 1;
            int maxCount = 1;
            int count = 1;
            int temp = 0;
            int match = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                temp = inputArray[i];
                tempCount = 0;

                for (int j = 1; j < inputArray.Length; j++)
                {
                    if (temp==inputArray[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount>count)
                {
                    match = temp;
                    count = tempCount;
                }
            }
            Console.WriteLine(match);
        }
    }
}
