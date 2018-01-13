using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int personCount = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int course = 0;

            while (true)
            {
                course++;
                personCount -= elevatorCapacity;
                if (personCount <= 0)
                {
                    break;
                }
            }
            Console.WriteLine(course);
        }
    }
}
