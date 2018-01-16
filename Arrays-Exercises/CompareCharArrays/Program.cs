using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();


            char firstArrSum = (char)firstArr.Sum(f => f);
            char secondArrSum = (char)secondArr.Sum(s => s);


            if (firstArrSum < secondArrSum)
            {
                Console.WriteLine(string.Join("", firstArr));
                Console.WriteLine(string.Join("", secondArr));
            }
            else
            {
                Console.WriteLine(string.Join("", secondArr));
                Console.WriteLine(string.Join("", firstArr));
            }
        }

    }

}

