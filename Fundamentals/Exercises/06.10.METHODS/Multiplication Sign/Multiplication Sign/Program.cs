﻿using System;
using System.Linq;

namespace Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int[] array = { a, b, c};
            Console.WriteLine(NegativePositive(array));

        }

        static string NegativePositive(int[] array)
        {
            string result = string.Empty;
            if (array.Any(x => x == 0))
            {
                result = "zero";
            }
           else if (array.All(x=>x>0))
            {
                result = "positive";
            }
            else if (array.Count(x=>x<0)==1 ||array.Count(x=>x<0)==3)
            {
                result = "negative";
            }
            else if (array.Count(x=>x<0)==2)
            {
                result = "positive";
            }
            return result;
        }
    }
}
