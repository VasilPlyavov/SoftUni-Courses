using System;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana": Console.WriteLine($"{(price = quantity * 2.50):f2}"); break;
                        case "apple": Console.WriteLine($"{(price = quantity * 1.20):f2}"); break;
                        case "orange": Console.WriteLine($"{(price = quantity * 0.85):f2}"); break;
                        case "grapefruit": Console.WriteLine($"{(price = quantity * 1.45):f2}"); break;
                        case "kiwi": Console.WriteLine($"{(price = quantity * 2.70):f2}"); break;
                        case "pineapple": Console.WriteLine($"{(price = quantity * 5.50):f2}"); break;
                        case "grapes":Console.WriteLine($"{(price = quantity * 3.85):f2}"); break;
                            
                        default:
                            Console.WriteLine("error");break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana": Console.WriteLine($"{(price = quantity * 2.70):f2}"); break;
                        case "apple": Console.WriteLine($"{(price = quantity * 1.25):f2}"); break;
                        case "orange": Console.WriteLine($"{(price = quantity * 0.90):f2}"); break;
                        case "grapefruit": Console.WriteLine($"{(price = quantity * 1.60):f2}"); break;
                        case "kiwi": Console.WriteLine($"{(price = quantity * 3.00):f2}"); break;
                        case "pineapple": Console.WriteLine($"{(price = quantity * 5.60):f2}"); break;
                        case "grapes":Console.WriteLine($"{(price = quantity * 4.20):f2}"); break;
                            
                    }
                    break;
                default:
                    Console.WriteLine("error"); break;
            }
            
            
        }
        
    }
}
