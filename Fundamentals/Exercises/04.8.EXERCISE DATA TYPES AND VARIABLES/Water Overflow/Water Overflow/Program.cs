using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalLitres = 0;
            for (int i = 0; i < n; i++)
            {
                int litres = int.Parse(Console.ReadLine());
                if (totalLitres + litres > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    totalLitres += litres;

                }
            }
            Console.WriteLine($"{totalLitres}");
        }
    }
}
