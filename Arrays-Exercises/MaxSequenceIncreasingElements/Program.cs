using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int count = 1;
            int maxCount = 1;
            int element = inputArray[0];
            int seqStart = 0;
            int lenght = 1;
           
            
            for (int i =1; i < inputArray.Length; i++)
            {
                if (inputArray[i]>inputArray[i-1])
                {
                    count++;

                    if (count>maxCount)
                    {
                        maxCount = count;
                        lenght = seqStart;
                    }
                }
                else
                {
                    count = 1;
                    seqStart = i;
                }
            }

            for (int i = lenght; i < lenght+maxCount; i++)
            {
                Console.Write(inputArray[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
