using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLoads = int.Parse(Console.ReadLine());
            double bus = 200;
            double truck = 175;
            double train = 120;
            double busCount = 0;
            double truckCount = 0;
            double trainCount = 0;
            double allTons = 0;
            for (int i = 1; i <= numLoads; i++)
            {
                int loadsSum = int.Parse(Console.ReadLine());
                allTons += loadsSum;

                if (loadsSum <= 3)
                {
                    busCount += loadsSum;
                }
                else if (loadsSum <= 11)
                {
                    truckCount += loadsSum;
                }
                else
                {
                    trainCount += loadsSum;
                }
            }
            double averagePrice = ((busCount * bus) + (truckCount * truck) + (trainCount * train)) / allTons;
            double busPrice = (busCount / allTons * 100);
            double truckPrice = (truckCount / allTons * 100);
            double trainPrice = (trainCount / allTons * 100);

            Console.WriteLine($"{(averagePrice):F2}");
            Console.WriteLine($"{(busPrice):F2}%");
            Console.WriteLine($"{(truckPrice):F2}%");
            Console.WriteLine($"{(trainPrice):F2}%");

        }
    }
}
