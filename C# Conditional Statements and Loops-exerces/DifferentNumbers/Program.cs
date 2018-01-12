using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (secondNum - firstNum >= 5)
            {
                for (int firstIndex = firstNum; firstIndex <= secondNum; firstIndex++)
                {
                    for (int secondIndex = firstIndex + 1; secondIndex <= secondNum; secondIndex++)
                    {
                        for (int thIndex = secondIndex + 1; thIndex <= secondNum; thIndex++)
                        {
                            for (int foIndex = thIndex + 1; foIndex <= secondNum; foIndex++)
                            {
                                for (int forthIndex = foIndex + 1; forthIndex <= secondNum; forthIndex++)
                                {
                                    if (firstIndex < secondIndex || secondIndex < thIndex ||
                                        thIndex < foIndex || foIndex <= forthIndex)
                                    {
                                        Console.WriteLine($"{firstIndex} {secondIndex} {thIndex} {foIndex} {forthIndex}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
