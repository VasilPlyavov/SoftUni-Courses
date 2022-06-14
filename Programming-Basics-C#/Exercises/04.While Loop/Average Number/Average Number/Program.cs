using System;

namespace Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i <n; i++)
            {
                sum+= double.Parse(Console.ReadLine());
                
            }
            double average = sum * 1.0 / n;
            Console.WriteLine($"{(average):f2}");
        }
    }
}
