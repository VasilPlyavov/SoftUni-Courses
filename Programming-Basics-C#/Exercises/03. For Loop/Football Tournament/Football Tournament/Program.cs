using System;

namespace Football_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string footballName = (Console.ReadLine());
            int playedGames = int.Parse(Console.ReadLine());
            double wCount = 0;
            double dCount = 0;
            double lCount = 0;
            double totalSum = 0;

            if (playedGames == 0)
            {
                Console.WriteLine($"{footballName} hasn't played any games during this season.");
            }
            else
            {
                for (int i = 1; i <= playedGames; i++)
                {
                    string result = Console.ReadLine();

                    switch (result)
                    {
                        case "W":
                            wCount++;
                            totalSum += 3;
                            break;
                        case "D":
                            dCount++;
                            totalSum += 1;
                            break;
                        case "L":
                            lCount++;
                            break;

                    }
                }
                double percentage = wCount / playedGames * 100;
                Console.WriteLine($"{footballName} has won {totalSum} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {wCount}");
                Console.WriteLine($"## D: {dCount}");
                Console.WriteLine($"## L: {lCount}");
                Console.WriteLine($"Win rate: {percentage:f2}%");
            }
           
        }
    }
}
