﻿using System;

namespace Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int biggest = int.MinValue;
            int smallest = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < smallest) smallest = num;
                if (num > biggest) biggest = num;
            }
            Console.WriteLine($"Max number: {biggest}");
            Console.WriteLine($"Min number: {smallest}");
        }
    }
}
