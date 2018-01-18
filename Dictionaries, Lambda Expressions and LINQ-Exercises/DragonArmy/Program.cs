using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragonData = new Dictionary<string, Dictionary<string, int []>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string type = inputTokens[0];
                string dragonName = inputTokens[1];
                int damage = 0;
                int health = 0;
                int armor = 0;

                if (inputTokens[2] == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = int.Parse(inputTokens[2]);
                }
                if (inputTokens[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = int.Parse(inputTokens[3]);
                }
                if (inputTokens[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(inputTokens[4]);
                }
              
                if (!dragonData.ContainsKey(type))
                {
                    dragonData.Add(type, new Dictionary<string, int []>());
                }
                if (!dragonData[type].ContainsKey(dragonName))
                {
                    dragonData[type].Add(dragonName,new int [3]);
                }

                dragonData[type][dragonName][0]=damage;
                dragonData[type][dragonName][1]=health;
                dragonData[type][dragonName][2]=armor;
                
            }

            foreach (var type in dragonData)
            {
                var nameAndStats = type.Value;
                var averageDamage = type.Value.Select(s => s.Value[0]).Average();
                var averageHealth = type.Value.Select(s => s.Value[1]).Average();
                var averageArmor = type.Value.Select(s => s.Value[2]).Average();

                Console.WriteLine($"{type.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");
                foreach (var stats in nameAndStats.OrderBy(s => s.Key))
                {
                    var name = stats.Key;
                    var statics = stats.Value;

                    Console.WriteLine($"-{name} -> damage: {statics[0]}, health: {statics[1]}, armor: {statics[2]}");
                }
            }
        }
    }
}
