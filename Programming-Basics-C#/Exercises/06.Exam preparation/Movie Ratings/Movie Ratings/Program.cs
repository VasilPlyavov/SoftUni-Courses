using System;

namespace Movie_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string name = "";
            double raiting = 0;
            double minRaiting = double.MaxValue;
            string movieMaxRaiting = "";
            double maxRaiting = double.MinValue;
            string movieMinRaiting = "";
            double average = 0;


            for (int i = 0; i < n; i++)
            {
                name = Console.ReadLine();
                raiting = double.Parse(Console.ReadLine());

                if (raiting > maxRaiting)
                {
                    maxRaiting = raiting;
                    movieMaxRaiting = name;
                }
                if (raiting < minRaiting)
                {
                    minRaiting = raiting;
                    movieMinRaiting = name;
                }
                average += raiting;
            }
            Console.WriteLine($"{movieMaxRaiting} is with highest rating: {maxRaiting:f1}");
            Console.WriteLine($"{movieMinRaiting} is with lowest rating: {minRaiting:f1}");
            Console.WriteLine($"Average rating: {average / n:f1}");
        }
    }
}
