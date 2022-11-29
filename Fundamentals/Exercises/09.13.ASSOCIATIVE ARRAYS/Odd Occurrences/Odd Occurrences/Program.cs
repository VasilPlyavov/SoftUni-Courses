using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();


            for (int i = 0; i < words.Length; i++)
            {
                if (!counts.ContainsKey(words[i]))
                {
                    counts.Add(words[i], 1);
                    continue;
                }

                counts[words[i]]++;
            }
            Console.WriteLine(string.Join(" ", counts.Where(v => v.Value % 2 != 0).Select(v => v.Key)));
        }



    }

}
    

