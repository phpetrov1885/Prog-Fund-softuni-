using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double triangleWidht = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());

            double triangleArea = GetTriangleArea(triangleWidht, triangleHeight);

            Console.WriteLine($"{triangleArea}");
        }


        static double GetTriangleArea(double triangleWidht, double triangleHeight)
        {
            double result = triangleWidht * triangleHeight / 2;
            return result;
        }
    }
}
