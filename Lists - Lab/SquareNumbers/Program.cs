using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNums = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();


            for (int i = 0; i < inputNums.Count; i++)
            {
                if (Math.Sqrt(inputNums[i])==(int)Math.Sqrt(inputNums[i]))
                {
                    result.Add(inputNums[i]);
                }
              
            }
            result.Sort((a,b)=>b.CompareTo(a));
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
