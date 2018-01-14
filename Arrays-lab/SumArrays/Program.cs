using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] secondArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int arrMaxLenght = Math.Max(firstArr.Length, secondArr.Length);
            int [] resultArr=new int[arrMaxLenght];

            for (int i = 0; i < resultArr.Length; i++)
            {
                int sum = firstArr[i % firstArr.Length] + secondArr[i % secondArr.Length];
                resultArr[i] = sum;
            }
            Console.WriteLine(string.Join(" ",resultArr));
        }
    }
}
