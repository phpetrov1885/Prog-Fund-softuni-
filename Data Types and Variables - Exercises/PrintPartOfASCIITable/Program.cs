using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumb = int.Parse(Console.ReadLine());
            int secondNumb = int.Parse(Console.ReadLine());

            for (int i = firstNumb; i <= secondNumb; i++)
            {
                char result = (char)i;
                Console.Write(result + " ");
            }
            Console.WriteLine();
        }
    }
}
