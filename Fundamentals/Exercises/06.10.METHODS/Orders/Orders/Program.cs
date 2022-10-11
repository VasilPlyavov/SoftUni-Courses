using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string products = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            //coffee, coke, water, snacks;
            PrintSum(products,quantity);
        }
        static void PrintSum(string products, int quantity)
        {
            
            double totalSum = 0;
            switch (products)
            {
                case "coffee": totalSum += quantity * 1.50; break;
                case "coke": totalSum += quantity * 1.40; break;
                case "water":totalSum += quantity * 1.00;break;
                case "snacks":totalSum += quantity * 2.00;break;
                default:
                    break;
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
