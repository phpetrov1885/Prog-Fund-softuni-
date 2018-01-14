using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            SquareHeader(number);
            SquareBody(number);
            SquareFooter(number);
        }

        static void SquareHeader(int number)
        {

            Console.WriteLine(new string('-', 2 * number));

        }

        static void SquareBody(int number)
        {
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write('-');
                for (int j = 1; j < number; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }

        static void SquareFooter(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }
    }
}
