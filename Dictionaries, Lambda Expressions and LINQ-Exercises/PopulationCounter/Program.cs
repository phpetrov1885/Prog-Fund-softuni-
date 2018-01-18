using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Dictionary<string,List<long>>> populationRegister = 
                new Dictionary<string, Dictionary<string, List<long>>>();

            string input = Console.ReadLine();

            while (input !="report")
            {
                var tokens = input.Split('|');
                var city = tokens[0];
                var country = tokens[1];
                var population = int.Parse(tokens[2]);

                if (!populationRegister.ContainsKey(country))
                {
                    populationRegister.Add(country,new Dictionary<string, List<long>>());
                }
                if (!populationRegister[country].ContainsKey(city))
                {
                    populationRegister[country].Add(city,new List<long>());
                }
               
                populationRegister[country][city].Add(population);
               
                input = Console.ReadLine();
            }

            foreach (var countries in populationRegister.OrderByDescending(c=>c.Value.Values.Sum(s=>s.Sum())))
            {
                var country = countries.Key;
                var populationInformation = countries.Value;
                var totalCoutryPop = countries.Value.Select(s => s.Value[0]).Sum();

                Console.WriteLine($"{country} (total population: {totalCoutryPop})");
                foreach (var city in populationInformation.OrderByDescending(s=>s.Value.Sum()))
                {
                    Console.WriteLine($"=>{city.Key}: {string.Join(" ", city.Value)}");
                }
            }
        }
    }
}
