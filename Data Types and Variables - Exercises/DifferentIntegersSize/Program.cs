using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger numb = BigInteger.Parse(Console.ReadLine());

            if (numb > 9223372036854775807)
            {
                Console.WriteLine($"{numb} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{numb} can fit in:");
                if (numb >= -128 && numb <= 128)
                {
                    Console.WriteLine("* sbyte");
                }
                if (numb > 0 && numb <= 255)
                {
                    Console.WriteLine("* byte");
                }
                if (numb >= -32768 && numb <= 32767)
                {
                    Console.WriteLine("* short");
                }
                if (numb > 0 && numb <= 65535)
                {
                    Console.WriteLine("* ushort");
                }
                if (numb >= -2147483648 && numb <= 2147483647)
                {
                    Console.WriteLine("* int");
                }
                if (numb > 0 && numb <= 4294967295)
                {
                    Console.WriteLine("* uint");
                }
                if (numb >= -9223372036854775808 && numb <= 9223372036854775807)
                {
                    Console.WriteLine("* long");
                }
            }
        }
    }
}
