using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddleOneTwoOrThreeElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (inputArray.Length==1)
            {
                Console.WriteLine($"{{ {inputArray[0]} }}");
            }
            else if (inputArray.Length % 2 == 0)
            {
                int[] leftSide = inputArray.Take(inputArray.Length / 2).ToArray();
                int[] rightSide = inputArray.Skip(inputArray.Length / 2).Take(1).ToArray();
                Console.WriteLine($"{{ {leftSide[leftSide.Length - 1]}" +
                                  $", {rightSide[0]} }}");
            }
            else if (inputArray.Length % 2 != 0)
            {
                int[] leftSide = inputArray.Take(inputArray.Length / 2+1).ToArray();
                int[] rightSide = inputArray.Skip(inputArray.Length / 2+1).Take(1).ToArray();
                Console.WriteLine($"{{ {leftSide[leftSide.Length - 2]}" +
                                  $", {leftSide[leftSide.Length - 1]}" +
                                  $", {rightSide[0]} }}");
            }
            
        }
    }
}
