using System;

namespace Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = Console.ReadLine();
            string uppercase = example.ToUpper();
            if (example == uppercase)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }

        }
    }
}
