using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0;

            if (typeOfGroup == "Students")
            {
                if (day == "Friday")
                {
                    totalPrice = numOfPeople * 8.45;
                }
                else if (day == "Saturday")
                {
                    totalPrice = numOfPeople * 9.80;
                }
                else if (day == "Sunday")
                {
                    totalPrice = numOfPeople * 10.46;
                }
                if (numOfPeople >= 30)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (typeOfGroup == "Business")

            {
                if (numOfPeople >= 100)
                {
                    numOfPeople -= 10;
                }
                if (day == "Friday")
                {
                    totalPrice = numOfPeople * 10.90;
                }
                else if (day == "Saturday")
                {
                    totalPrice = numOfPeople * 15.60;
                }
                else if (day == "Sunday")
                {
                    totalPrice = numOfPeople * 16;
                }
               
            }
            else if (typeOfGroup == "Regular")
            {
                if (day == "Friday")
                {
                    totalPrice = numOfPeople * 15;
                }
                else if(day == "Saturday")
                {
                    totalPrice = numOfPeople * 20;
                }
                else if (day == "Sunday")
                {
                    totalPrice = numOfPeople * 22.50;
                }
                if(numOfPeople>=10 && numOfPeople <= 20)
                {
                    totalPrice *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {(totalPrice):f2}");
        }
    }
}

