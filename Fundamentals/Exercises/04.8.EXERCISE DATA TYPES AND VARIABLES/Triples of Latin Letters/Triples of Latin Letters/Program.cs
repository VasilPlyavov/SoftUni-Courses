﻿using System;

namespace Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        char firstNum = (char)('a' + i);
                        char secondNum = (char)('a' + j);
                        char thirdNum = (char)('a' + k);

                        Console.WriteLine($"{firstNum}{secondNum}{thirdNum}");
                    }
                }
            }
           
        }
    }
}
