using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbs = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < inputNumbs.Count; i++)
            {
                if (inputNumbs[i] < 0)
                {
                    inputNumbs.RemoveAt(i);
                    i--;
                }
            }

            if (inputNumbs.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                inputNumbs.Reverse();
                Console.WriteLine(string.Join(" ", inputNumbs));
            }
        }
    }
}
