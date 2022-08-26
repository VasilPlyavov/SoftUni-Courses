using System;

namespace Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            decimal pound = number * 1.31M;
            
            Console.WriteLine($"{pound:f3}");
        }
    }
}
