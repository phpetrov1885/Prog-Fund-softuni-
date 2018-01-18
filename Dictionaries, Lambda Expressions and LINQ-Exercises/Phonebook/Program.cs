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
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

	    string input = Console.ReadLine();

            while (input != "END")
            {
                string[] command = input.Split(' ');

                string name = command[1];

	        if (command[0] == "A")
                {
                    string phoneNumber = command[2];
                    phonebook[name] = phoneNumber;
                }
                else
                {
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
