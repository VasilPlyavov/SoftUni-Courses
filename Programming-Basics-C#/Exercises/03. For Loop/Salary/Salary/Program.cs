using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tab = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            bool isBancrupt = false;


            for (int i = 0; i < tab; i++)
            {
                string name = Console.ReadLine();
                switch (name)
                {
                    case "Facebook": salary -= 150; break;
                    case "Instagram": salary -= 100; break;
                    case "Reddit": salary -= 50; break;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    isBancrupt = true;
                    break;
                }
               
                
            }
            if (!isBancrupt)
            {
                Console.WriteLine(salary);
            }
            
        }
    }
}
