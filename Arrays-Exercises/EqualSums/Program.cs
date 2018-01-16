using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main()
        {

            int[] inputArray = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool foundEqualSums=false;

            string result = string.Empty;

            if (inputArray.Length == 0)
            {
                Console.WriteLine('0');
            }

            else
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    int[] leftSide = inputArray.Take(i).ToArray();
                    int[] rightSide = inputArray.Skip(i+1).ToArray();


                    if (leftSide.Sum()==rightSide.Sum())
                    {
                        Console.WriteLine(i);
                        foundEqualSums = true;
                    }
                  
                }
                if (!foundEqualSums)
                {
                    Console.WriteLine("no");
                }
            }
            
        }
    }
}
