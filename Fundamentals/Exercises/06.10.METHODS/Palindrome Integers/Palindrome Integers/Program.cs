﻿using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                int currentNumber = int.Parse(input);
                bool result = IsPalindrome(currentNumber);
                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            int div = 1;
            while (x / div >= 10)
            {
                div *= 10;
            }
            while (x!=0)
            {
                int l = x / div;
                int r = x % 10;
                if (l != r)
                    return false;
                x = (x % div) / 10;
                div /= 100;
            }
            return true;
        }
    }
}
