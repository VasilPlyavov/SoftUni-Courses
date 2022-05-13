using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double freeWeekendInSofia = (48 - h) * 3 / 4;
            double numOfGames = freeWeekendInSofia + (p * 2 / 3) + h;
            if(year == "leap")
            {
                numOfGames = numOfGames * 1.15;
            }
            Console.WriteLine($"{Math.Truncate(numOfGames)}");
        }
    }
}
