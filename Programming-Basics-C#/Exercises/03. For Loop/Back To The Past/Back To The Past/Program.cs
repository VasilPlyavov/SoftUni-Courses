using System;

namespace Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritageMoney = double.Parse(Console.ReadLine());
            double yearToLeave = double.Parse(Console.ReadLine());
            int years = 18;
            

            for (int currentYear =1800 ; currentYear <= yearToLeave; currentYear++)
            {
                if (currentYear % 2 == 0)
                {
                    heritageMoney -= 12000;
                }
                else
                {
                    heritageMoney -= (12000 + 50 * years);
                }
                years++;
            }
            if (heritageMoney >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {heritageMoney:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(heritageMoney):f2} dollars to survive.");
            }
           
        }
    }
}
