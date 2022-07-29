using System;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numSerial = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            double price = 0;
            string name = "";
            for (int i = 1; i <= numSerial; i++)
            {
                name = Console.ReadLine();
                price = double.Parse(Console.ReadLine());

                if (name == "Thrones")
                {
                    price = price * 0.50;

                }
                if (name == "Lucifer")
                {
                    price = price * 0.60;

                }
                if (name == "Protector")
                {
                    price = price * 0.70;

                }
                if (name == "TotalDrama")
                {
                    price = price * 0.80;

                }
                if (name == "Area")
                {
                    price = price * 0.90;

                }
                else
                {
                    price = price;

                }

                totalPrice += price;

            }
            if (budget >= totalPrice)
            {
                Console.WriteLine($"You bought all the series and left with {(budget - totalPrice):f2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {Math.Abs(budget - totalPrice):f2} lv. more to buy the series!");
            }

        }
    }
}
