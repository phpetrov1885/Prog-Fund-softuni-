using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int maxNumber = GetMaxNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(maxNumber);
        }

        static int GetMaxNumber(int firstNumber, int secondsNumber, int thirdNumber)
        {
            int resultMaxNum = Math.Max(firstNumber, Math.Max(secondsNumber, thirdNumber));
            return resultMaxNum;
        }
    }
}
