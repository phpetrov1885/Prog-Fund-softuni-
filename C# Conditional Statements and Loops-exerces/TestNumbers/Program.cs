using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int boundry = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int count = 0;

            for (int i = firstNum; i >= 1; i--)
            {
                for (int j = 1; j <= secondNum; j++)
                {

                    if (totalSum >= boundry)
                    {
                        break;
                    }
                    count++;
                    totalSum += (3 * (j * i));


                }

            }

            Console.WriteLine($"{count} combinations");
            if (totalSum >= boundry)
            {
                Console.WriteLine($"Sum: {totalSum} >= {boundry}");
            }
            else
            {
                Console.WriteLine($"Sum: {totalSum}");
            }

        }
    }
}
