using System;

namespace Easter_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int redCount = 0;
            int orangeCount = 0;
            int blueCount = 0;
            int greenCount = 0;

            for (int i = 0; i <= n; i++)
            {
                string color = (Console.ReadLine());
                switch (color)
                {
                    case "red": redCount++; break;
                    case "orange": orangeCount++; break;
                    case "blue": blueCount++; break;
                    case "green": greenCount++; break;

                }

            }
            int maxEggs = redCount;
            string maxCollor = "red";
            if (orangeCount > maxEggs)
            {
                maxEggs = orangeCount;
                maxCollor = "red";
            }
            if (blueCount > maxEggs)
            {
                maxEggs = blueCount;
                maxCollor = "blue";
            }
            if (greenCount > maxEggs)
            {
                maxEggs = greenCount;
                maxCollor = "green";
            }
            Console.WriteLine($"Red eggs: {redCount}");
            Console.WriteLine($"Orange eggs: {orangeCount}");
            Console.WriteLine($"Blue eggs: {blueCount}");
            Console.WriteLine($"Green eggs: {greenCount}");
            Console.WriteLine($"Max eggs: {maxEggs} -> {maxCollor}");
        }
    }
}
