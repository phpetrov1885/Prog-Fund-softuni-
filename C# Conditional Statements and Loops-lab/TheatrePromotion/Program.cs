using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int personAge = int.Parse(Console.ReadLine());
            int price = 0;

            if (personAge >= 0 && personAge <= 18)
            {
                if (typeOfDay == "Weekday")
                {
                    price = 12;
                }

                else if (typeOfDay == "Weekend")
                {
                    price = 15;
                }
                else if (typeOfDay == "Holiday")
                {
                    price = 5;
                }
                Console.WriteLine($"{price}$");
            }
            else if (personAge > 18 && personAge <= 64)
            {
                if (typeOfDay == "Weekday")
                {
                    price = 18;
                }

                else if (typeOfDay == "Weekend")
                {
                    price = 20;
                }
                else if (typeOfDay == "Holiday")
                {
                    price = 12;
                }
                Console.WriteLine($"{price}$");
            }
            else if (personAge > 64 && personAge <= 122)
            {
                if (typeOfDay == "Weekday")
                {
                    price = 12;
                }

                else if (typeOfDay == "Weekend")
                {
                    price = 15;
                }
                else if (typeOfDay == "Holiday")
                {
                    price = 10;
                }
                Console.WriteLine($"{price}$");
            }

            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
