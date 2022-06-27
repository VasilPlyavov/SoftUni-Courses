using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double target = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int days = 0;
            int spentDays = 0;
            bool isEnough = false;
            while (!isEnough)
            {
                string command = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());
                days++;
                if (command == "save")
                {
                    budget += amount;
                    spentDays = 0;
                }
                else
                {
                    budget -= amount;
                    if (budget < 0)
                    {
                        budget = 0;
                    }
                    spentDays++;
                    if (spentDays >= 5)
                    {
                        break;
                    }
                }
                  if(budget>=target)
                    {
                    isEnough = true;
                   
                    }
            }
            if (isEnough)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
            else
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(days);
            }
           
        }
    }
}
