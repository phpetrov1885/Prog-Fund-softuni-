using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();


            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] command = input.Split(' ');

                if (command[0] == "A")
                {
                    string name = command[1];
                    string phoneNumber = command[2];
                    phonebook[name] = phoneNumber;
                }
                else if (command[0] == "ListAll")
                {
                    foreach (var number in phonebook)
                    {
                        string personName = number.Key;
                        string personNumber = number.Value;
                        Console.WriteLine($"{personName} -> {personNumber}");
                    }
                }
                else
                {
                    string name = command[1];
                    if (phonebook.ContainsKey(name))
                    {

                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
