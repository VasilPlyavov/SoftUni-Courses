﻿using System;
using System.Linq;

namespace Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumbers = numbers[i];
                if (currentNumbers % 2 == 0)
                {
                    evenSum += currentNumbers;
                }
                else
                {
                    oddSum += currentNumbers;
                }
            }

            
            Console.WriteLine($"{evenSum - oddSum}");
        }
    }
}
