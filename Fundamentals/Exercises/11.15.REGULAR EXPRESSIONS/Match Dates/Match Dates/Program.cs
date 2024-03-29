﻿using System;
using System.Text.RegularExpressions;

namespace Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string dates = Console.ReadLine();
            string pattern = @"\b(?<day>\d{2})([-./])(?<month>[A-Z][a-z][a-z])\1(?<year>\d{4})\b"; ;
            MatchCollection matchedDate = Regex.Matches(dates, pattern);
            foreach (Match date in matchedDate)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
