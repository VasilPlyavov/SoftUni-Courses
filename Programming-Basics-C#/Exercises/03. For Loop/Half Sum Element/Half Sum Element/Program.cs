﻿using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num;
                }
            }
            int sumwithoutMaxNumber = sum - max ;
            if(max == sumwithoutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
                
            }
            else
            {
                int difference = Math.Abs(max - sumwithoutMaxNumber);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + difference);
            }
            
        }
    }
}
