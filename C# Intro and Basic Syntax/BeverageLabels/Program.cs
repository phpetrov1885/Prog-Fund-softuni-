using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyContent = double.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());

            double kcal = (volume / 100) * energyContent;
            double sugars = (volume / 100) * sugarContent;

            Console.WriteLine($"{volume}ml {product}:");
            Console.WriteLine($"{kcal}kcal, {sugars}g sugars");
        }
    }
}
