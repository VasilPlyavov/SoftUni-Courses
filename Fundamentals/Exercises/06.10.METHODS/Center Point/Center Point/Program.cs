using System;

namespace Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double xA = double.Parse(Console.ReadLine());
            double yA = double.Parse(Console.ReadLine());
            double xB = double.Parse(Console.ReadLine());
            double yB = double.Parse(Console.ReadLine());

            PrintClosestPointToCenter(xA, yA, xB, yB);
        }

        static void PrintClosestPointToCenter(double xA, double yA, double xB, double yB)
        {
            double distanceA = Math.Sqrt((xA * xA) + (yA * yA)) / 2;
            double distanceB = Math.Sqrt((xB * xB) + (yB * yB)) / 2;

            if (distanceA <= distanceB)
            {
                Console.WriteLine($"({xA}, {yA})");
            }
            else
            {
                Console.WriteLine($"({xB}, {yB})");
            }

        }
            
    }
}
