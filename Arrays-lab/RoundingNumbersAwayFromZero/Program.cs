using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine($"{inputArray[i]} => {Math.Round(inputArray[i],MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
