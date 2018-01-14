using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                Console.WriteLine(GetDigitMax(firstNum, secondNum));
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                Console.WriteLine(GetTheBiggerChar(firstChar, secondChar));
            }
            else
            {
                string firstWord = Console.ReadLine();
                string secondWord = Console.ReadLine();
                Console.WriteLine(GetBiggestString(firstWord, secondWord));
            }
        }


        static int GetDigitMax(int firstNum, int secondNum)
        {
            return Math.Max(firstNum, secondNum);
        }

        static char GetTheBiggerChar(char firstChar, char secondChar)
        {
            int result = Math.Max(firstChar, secondChar);
            return (char)result;
        }

        static string GetBiggestString(string firstWord, string secondWord)
        {
            string result = string.Empty;
            if (firstWord.CompareTo(secondWord) >= 0)
            {
                result = firstWord;
            }
            else
            {
                result = secondWord;
            }
            return result;
        }
    }
}
