using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int studentsCounts = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double totalSum = priceOfLightsabers * Math.Ceiling(studentsCounts * 1.1) +
            priceOfRobes * studentsCounts +
            priceOfBelts * (studentsCounts - (studentsCounts / 6));


            if (amountOfMoney>=totalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(totalSum-amountOfMoney):F2}lv more.");
            }
           

        }
    }
}
