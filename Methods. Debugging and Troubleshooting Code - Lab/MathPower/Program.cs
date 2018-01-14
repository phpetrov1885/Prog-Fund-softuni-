using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            double numPower = GetTNumberPower(firstNum, secondNum);

            Console.WriteLine($"{numPower}");
        }


        static double GetTNumberPower(double firstNum, double secondNum)
        {
            return Math.Pow(firstNum, secondNum);
        }
    }
}
