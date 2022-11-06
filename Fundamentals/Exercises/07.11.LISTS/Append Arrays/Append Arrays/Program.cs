using System;
using System.Collections.Generic;
using System.Linq;
namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split("|").ToList();



            items.Reverse();//obryshtane na masiva

            List<string> result = new List<string>();

            foreach (string currentItems in items)
            {
                string[] numbers = currentItems.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach (string numbersToAdd  in numbers )
                {
                    result.Add(numbersToAdd);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
