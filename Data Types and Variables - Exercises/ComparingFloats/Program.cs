using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumb = double.Parse(Console.ReadLine());
            double secondNumb = double.Parse(Console.ReadLine());
            bool isEquals = false;
            double eps = 0.000001;

            if (Math.Abs(firstNumb) - Math.Abs(secondNumb) > eps ||
                Math.Abs(firstNumb) - Math.Abs(secondNumb) > eps)
            {
                isEquals = false;
            }
            else
            {
                isEquals = true;
            }
            Console.WriteLine(isEquals);
        }
    }
}
