using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int result = 0;


            for (int i = secondNum; i <= 10; i++)
            {
                result = firstNum * i;
                Console.WriteLine($"{firstNum} X {i} = {result}");
            }
            if (secondNum > 10)
            {
                result = firstNum * secondNum;
                Console.WriteLine($"{firstNum} X {secondNum} = {result}");
            }
        }
    }
}
