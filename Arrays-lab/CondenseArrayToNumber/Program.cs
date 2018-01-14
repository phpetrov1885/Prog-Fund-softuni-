using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (inputArray.Length == 1)
            {
                Console.WriteLine($"{inputArray[0]} is already condensed to number");
            }
            else
            {
                int[] condensedArr = new int[inputArray.Length - 1];
                int count = 0;
                while (count != inputArray.Length - 1)
                {
                    count++;
                    for (int i = 0; i < condensedArr.Length; i++)
                    {
                        condensedArr[i] = inputArray[i] + inputArray[i + 1];
                        inputArray[i] = condensedArr[i];
                    }

                }
                Console.WriteLine(condensedArr[0]);
            }
        }
    }
}
