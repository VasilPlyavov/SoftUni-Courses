using System;

namespace Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int numdays = int.Parse(Console.ReadLine());
            int numbakers = int.Parse(Console.ReadLine());
            int numcakes = int.Parse(Console.ReadLine());
            int numgofrets = int.Parse(Console.ReadLine());
            int numpancakes = int.Parse(Console.ReadLine());
            double cake = numcakes * 45;
            double gofrets = numgofrets * 5.80;
            double pancakes = numpancakes * 3.20;

            double totalForOneDay = (cake + gofrets + pancakes)*numbakers;
            double totalsum = totalForOneDay * numdays;
            double afterTax = totalsum -(totalsum/ 8);
            Console.WriteLine(afterTax);
        }
    }
}
