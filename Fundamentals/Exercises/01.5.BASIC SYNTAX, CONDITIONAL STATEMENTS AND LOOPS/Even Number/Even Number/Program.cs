using System;

namespace Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber % 2 == 0)
                {
                    Console.WriteLine($"The number is: {currentNumber}");
                }
                else 
                {
                    Console.WriteLine($"Please write an even number.");
                }

            }


        }

    }
}

