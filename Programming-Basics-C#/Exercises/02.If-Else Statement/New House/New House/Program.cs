using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlower = Console.ReadLine();
            int countFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double currentPrice = 0;
            double rossesPrice = 5.00;
            double dahliasPrice = 3.80;
            double tulipsPrice = 2.80;
            double narcissusPrice = 3.00;
            double gladiolusPrice = 2.50;

            switch (typeFlower)
            {
              
                case "Roses":currentPrice += (countFlowers * rossesPrice);
                    if(countFlowers> 80)
                    {
                        currentPrice = currentPrice * 0.90;
                    }break;
                case "Dahlias":currentPrice += (countFlowers * dahliasPrice);
                    if(countFlowers> 90)
                    {
                        currentPrice = currentPrice * 0.85;
                    }break;
                case "Tulips":currentPrice +=(countFlowers * tulipsPrice);
                    if(countFlowers > 80)
                    {
                        currentPrice = currentPrice * 0.85;
                    }break;
                case "Narcissus": currentPrice += (countFlowers * narcissusPrice);
                    if(countFlowers< 120)
                    {
                        currentPrice = currentPrice * 1.15;
                    }break;
                case "Gladiolus": currentPrice += (countFlowers * gladiolusPrice);
                    if (countFlowers<80)
                    {
                        currentPrice = currentPrice * 1.20;
                    }break;


            }
            
            if (currentPrice > budget)
            {
                Console.WriteLine($"Not enough money, you need {(currentPrice-budget):f2} leva more.");
            }
            else
            {
                
                Console.WriteLine($"Hey, you have a great garden with {countFlowers} {typeFlower} and {(budget - currentPrice):f2} leva left.");
            }
        }
        

    }
}
