using System;

namespace dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());
            double detergent = bottles * 750;
            var numofconteiners = " ";
            int conteiners = 0;
            int counter = 0;
            int dishwashed = 0;
            int potswashed = 0;
            while (detergent>=0)
            {
                numofconteiners = (Console.ReadLine());
                if (numofconteiners == "End")
                {
                    break;
                }
                counter++;
                if (counter % 3 == 0)
                {
                    conteiners = int.Parse(numofconteiners);
                    potswashed += conteiners;
                    detergent -= conteiners * 15;

                }
                else
                {
                    conteiners = int.Parse(numofconteiners);
                    potswashed += conteiners;
                    detergent -= conteiners * 55;
                }

                if (detergent < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(detergent)} ml. more necessary!");
                    return;
                }

            }
            Console.WriteLine("Detergent was enough!");
            Console.WriteLine($"{dishwashed} dishes and {potswashed} pots were washed.");
            Console.WriteLine($"Leftover detergent {detergent} ml.");
        }
    }
}
