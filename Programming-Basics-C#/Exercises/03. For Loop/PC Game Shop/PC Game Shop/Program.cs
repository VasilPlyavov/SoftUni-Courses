using System;

namespace PC_Game_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int soldGames = int.Parse(Console.ReadLine());
            int hearthstoneCount = 0;
            int forniteCount = 0;
            int overwatchCount = 0;
            int othersCount = 0;


            for (int i = 0; i < soldGames; i++)
            {
                string name = Console.ReadLine();
                switch (name)
                {
                    case "Hearthstone":hearthstoneCount++;break;
                    case "Fornite":forniteCount++;break;
                    case "Overwatch":overwatchCount++;break;
                    default:othersCount++;break;

                }
            }
            double resultHeart = 1.0 * hearthstoneCount / soldGames * 100;
            double resultFornite = 1.0 * forniteCount / soldGames * 100;
            double resultOverwatch = 1.0 * overwatchCount / soldGames * 100;
            double resultOthers = 1.0 * othersCount / soldGames * 100;
            Console.WriteLine($"Hearthstone - {resultHeart:f2}%");
            Console.WriteLine($"Fornite - {resultFornite:f2}%");
            Console.WriteLine($"Overwatch - {resultOverwatch:f2}%");
            Console.WriteLine($"Others - {resultOthers:f2}%");
        }
    }
}
