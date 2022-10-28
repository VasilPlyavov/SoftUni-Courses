using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int result = TheSmallestNum(first, second, third);
            Console.WriteLine(result);
        }
        static int TheSmallestNum(int first, int second, int third)
        {
            return Math.Min(Math.Min(first, second), third);
        }


    }
}
