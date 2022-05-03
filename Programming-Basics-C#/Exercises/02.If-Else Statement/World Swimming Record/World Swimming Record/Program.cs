using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeinSeconds = double.Parse(Console.ReadLine());

            double target = distance * timeinSeconds;
            double delay = Math.Floor(distance / 15) * 12.5;
            double totalTime = target + delay;
            if(totalTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
                
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(totalTime - record):f2} seconds slower.");
            }
        }
            
        
    }
}
