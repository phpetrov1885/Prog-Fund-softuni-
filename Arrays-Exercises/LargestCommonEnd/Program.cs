using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();

            int countFormLeft = GetCountCommonEndFormLeft(firstArray, secondArray);
            var countReversed = GetCountCommonEndReversed(firstArray, secondArray);

            if (countFormLeft > countReversed)
            {
                Console.WriteLine(countFormLeft);
            }
            else
            {
                Console.WriteLine(countReversed);
            }
        }

        private static int GetCountCommonEndReversed(string[] firstArray, string[] secondArray)
        {
            Array.Reverse(firstArray);
            Array.Reverse(secondArray);
            int lenght = Math.Min(firstArray.Length, secondArray.Length);
            int count = 0;
            for (int i = 0; i < lenght; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }

        private static int GetCountCommonEndFormLeft(string[] firstArray, string[] secondArray)
        {
            int lenght = Math.Min(firstArray.Length, secondArray.Length);
            int count = 0;
            for (int i = 0; i < lenght; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }
    }

}


