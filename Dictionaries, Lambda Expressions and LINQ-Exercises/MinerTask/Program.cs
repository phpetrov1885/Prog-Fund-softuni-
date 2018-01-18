using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> resourcesList =new Dictionary<string, int>();

            
            while (true)
            {
                string resource = Console.ReadLine();
                if (resource=="stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (!resourcesList.ContainsKey(resource))
                {
                   resourcesList.Add(resource,quantity);
                }

                else
                {
                    resourcesList[resource] += quantity;
                }
           
            }

            foreach (var material in resourcesList)
            {
                Console.WriteLine($"{material.Key} -> {material.Value}");
            }
        }
    }
}
