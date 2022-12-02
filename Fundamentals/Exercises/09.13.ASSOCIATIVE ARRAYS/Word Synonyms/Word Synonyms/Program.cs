using System;
using System.Collections.Generic;

namespace Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> synonims = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();
                if (!synonims.ContainsKey(word))
                {
                    synonims.Add(word, new List<string>());
                    synonims[word].Add(synonim);
                }
                else
                {
                    synonims[word].Add(synonim);
                }
            }
            foreach (var word in synonims)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
