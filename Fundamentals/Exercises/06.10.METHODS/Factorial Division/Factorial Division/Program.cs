using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstFactorial = int.Parse(Console.ReadLine());
            int secondFactorial = int.Parse(Console.ReadLine());
            double factorialFirst = GetFactorial(firstFactorial);
            double factorialSecond = GetFactorial(secondFactorial);
            double result = factorialFirst / factorialSecond;
            Console.WriteLine($"{result:f2}");
        }

        private static double GetFactorial(int first)
        {
            double result = 1;
            while (first != 1)
            {
                result = result * first;
                first = first - 1;
            }
            return result;
        }
    }
}
