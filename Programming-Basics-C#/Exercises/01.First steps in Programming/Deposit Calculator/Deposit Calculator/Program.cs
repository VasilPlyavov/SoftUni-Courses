using System;

namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

         
            double sum = deposit + months *((deposit*percentage/100)/12);
            Console.WriteLine(sum);
        }
    }
}
