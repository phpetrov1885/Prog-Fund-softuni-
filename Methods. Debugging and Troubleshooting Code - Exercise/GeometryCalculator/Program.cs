using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double areaResult = 0;
            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                areaResult = GetTriangleArea(side, height);
            }
            else if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                areaResult = GetSquareArea(side);
            }
            else if (figureType == "rectangle")
            {
                double widht = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                areaResult = GetRectangleArea(widht, height);
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                areaResult = GetCircleArea(radius);
            }
            Console.WriteLine($"{areaResult:f2}");
        }

        private static double GetCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        private static double GetRectangleArea(double widht, double height)
        {
            return widht * height;
        }

        private static double GetSquareArea(double side)
        {
            return side * side;
        }

        private static double GetTriangleArea(double side, double height)
        {
            return (side * height) / 2;
        }
    }
}

