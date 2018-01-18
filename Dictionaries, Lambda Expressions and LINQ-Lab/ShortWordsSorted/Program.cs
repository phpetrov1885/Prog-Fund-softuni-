using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine()
                .ToLower()
                .Split(new char[] {'.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' '},
                    StringSplitOptions.RemoveEmptyEntries);

            var result = input.Where(s => s.Length < 5).OrderBy(s => s).Distinct();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
