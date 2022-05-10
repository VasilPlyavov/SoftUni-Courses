using System;

namespace Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());
            double commission = 0;
            if (town == "Sofia")
            {
                if (sells >= 0 && sells <= 500) commission = 0.05;
                else if (sells > 500 && sells <= 1000) commission = 0.07;
                else if (sells > 1000 && sells <= 10000) commission = 0.08;
                else if (sells > 10000) commission = 0.12;
            }
            else if (town == "Varna")
            {
                if (sells >= 0 && sells <= 500) commission = 0.045;
                else if (sells > 500 && sells <= 1000) commission = 0.075;
                else if (sells > 1000 && sells <= 10000) commission = 0.1;
                else if (sells > 10000) commission = 0.13;
            }
            else if(town == "Plovdiv")
            {
                if (sells >= 0 && sells <= 500) commission = 0.055;
                else if (sells > 500 && sells <= 1000) commission = 0.08;
                else if (sells > 1000 && sells <= 10000) commission = 0.12;
                else if (sells > 10000) commission = 0.145;
            }

            if (commission > 0)
            {
                commission = sells * commission;
                Console.WriteLine($"{(commission):f2}");
            }
            else
            {
                Console.WriteLine("error");
            }



        }
    }
}
