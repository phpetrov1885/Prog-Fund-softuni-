using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbs = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int k = arrayNumbs.Length / 4;
            int rightAndMiddle = arrayNumbs.Length - k;

            int[] leftSide = arrayNumbs.Take(k).Reverse().ToArray();
            int[] rightSide = arrayNumbs.Skip(rightAndMiddle).Reverse().ToArray();
            int[] middleArr = arrayNumbs.Take(rightAndMiddle).Skip(k).ToArray();

            int[] resultArr = new int[k * 2];

            for (int i = 0; i < k; i++)
            {
                resultArr[i] = leftSide[i] + middleArr[i];
                resultArr[i + k] = middleArr[i + k] + rightSide[i];
            }

            Console.WriteLine(string.Join(" ", resultArr));
        }

    }

}

