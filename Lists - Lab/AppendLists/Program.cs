using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNumbs = Console.ReadLine().Split('|');


            List<int> result = new List<int>();

            for (int i = inputNumbs.Length - 1; i >= 0; i--)
            {
                List<int> leffSide = inputNumbs[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                result.AddRange(leffSide);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
