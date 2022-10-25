using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleChar(input);
        }
        static void PrintMiddleChar(string input)
        {
            char[] charString = input.ToCharArray();
            int charCounter = 0;
            int center = 0;
            for (int i = 0; i < input.Length; i++)
            {
                charCounter++;
            }
            if (charCounter % 2 == 0)
            {
                center = input.Length / 2;
                Console.WriteLine($"{charString[center - 1]}{charString[center]}");
            }
            else
            {
                center = (input.Length + 1) / 2;
                Console.WriteLine($"{charString[center - 1]}");
            }
        }
    }
}
