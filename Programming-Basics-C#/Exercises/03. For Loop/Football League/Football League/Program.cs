using System;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            double fans = double.Parse(Console.ReadLine());
            double fansA = 0;
            double fansB = 0;
            double fansV = 0;
            double fansG = 0;
          
            for (int i = 1; i <= fans; i++)
            {
                string sector = Console.ReadLine();
                switch (sector)
                {
                    case "A": fansA++; break;
                    case "B": fansB++; break;
                    case "V": fansV++; break;
                    case "G": fansG++; break;
                }
               
            }
            double percentageA = (fansA / fans) * 100;
            double percentageB = (fansB / fans) * 100; 
            double percentageV = (fansV / fans) * 100;
            double percentageG = (fansG / fans) * 100;
            double v = fans / capacity * 100.00;
            double percentageStad = v;
            Console.WriteLine($"{percentageA:f2}%");
            Console.WriteLine($"{percentageB:f2}%");
            Console.WriteLine($"{percentageV:f2}%");
            Console.WriteLine($"{percentageG:f2}%");
            Console.WriteLine($"{percentageStad:f2}%");

        }
    }
}
