using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if (char.IsDigit(input))
            {
                Console.WriteLine("digit");
            }
            else
            {
                if (input == 'a' || input == 'i'
                    || input == 'e' || input == 'o'
                    || input == 'u')
                {
                    Console.WriteLine("vowel");
                }
                else
                {
                    Console.WriteLine("other");
                }
            }
        }
    }
}
