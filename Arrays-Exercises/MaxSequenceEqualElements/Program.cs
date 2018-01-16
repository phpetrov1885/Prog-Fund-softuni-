using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceEqualElements
{
    class Program
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int count = 1;
            int maxCount = 1;
            int macth=inputArray[0];
         
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] == inputArray[i + 1])
                {
                    count++;
		    if (count > maxCount)
                    {
                        maxCount = count;
                         macth = inputArray[i];
                    }
		}
                else
                {
                    count = 1;
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write($"{macth} ");
            }
            Console.WriteLine();
        }
    }
}
