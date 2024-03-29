﻿using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string names = Console.ReadLine();
            MatchCollection matches = Regex.Matches(names, pattern);
            foreach (Match name in matches)
            {
                Console.Write(name.Value + " ");
            }
        }
    }
}
