using System;

namespace Back_in_30_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            double hour = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine()) + 30 ;

            if (hour >= 23)
            {
                hour = 0;
                minutes = minutes - 60;
                
            }
            if (minutes > 59)
            {
               
                hour++;
                minutes -= 60;
            }
            
            if (minutes <= 9)
            {
                Console.WriteLine($"{hour}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minutes}");
            }
            
        }
    }
}
