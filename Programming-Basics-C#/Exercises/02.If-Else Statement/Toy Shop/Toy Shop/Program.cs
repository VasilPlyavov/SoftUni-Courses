using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double journey = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int numspeakbarby = int.Parse(Console.ReadLine());
            int numteddybears = int.Parse(Console.ReadLine());
            int numminions = int.Parse(Console.ReadLine());
            int numtrucks = int.Parse(Console.ReadLine());
            double sum = puzzle * 2.60 + numspeakbarby * 3 + numteddybears * 4.10 + numminions * 8.20 + numtrucks * 2;
            double numtoys = puzzle + numspeakbarby + numteddybears + numminions + numtrucks;
            
            if(numtoys>=50)
            {
                sum = sum * 0.75;
            }
            sum = sum * 0.90;
            
            if (sum>=journey)
            {
                double result = sum - journey;
                Console.WriteLine($"Yes! {result:f2} lv left.");
            }
            else
            {
                double result = Math.Abs(sum - journey);
                Console.WriteLine($"Not enough money! {result:f2} lv needed.");
            }
        }
    }
}
