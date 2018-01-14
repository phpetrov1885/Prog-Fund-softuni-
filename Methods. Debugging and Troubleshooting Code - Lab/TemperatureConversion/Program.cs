using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperatureFahrenheit = double.Parse(Console.ReadLine());
            double temperatureCelsius = FromFahrenheitToCelsius(temperatureFahrenheit);
            Console.WriteLine($"{temperatureCelsius:f2}");
        }

        static double FromFahrenheitToCelsius(double temperatureFahrenheit)
        {
            double result = (temperatureFahrenheit - 32) * 5 / 9;
            return result;
        }
    }
}
