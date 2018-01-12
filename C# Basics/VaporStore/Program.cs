using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> gameData = new Dictionary<string, double>
            {
                ["OutFall 4"] = 39.99,
                ["CS: OG"] = 15.99,
                ["Zplinter Zell"] = 19.99,
                ["Honored 2"] = 59.99,
                ["RoverWatch"] = 29.99,
                ["RoverWatch Origins Edition"] = 39.99

            };

            double budget = double.Parse(Console.ReadLine());
            string wantedGame = Console.ReadLine();
            double moneyspend = budget;

            while (wantedGame != "Game Time")
            {
                if (!gameData.ContainsKey(wantedGame))
                {
                    Console.WriteLine("Not Found");
                }

                else if (moneyspend >= gameData[wantedGame])
                {
                    if (moneyspend == gameData[wantedGame])
                    {
                        moneyspend -= gameData[wantedGame];
                        Console.WriteLine($"Bought {wantedGame}");
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    moneyspend -= gameData[wantedGame];
                    Console.WriteLine($"Bought {wantedGame}");
                }
                else if (moneyspend < gameData[wantedGame])
                {
                    Console.WriteLine("Too Expensive");
                }

                wantedGame = Console.ReadLine();
            }

            double diff = budget - moneyspend;

            if (moneyspend > 0)
            {
                Console.WriteLine($"Total spent: ${diff:f2}. Remaining: ${moneyspend:f2}");
            }
        }
    }
}
