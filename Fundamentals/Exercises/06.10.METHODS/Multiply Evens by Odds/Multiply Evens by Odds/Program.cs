using System;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Math.Abs(int.Parse(Console.ReadLine()));
            int evenSum = GetSumOfEvenDigits(input);
            int oddSum = GetSumOfOddDigits(input);
            int result = GetMultipleOfEvenAndOdd(evenSum,oddSum);
            Console.WriteLine(result);
        }
        static int GetSumOfEvenDigits(int input)
        {
            int evenSum = 0;
            while (input > 0)
            {
                if (input % 2 == 0)
                {
                    evenSum += input % 10;
                }
                input /= 10;
            }
            return evenSum;
        }
        static int GetSumOfOddDigits(int input)
        {
            int oddSum = 0;
            while (input > 0)
            {
                if (input % 2 != 0)
                {
                    oddSum += input % 10;
                }
                input /= 10;
            }
            return oddSum;
        }
        private static int GetMultipleOfEvenAndOdd(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }
    }
}
