using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());
           
            int coins = 0;
            while (change > 0)
            {
                coins++;
                if (change >= 2M)
                {
                    change -= 2;
                }
                else if(change >= 1M)
                {
                    change -= 1;
                }
                else if (change >= 0.50M)
                {
                    change -= 0.50M;
                }
                else if(change >=0.20M)
                {
                    change -= 0.20M;
                }else if (change >= 0.10M)
                {
                    change -= 0.10M;
                }else if (change >= 0.05M)
                {
                    change -= 0.05M;
                }else if (change >= 0.02M)
                {
                    change -= 0.02M;
                }
                else if (change >= 0.01M)
                {
                    change -= 0.01M;
                }
            }
            Console.WriteLine(coins);
        }
    }
}
