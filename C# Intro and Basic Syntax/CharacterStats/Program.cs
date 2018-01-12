using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string heroName = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());


            string health = new string('|', currentHealth) +
                            new string('.', maxHealth - currentHealth);
            string energy = new string('|', currentEnergy) +
                            new string('.', maxEnergy - currentEnergy);

            Console.WriteLine($"Name: {heroName}");
            Console.WriteLine("Health: " + '|' + health + '|');
            Console.WriteLine("Energy: " + '|' + energy + '|');
        }
    }
}
