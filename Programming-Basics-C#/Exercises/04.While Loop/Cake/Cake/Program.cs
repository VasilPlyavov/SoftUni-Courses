using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            bool hascake = true;
            int totalpieces = width * length;

            while (hascake)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                int pieces = int.Parse(input);
                totalpieces -= pieces;
                if (totalpieces < 0)
                {
                    hascake = false;
                }
            }
            if (hascake)
            {
                Console.WriteLine($"{totalpieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalpieces)} pieces more.");
            }

        }
    }
}
