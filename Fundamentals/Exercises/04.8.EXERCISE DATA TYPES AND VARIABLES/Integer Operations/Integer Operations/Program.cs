using System;

namespace Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            int secondSum = firstNumber + secondNumber;
            int thirdSum = secondSum / thirdNumber;
            int fourtSum = thirdSum * fourthNumber;
            Console.WriteLine(fourtSum);
        }
    }
}
