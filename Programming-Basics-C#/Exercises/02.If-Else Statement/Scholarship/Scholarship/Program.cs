using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averagesucces = double.Parse(Console.ReadLine());
            double minsalary = double.Parse(Console.ReadLine());
            double excellent = (averagesucces * 25);
            double social = (minsalary * 0.35);
            double ex = Math.Floor(excellent);
            double so = Math.Floor(social);
            if (averagesucces >= 5.50)
            {
                if (social > excellent && income < minsalary)
                {
                    Console.WriteLine($"You get a Social scholarship {so} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {ex} BGN");
                }
            }
            else if(averagesucces >= 4.50 && averagesucces <5.50)
                {
                if (income < minsalary)
                {
                    Console.WriteLine($"You get a scholarship {so} BGN");
                }
                else
                {
                    Console.WriteLine($"You cannot get a scholarship!");
                }

            }
            else if(averagesucces<=4.50)
            {
                Console.WriteLine($"You cannot get a scholarship!");
            }
        }
    }
}
