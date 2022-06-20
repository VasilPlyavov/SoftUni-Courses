using System;

namespace Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSum = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int payCash = 0;
            int payCard = 0;
            int cashCounter = 0;
            int cardCounter = 0;
            int paymentsCounter = 0;

            while (input != "End")
            {
                paymentsCounter++;
                int product = int.Parse(input);
                if (paymentsCounter % 2 != 0 && product <= 100)
                {
                    cashCounter++;
                    totalSum -= product;
                    payCash += product;
                    Console.WriteLine("Product sold!");
                }
                else if (paymentsCounter % 2 == 0 && product >= 100)
                {
                    cardCounter++;
                    totalSum -= product;
                    payCard += product;
                    Console.WriteLine("Product sold!");
                }
                else
                {
                    Console.WriteLine("Error in transaction!");
                }
                if (totalSum <= 0)
                {
                    Console.WriteLine($"Average CS: {(1.0 * payCash / cashCounter):f2}");
                    Console.WriteLine($"Average CC: {(1.0 * payCard / cardCounter):f2}");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
            
        }
    }
}
