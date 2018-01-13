using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int century = int.Parse(Console.ReadLine());

            int years = century * 100;
            decimal days = years * 365.2422m;
            days = Math.Floor(days);
            long hours = (int)days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliSeconds = seconds * 1000;
            long microSeconds = milliSeconds * 1000;

            BigInteger nanoSeconds = new BigInteger(microSeconds);
            nanoSeconds = nanoSeconds * 1000;

            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = " +
                              $"{seconds} seconds = {milliSeconds} milliseconds" +
                              $" = {microSeconds} microseconds = {nanoSeconds} nanoseconds");
        }
    }
}
