using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double rectanglePerimeter = (widht + height) * 2;
            double rectangleArea = widht * height;
            double sum = (widht * widht) + (height * height);
            double rectangleDiagonal = Math.Sqrt(sum);

            Console.WriteLine(rectanglePerimeter);
            Console.WriteLine(rectangleArea);
            Console.WriteLine(rectangleDiagonal);
        }
    }
}
