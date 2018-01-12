using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double result = ((double)width * height) / 1000000;
            result = Math.Round(result, 1);

            Console.WriteLine($"{width}x{height} => {result}MP"); 
           
        }
    }
}
