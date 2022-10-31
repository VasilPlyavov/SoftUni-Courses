using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            ReturnVowelsCount(input);

        }
        static void ReturnVowelsCount(string input)
        {
            int vowelCounter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a': vowelCounter++; break;
                    case 'e': vowelCounter++; break;
                    case 'o': vowelCounter++; break;
                    case 'i': vowelCounter++; break;
                    case 'u': vowelCounter++; break;
                    default: break;
                }
            }
            Console.WriteLine(vowelCounter);

        }

    }
}
