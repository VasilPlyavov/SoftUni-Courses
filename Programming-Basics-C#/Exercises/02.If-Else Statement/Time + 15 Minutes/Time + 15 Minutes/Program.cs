﻿using System;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine())+15;

            if(minutes >= 60)
            {
                hour = hour + 1;
                minutes = minutes - 60;
            }
             if(hour>=24)
            {
                hour = hour - 24;
            }
             if(minutes<=9)
            {
                Console.WriteLine($"{hour}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minutes}");
            }
            
        }
    }
}
