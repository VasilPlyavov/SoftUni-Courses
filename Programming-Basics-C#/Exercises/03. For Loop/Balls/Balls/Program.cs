using System;

namespace Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBalls = int.Parse(Console.ReadLine());
            double pointsfromRed = 0;
            double pointsfromOrange = 0;
            double pointsfromYellow = 0;
            double pointsfromWhite = 0;
            double pointsfromBlack = 0;
            double otherscolors = 0;
            double totalPoints = 0;

            for (int i = 1; i <= numBalls; i++)
            {
                string color = (Console.ReadLine());
                switch (color)
                {
                    case "red":
                        totalPoints += 5;
                        pointsfromRed++; break;
                    case "orange":
                        totalPoints += 10;
                        pointsfromOrange++; break;
                    case "yellow":
                        totalPoints += 15;
                        pointsfromYellow++; break;
                    case "white":
                        totalPoints += 20;
                        pointsfromWhite++; break;
                    case "black":totalPoints /= 2;pointsfromBlack++;break;
                    default: otherscolors++;break;
                        break;
                }
            }
            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Points from red balls: {pointsfromRed}");
            Console.WriteLine($"Points from orange balls: {pointsfromOrange}");
            Console.WriteLine($"Points from yellow balls: {pointsfromYellow}");
            Console.WriteLine($"Points from white balls: {pointsfromWhite}");
            Console.WriteLine($"“Other colors picked: {otherscolors}");
            Console.WriteLine($"Divides from black balls: {pointsfromBlack}");
        }
    }
}
