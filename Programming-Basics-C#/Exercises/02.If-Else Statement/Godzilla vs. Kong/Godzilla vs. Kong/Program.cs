using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numStatist = int.Parse(Console.ReadLine());
            double priceForOnestatist = double.Parse(Console.ReadLine());

            double priceForDecor = budget * 0.10;
            double totalPriceForCoats = numStatist * priceForOnestatist;
            
            if(numStatist > 150)
            {
                totalPriceForCoats = totalPriceForCoats * 0.90;

            }
            double totalPrice = priceForDecor + totalPriceForCoats;
            if (budget >= totalPrice)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget - totalPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(totalPrice-budget):f2} leva more.");
            }
        
           
        }
    }
}
