using System;

namespace Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());

            double averagesum = 0;
            double wCount = 0;
            double finalpoints = 0;
            double totalaverage = 0;

            for (int i = 1; i <= tournaments; i++)
            {
                string stage = Console.ReadLine();
                switch (stage)
                {
                    case "W": points += 2000; finalpoints = 2000; wCount++; break;
                    case "F": points += 1200; finalpoints = 1200; break;
                    case "SF": points += 720; finalpoints = 720; break;

                }
                averagesum += finalpoints;
                totalaverage = averagesum / tournaments;

            }
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(totalaverage)}");
            Console.WriteLine($"{(1.0 * wCount / tournaments * 100):f2}% ");
        }
    }
}

