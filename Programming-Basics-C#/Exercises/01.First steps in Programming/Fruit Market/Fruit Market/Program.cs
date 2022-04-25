using System;

namespace Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananaskg = double.Parse(Console.ReadLine());
            double orangekg = double.Parse(Console.ReadLine());
            double raspberrykg = double.Parse(Console.ReadLine());
            double strawberrykg = double.Parse(Console.ReadLine());

            double raspberryPrice = strawberryPrice / 2;
            double orangePrice = raspberryPrice - (raspberryPrice * 0.4);
            double bananaPrice = raspberryPrice - (raspberryPrice * 0.8);
            double sumraspberry = raspberrykg * raspberryPrice;
            double sumorange = orangekg * orangePrice;
            double sumbanana = bananaskg * bananaPrice;
            double sumstrawberry = strawberrykg * strawberryPrice;
            double totalPrice = sumraspberry + sumorange + sumbanana + sumstrawberry;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
