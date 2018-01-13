using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long allPictures = long.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int percentageGoodPic = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());


            long usefulPictures = (long)Math.Ceiling(allPictures * (percentageGoodPic / 100.0));


            long uploadingAllPic = (long)allPictures * filterTime;
            long uploadingUsefulPic = (long)usefulPictures * uploadTime;
            long allSecondsNeeded = uploadingUsefulPic + uploadingAllPic;

            var time = TimeSpan.FromSeconds(allSecondsNeeded);

            Console.WriteLine($"{time.Days}:{time.Hours:d2}:{time.Minutes:d2}:{time.Seconds:d2}");
        }
    }
}
