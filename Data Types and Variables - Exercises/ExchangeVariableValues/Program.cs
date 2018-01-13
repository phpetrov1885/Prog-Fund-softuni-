using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {firstNum}");
            Console.WriteLine($"b = {secondNum}");

            int temp = 0;
            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;

            Console.WriteLine("After:");
            Console.WriteLine($"a = {firstNum}");
            Console.WriteLine($"b = {secondNum}");
        }
    }
}
