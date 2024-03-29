﻿using System;
using System.Text;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine().Split(", ");
            StringBuilder text = new StringBuilder();
            text.Append(Console.ReadLine());
            foreach (var word in banWords)
            {
                while (text.ToString().Contains(word))
                {
                    text.Replace(word, new string('*', word.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
