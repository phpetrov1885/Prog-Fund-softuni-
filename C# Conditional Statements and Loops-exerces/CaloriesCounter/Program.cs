using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int cheese = 500;
            int tomatoSauce = 150;
            int salami = 600;
            int pepper = 50;
            int totalCalories = 0;

            for (int i = 0; i < num; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                if (ingredient == "cheese")
                {
                    totalCalories += cheese;
                }
                else if (ingredient == "tomato sauce")
                {
                    totalCalories += tomatoSauce;
                }
                else if (ingredient == "salami")
                {
                    totalCalories += salami;
                }
                else if (ingredient == "pepper")
                {
                    totalCalories += pepper;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
