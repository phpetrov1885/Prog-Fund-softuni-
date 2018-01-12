using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int itemsCnt = int.Parse(Console.ReadLine());
            double subTotal = 0;

            for (int i = 0; i < itemsCnt; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());

                if (itemCount > 1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }

                subTotal += itemPrice * itemCount;

            }

            double diff = budget - subTotal;
            Console.WriteLine($"Subtotal: ${subTotal:f2}");

            if (diff > 0)
            {
                Console.WriteLine($"Money left: ${diff:f2}");
            }
            else
            {
                double missingMoney = subTotal - budget;
                Console.WriteLine($"Not enough. We need ${missingMoney:f2} more.");
            }
        }
    }
}
