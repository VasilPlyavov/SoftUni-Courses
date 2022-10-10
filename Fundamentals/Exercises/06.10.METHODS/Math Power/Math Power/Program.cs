using System;
using System.Text;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {

            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = MakePower(number, power);
            Console.WriteLine(result);
        }

        static double MakePower(double number, int power)
        {
            double powerNumber = 1;

            for (int i = 1; i <= power; i++)
            {
                powerNumber *= number;
            }
            return powerNumber;

        }
        
    }
}
