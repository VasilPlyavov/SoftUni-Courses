using System;
using System.Numerics;
namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfSnowball = byte.Parse(Console.ReadLine());
            double highestValue = double.MinValue;
            short highestSnow = 0;
            short highestTime = 0;
            short highestQuality = 0;

            for (int i = 0; i < numberOfSnowball; i++)
            {
                short snowBallSnow = short.Parse(Console.ReadLine());
                short snowBallTime = short.Parse(Console.ReadLine());
                byte snowBallQuality = byte.Parse(Console.ReadLine());

                var snowballValue = Math.Pow((snowBallSnow / snowBallTime), snowBallQuality);
                if (snowballValue > highestValue)
                {
                    highestValue = snowballValue;
                    highestSnow = snowBallSnow;
                    highestTime = snowBallTime;
                    highestQuality = snowBallQuality;

                }
                Console.WriteLine($"{highestSnow} : {highestTime} = {highestValue} ({highestQuality})");

            }
        }
    }
}
