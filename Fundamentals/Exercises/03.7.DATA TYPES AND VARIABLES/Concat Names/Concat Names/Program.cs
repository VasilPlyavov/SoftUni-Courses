using System;

namespace Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delitel = Console.ReadLine();

            Console.WriteLine($"{firstName}{delitel}{secondName}");
        }
    }
}
