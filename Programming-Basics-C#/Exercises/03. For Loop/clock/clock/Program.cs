using System;

namespace clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour <=23; hour++)
            {
                for (int min = 0; min <=59; min++)
                {
                    for (int seconds = 0; seconds <=59; seconds++)
                    {
                        Console.WriteLine($"{hour} : {min} : {seconds}");
                    }
                   
                }
            }
            
        }
    }
}
