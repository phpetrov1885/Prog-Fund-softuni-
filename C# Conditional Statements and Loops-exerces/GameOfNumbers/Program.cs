using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int boundry = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int count = 0;

            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int j = firstNum; j <= secondNum; j++)
                {
                    totalSum = j + i;
                    if (totalSum == boundry)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {boundry}");
                        return;
                    }
                    count++;

                }
            }
            Console.WriteLine($"{count} combinations - neither equals {boundry}");
        }
    }
}
