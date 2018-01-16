using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int[] sumArr = new int[inputArray.Length];
            int countRotations = 0;

            while (rotations !=countRotations)
            {
                int reminder = inputArray[inputArray.Length - 1];

                for (int i = inputArray.Length - 1; i > 0; i--)
                {

                    inputArray[i] = inputArray[i - 1];

                }

                inputArray[0] = reminder;

                for (int i = 0; i < inputArray.Length; i++)
                {
                    sumArr[i] += inputArray[i];
                }
                countRotations++;
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
