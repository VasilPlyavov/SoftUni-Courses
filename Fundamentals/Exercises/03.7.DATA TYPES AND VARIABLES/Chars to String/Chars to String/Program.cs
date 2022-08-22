using System;

namespace Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char oneSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            char thirdSymbol = char.Parse(Console.ReadLine());

            Console.WriteLine($"{oneSymbol}{secondSymbol}{thirdSymbol}");
        }
    }
}
