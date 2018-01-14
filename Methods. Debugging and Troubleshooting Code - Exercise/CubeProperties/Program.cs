using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            double actionResult = 0;

            if (action == "face")
            {
                actionResult = GetFaceDiagonal(cubeSide);
            }
            else if (action == "space")
            {
                actionResult = GetSpaceDiagonal(cubeSide);
            }
            else if (action == "volume")
            {
                actionResult = GetCubeVolume(cubeSide);
            }
            else
            {
                actionResult = 6 * (cubeSide * cubeSide);
            }
            Console.WriteLine($"{actionResult:f2}");
        }

        private static double GetCubeVolume(double cubeSide)
        {
            double cubeVolume = cubeSide * cubeSide * cubeSide;
            return cubeVolume;
        }

        private static double GetSpaceDiagonal(double cubeSide)
        {
            double spaceDiagonal = Math.Sqrt((cubeSide * cubeSide) + (cubeSide * cubeSide) + (cubeSide * cubeSide));
            return spaceDiagonal;
        }

        private static double GetFaceDiagonal(double cubeSide)
        {
            double faceDiagonalResult = Math.Sqrt((cubeSide * cubeSide) + (cubeSide * cubeSide));
            return faceDiagonalResult;
        }
    }
}
}
