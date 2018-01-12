using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (word.EndsWith("y"))
            {
                word = word.Replace('y', 'i');
                Console.WriteLine(word + "es");
            }
            else if (word.EndsWith("o") || word.EndsWith("ch") ||
                     word.EndsWith("s") || word.EndsWith("sh")
                     || word.EndsWith("z") || word.EndsWith("x"))
            {
                Console.WriteLine(word + "es");
            }
            else
            {
                Console.WriteLine(word + 's');
            }
        }
    }
}
