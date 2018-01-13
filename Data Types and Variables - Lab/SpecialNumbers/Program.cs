using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            int sum = 0;
            int firstDigit = 0;
            int secondDigit = 0;

            for (int i = 1; i <= numb; i++)
            {
                firstDigit = i % 10;
                secondDigit = i / 10;
                sum = firstDigit + secondDigit;
                
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
