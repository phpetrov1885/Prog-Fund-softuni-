using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char forbiden = char.Parse(Console.ReadLine());


            for (char firstIndex = firstChar; firstIndex <= secondChar; firstIndex++)
            {
                for (char secondIndex = firstChar; secondIndex <= secondChar; secondIndex++)
                {
                    for (char thirdIndex = firstChar; thirdIndex <= secondChar; thirdIndex++)
                    {
                        string result = $"{firstIndex}{secondIndex}{thirdIndex} ";
                        if (!result.Contains(forbiden))
                        {
                            Console.Write(result);
                        }

                    }
                }
            }
        }
    }
}
