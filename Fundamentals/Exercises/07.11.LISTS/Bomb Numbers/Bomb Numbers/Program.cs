using System;
using System.Collections.Generic;
using System.Linq;
namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombData = Console.ReadLine().Split().Select(int.Parse).ToArray();
            // 1 2 2 4 2 2 2 9 const nqma da se promenq glaven
            // 0 1 2 3 4 5 6 7
            //4 2
            int specialBombNumber = bombData[0];//nomera na bombata 4
            int power = bombData[1];//silata na bombata //2

            int bombIndex = list.IndexOf(specialBombNumber);
            while (bombIndex != -1)
            {
                int leftNumbers = bombIndex - power;//kak da vzemem levite indexi ot bombata
                int rigthNumbers = bombIndex + power;//vzimane na desnte indexi 

                //proverka dali ima dostatychno indexi ot dvete strani
                if (leftNumbers<0)
                {
                    leftNumbers = 0;
                }
                if (rigthNumbers > list.Count - 1)
                {
                    rigthNumbers = list.Count - 1;
                }


                list.RemoveRange(leftNumbers, rigthNumbers - leftNumbers + 1);
                bombIndex = list.IndexOf(specialBombNumber);
            }
            int sum = 0;
            foreach (var item in list)//sumirane na polucheniq rezultat
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
