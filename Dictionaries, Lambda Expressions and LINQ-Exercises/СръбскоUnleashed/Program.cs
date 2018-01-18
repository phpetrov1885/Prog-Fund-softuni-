using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace СръбскоUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> singerList =
                new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (!input.Contains("@") )
                {
                    input = Console.ReadLine();
                    continue;
                }
               
                string[] tokens = input
                    .Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);

                if (!tokens[0].EndsWith(" "))
                {
                    input = Console.ReadLine();
                    continue;
                }

                string[] infoArgs = tokens[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string singerName = tokens[0];
                string[] cityWords = infoArgs.Take(infoArgs.Length - 2).ToArray();
                string city = string.Join(" ", cityWords);
                int ticketPrice = 0;
                int ticketCount = 0;

                try
                {
                    ticketPrice = int.Parse(infoArgs[infoArgs.Length - 2]);
                    ticketCount = int.Parse(infoArgs[infoArgs.Length - 1]);
                }
                catch (Exception)
                {
                    input = Console.ReadLine();
                    continue;
                }
                
                var income = ticketPrice * ticketCount;
                if (!singerList.ContainsKey(city))
                {
                    singerList.Add(city, new Dictionary<string, long>());
                }

                if (!singerList[city].ContainsKey(singerName))
                {
                    singerList[city].Add(singerName, income);
                }
                else
                {
                    singerList[city][singerName] += income;
                }
                
                input = Console.ReadLine();
            }

            foreach (var city in singerList)
            {
                var nameAndIncome = city.Value;
                Console.WriteLine(city.Key);
                foreach (var singer in nameAndIncome.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"#  {singer.Key}-> {singer.Value}");
                }
            }
        }
    }

}