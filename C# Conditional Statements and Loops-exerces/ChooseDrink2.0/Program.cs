using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseDrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;


            if (profession == "Athlete")
            {
                double priceWater = 0.70;
                price = priceWater * quantity;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                double priceCoffee = 1;
                price = priceCoffee * quantity;
            }
            else if (profession == "SoftUni Student")
            {
                double priceBeer = 1.70;
                price = priceBeer * quantity;
            }
            else
            {
                double priceTea = 1.20;
                price = priceTea * quantity;
            }
            Console.WriteLine($"The {profession} has to pay {price:f2}.");
        }
    }
}
