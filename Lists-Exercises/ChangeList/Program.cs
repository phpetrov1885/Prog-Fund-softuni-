using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "Even" &&
                command != "Odd")
            {
                var tokens = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (tokens[0] == "Delete")
                {
                    int numberToRemove = int.Parse(tokens[1]);
                    inputNums.RemoveAll(n => n == numberToRemove);
                }
                else if (tokens[0] == "Insert")
                {

                    inputNums.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                }


                command = Console.ReadLine();
            }

            if (command == "Even")
            {
                for (int i = 0; i < inputNums.Count; i++)
                {
                    if (inputNums[i] % 2 == 1)
                    {
                        inputNums.RemoveAt(i);
                        i--;
                    }
                }
            }

            else if (command == "Odd")
            {
                inputNums = inputNums.Where(n => n % 2 == 1).ToList();
            }
            Console.WriteLine(string.Join(" ", inputNums));
        }
    }
}
