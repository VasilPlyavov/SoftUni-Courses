﻿using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float maxVolume = float.MinValue;
            string biggestModel = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                float volume = (float)(Math.PI * Math.Pow(radius, 2) * height);
                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    biggestModel = model;
                }
            }
            Console.WriteLine(biggestModel);
        }
    }
}
