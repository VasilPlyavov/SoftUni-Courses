using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputMetric = (Console.ReadLine());
            string outputMetric = (Console.ReadLine());

            if (inputMetric == "mm")
            {
                number = number / 1000;
            }
            else if(inputMetric == "cm")
            {
                number = number / 100;
            }
            else 
            {
                number = number;
            }

            if(outputMetric=="m")
            {
                Console.WriteLine($"{number:F3}");
            }
            else if(outputMetric=="cm")
            {
                Console.WriteLine($"{(number*100):F3}");
            }
            else if(outputMetric =="mm")
            {
                Console.WriteLine($"{(number * 1000):F3}");
            }
           
        }
    }
}
