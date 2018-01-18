using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string,int> words = new Dictionary<string, int>();

            string[] wordInput = Console.ReadLine().ToLower().Split(' ');

            foreach (var count in wordInput)
            {
                if (words.ContainsKey(count))
                {
                    words[count]++;
                }
                else
                {
                    words[count] = 1;
                }
            }

            List<string> result = new List<string>();

            foreach (var word in words)
            {
                int count = word.Value;
                
                if (count % 2 != 0)
                {
                   result.Add(word.Key);
                }
            }

            Console.WriteLine(string.Join(", ",result));
        }
    }
}
