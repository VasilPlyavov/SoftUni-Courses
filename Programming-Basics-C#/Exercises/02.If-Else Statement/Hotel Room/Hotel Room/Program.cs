using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string months = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPrice = 0;


            switch (months)
            {
                case "May":
                case "October":
                    if (nights <= 7)
                    {
                        studioPrice = nights * 50;
                        apartmentPrice = nights * 65;
                    }
                    else if (nights > 7 && nights <= 12)
                    {
                        studioPrice = nights * 50 * 0.95;
                        apartmentPrice = nights * 65;
                    }
                    else if (nights > 14)
                    {
                        studioPrice = nights * 50 * 0.70;
                        apartmentPrice = nights * 65 * 0.90;
                    }
                    break;
                case "June":
                case "September":
                    if (nights <= 14)
                    {
                        studioPrice = nights * 75.20;
                        apartmentPrice = nights * 68.70;
                    }
                    else if (nights > 14)
                    {
                        studioPrice = nights * 75.20 * 0.80;
                        apartmentPrice = nights * 68.70 * 0.90;
                    }
                    break;
                case "July":
                case "August":
                    if (nights <= 14)
                    {
                        studioPrice = nights * 76 ;
                        apartmentPrice = nights * 77 ;
                    }
                    else if (nights > 14)
                    {
                        studioPrice = nights * 76;
                        apartmentPrice = nights * 77 * 0.90;
                    }break;
            }
            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
