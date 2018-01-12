using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNASequences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> letters = new List<char> { 'A', 'C', 'G', 'T' };
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < letters.Count; i++)
            {
                for (int j = 0; j < letters.Count; j++)
                {
                    for (int k = 0; k < letters.Count; k++)
                    {
                        string DNA = $"{letters[i]}{letters[j]}{letters[k]} ";
                        int sum = (i + 1) + (j + 1) + (k + 1);

                        if (sum >= input)
                        {
                            DNA = $"O{letters[i]}{letters[j]}{letters[k]}O ";
                        }
                        else
                        {
                            DNA = $"X{letters[i]}{letters[j]}{letters[k]}X ";
                        }
                        Console.Write(DNA);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

