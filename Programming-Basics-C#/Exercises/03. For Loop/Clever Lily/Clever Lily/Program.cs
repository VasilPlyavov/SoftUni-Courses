using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingmashinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            int toycounter = 0;
            double savedMoney = 0;
            double moneyPresent = 10;


            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += moneyPresent;
                    savedMoney--;
                    moneyPresent += 10;
                }
                else
                {
                    toycounter++;
                }
            }

            double moneyfromtoys = toycounter * toyPrice;
            savedMoney += moneyfromtoys;
            if (savedMoney >= washingmashinePrice)
            {
                Console.WriteLine($"Yes! {savedMoney - washingmashinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingmashinePrice - savedMoney:f2}");
            }
            
        }
    }
}
