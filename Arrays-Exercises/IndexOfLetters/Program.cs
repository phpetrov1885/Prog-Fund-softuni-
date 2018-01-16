namespace _06.Batteries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IndexOfLetters
    {
        public static void Main()
        {

            char[] alphabetArray = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
	    char[] inputArray = Console.ReadLine().ToCharArray();

            char matchingElement = ' ';
            int indexOfElement = 0;


            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < alphabetArray.Length; j++)
                {
                    if (inputArray[i] == alphabetArray[j])
                    {
                        matchingElement = alphabetArray[j];
                        indexOfElement = j;
                    }
                }
                Console.WriteLine($"{matchingElement} -> {indexOfElement}");
            }
        }
    }
}