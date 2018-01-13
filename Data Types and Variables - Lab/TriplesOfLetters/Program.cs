using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            
            for (int i = 97; i < 97 + numb; i++)
            {
                for (int j = 97; j < 97 + numb; j++)
                {
                    for (int k = 97; k < 97 + numb; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
