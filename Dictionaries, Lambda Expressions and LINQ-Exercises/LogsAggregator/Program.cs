using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string,SortedDictionary<string,int> > entryRegister=
                new SortedDictionary<string, SortedDictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string ipAddress = input[0];
                string  userName = input[1];
                int countEntries = int.Parse(input[2]);
               
                if (!entryRegister.ContainsKey(userName))
                {
                    entryRegister.Add(userName,new SortedDictionary<string,int>());
                }
               
                if (!entryRegister[userName].ContainsKey(ipAddress))
                {
                    entryRegister[userName].Add(ipAddress,countEntries);
                }
                else
                {
                    entryRegister[userName][ipAddress] += countEntries;
                }
              
            }
            foreach (var outerPair in entryRegister)
            {
                var sum = outerPair.Value.Values.Sum();

                Console.Write("{0}: {1} ", outerPair.Key, sum);
                Console.Write("[");
                Console.Write(string.Join(", ", outerPair.Value.Keys));
                Console.WriteLine("]");
            }
        }
    }
}
