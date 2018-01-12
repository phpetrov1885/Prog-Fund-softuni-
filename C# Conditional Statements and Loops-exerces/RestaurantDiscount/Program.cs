using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double priceHall = 0;
            string hallName = "";
            double discount = 0;
            double pricePerPerson = 0;
            double totalPrice = 0;

            if (groupSize <= 50)
            {
                hallName = "Small Hall";
                priceHall = 2500;

                if (package == "Normal")
                {
                    discount = 0.95;
                    totalPrice = priceHall + 500;
                    totalPrice *= discount;
                    pricePerPerson = totalPrice / groupSize;
                }

                else if (package == "Gold")
                {
                    discount = 0.90;
                    totalPrice = priceHall + 750;
                    totalPrice *= discount;
                    pricePerPerson = totalPrice / groupSize;
                }
                else if (package == "Platinum")
                {
                    discount = 0.85;
                    totalPrice = priceHall + 1000;
                    totalPrice *= discount;
                    pricePerPerson = totalPrice / groupSize;
                }
            }
            if (groupSize > 50 && groupSize <= 100)
            {
                hallName = "Terrace";
                priceHall = 5000;

                if (package == "Normal")
                {
                    discount = 0.95;
                    totalPrice = priceHall + 500;
                    totalPrice *= discount;
                    pricePerPerson = totalPrice / groupSize;
                }

                else if (package == "Gold")
                {
                    discount = 0.90;
                    totalPrice = priceHall + 750;
                    totalPrice *= discount;
                    pricePerPerson = totalPrice / groupSize;
                }
                else if (package == "Platinum")
                {
                    discount = 0.85;
                    totalPrice = priceHall + 1000;
                    totalPrice *= discount;
                    pricePerPerson = totalPrice / groupSize;
                }
            }
            if (groupSize > 100 && groupSize <= 120)
            {
                hallName = "Great Hall";
                priceHall = 7500;

                if (package == "Normal")
                {
                    discount = 0.95;
                    totalPrice = priceHall + 500;
                    totalPrice *= discount;
                    pricePerPerson = totalPrice / groupSize;
                }

                else if (package == "Gold")
                {
                    discount = 0.90;
                    totalPrice = priceHall + 750;
                    totalPrice *= discount;
                    pricePerPerson = totalPrice / groupSize;
                }
                else if (package == "Platinum")
                {
                    discount = 0.85;
                    totalPrice = priceHall + 1000;
                    totalPrice *= discount;
                    pricePerPerson = totalPrice / groupSize;
                }
            }
            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");

        }
    }
    }
}
