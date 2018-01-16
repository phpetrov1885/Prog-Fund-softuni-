using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> text = Console.ReadLine()
                .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> lowerCase=new List<string>();
            List<string> upperCase=new List<string>();
            List<string> mixedCases=new List<string>();

            for (int i = 0; i < text.Count; i++)
            {
                if (text[i].All(char.IsLower))
                {
                    lowerCase.Add(text[i]);
                }
                else if (text[i].All(char.IsUpper))
                {
                    upperCase.Add(text[i]);
                }
                else
                {
                    mixedCases.Add(text[i]);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ",lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCases)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");      
        }
    }
}
