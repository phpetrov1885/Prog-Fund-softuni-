using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int beatsPerMinutes = int.Parse(Console.ReadLine());
            int numberOfBeats = int.Parse(Console.ReadLine());
           
            double bars = Math.Round(((double)numberOfBeats / 4), 1);

            double beatsPerSecond = (double)beatsPerMinutes / 60;
            double seconds = (int)numberOfBeats / beatsPerSecond;

            var time = TimeSpan.FromSeconds(seconds);

            Console.WriteLine($"{bars} bars - {time.Minutes}m {time.Seconds}s");
        }
    }
}
