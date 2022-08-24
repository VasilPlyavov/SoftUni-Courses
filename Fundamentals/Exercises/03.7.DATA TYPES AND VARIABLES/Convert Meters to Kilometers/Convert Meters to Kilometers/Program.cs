using System;

namespace Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal result = n / 1000.0M;
            Console.WriteLine($"{result:f2}");
        }
    }
}
