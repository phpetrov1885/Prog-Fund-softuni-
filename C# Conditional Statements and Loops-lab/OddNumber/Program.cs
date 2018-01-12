using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());

            while (true)
            {
                if (numb % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                    numb = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(numb)}");
                    break;
                }
            }
        }
    }
}
