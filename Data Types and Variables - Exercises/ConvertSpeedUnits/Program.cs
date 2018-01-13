using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            double totalSeconds = (hours * 3600f) + (minutes * 60f) + seconds;
            double metersPerSecond = distance / totalSeconds;
            double kilometersPerHour = (distance / 1000) / (totalSeconds / 3600);
            double milesPerHour = kilometersPerHour / 1.609;

            Console.WriteLine($"{(float)metersPerSecond}");
            Console.WriteLine($"{(float)kilometersPerHour}");
            Console.WriteLine($"{(float)milesPerHour}");
        }
    }
}
