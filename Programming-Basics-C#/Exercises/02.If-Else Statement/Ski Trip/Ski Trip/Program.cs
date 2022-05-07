using System;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string grade = Console.ReadLine();
            double result = 0;

            switch (type)
            {
                case "room for one person":result = (day - 1) * 18.00;break;
                case "apartment": result = (day - 1) * 25.00;
                    if (day < 10)
                    {
                        result = result * 0.70;
                    }
                    else if(day >= 10 && day <= 15 )
                    {
                        result = result * 0.65;
                    }
                    else
                    {
                        result = result * 0.50;

                    }break;
                case "president apartment": result = (day - 1) * 35.00;
                    if (day < 10)
                    {
                        result = result * 0.90;
                    }
                    else if(day>=10 && day <= 15)
                    {
                        result = result * 0.85;
                    }
                    else
                    {
                        result = result * 0.80;
                    }break;
            }
            if (grade == "positive")
            {
                result = result * 1.25;
            }
            else
            {
                result = result * 0.90;
            }
            Console.WriteLine($"{(result):f2}");
        }
    }
}
