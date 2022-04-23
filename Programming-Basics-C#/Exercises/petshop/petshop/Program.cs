using System;

namespace petshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numdogs = int.Parse(Console.ReadLine());
            int numothersanimals = int.Parse(Console.ReadLine());
            double price = (numdogs*2.50) +(numothersanimals*4) ;
            Console.WriteLine($"{price} lv.");
        }
    }
}
