using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int k = inputArr.Length / 4;

            int[] leftRow = inputArr.Take(k).Reverse().ToArray();
            int[] middleRow = inputArr.Skip(k).Take(2 * k).ToArray();
            int[] rightRow = inputArr.Skip(leftRow.Length + middleRow.Length).Reverse().ToArray();

            int [] resultArr = new int[k*2];

            for (int i = 0; i < resultArr.Length-k; i++)
            {
                resultArr[i] = middleRow[i] + leftRow[i];
                resultArr[i+k] = middleRow[i+k] + rightRow[i];
            }

            Console.WriteLine(String.Join(" ", resultArr));
           
        }
    }
}
