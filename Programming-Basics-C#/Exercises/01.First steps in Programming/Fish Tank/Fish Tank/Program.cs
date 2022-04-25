using System;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double volume = l * w * h;
            double totalLitres = volume * 0.001;
            double totalPercentage = percentage * 0.01;
            double litresNeeded = totalLitres * (1 - totalPercentage);

            Console.WriteLine(litresNeeded);
        }
    }
}
