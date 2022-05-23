using System;

namespace Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int move = int.Parse(Console.ReadLine());
            int from0to9 = 0;
            int from10to20 = 0;
            int from20to29 = 0;
            int from30to39 = 0;
            int from40to50 = 0;
            int invalidNum = 0;
            double totalResult = 0;


            for (int i = 1; i <= move; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num >= 0 && num <= 50)
                {
                    if (num <10)
                    {
                        num = num * 0.20;
                        from0to9++;
                    }
                    else if (num < 20)
                    {
                        num = num * 0.30;
                        from10to20++;
                        
                    }
                    else if (num < 30)
                    {
                        num = num * 0.40;
                        from20to29++;
                        
                    }
                    else if (num < 40)
                    {
                        num = 50.0;
                        from30to39++;
                        
                    }
                    else 
                    {
                        from40to50++;
                        num = 100.0;
                    }
                    totalResult += num;
                }
                else
                {
                    totalResult /= 2;
                    invalidNum++;
                   
                }
            }
            Console.WriteLine($"{totalResult:f2}");
            Console.WriteLine($"From 0 to 9: {(from0to9 * 1.0/move* 100):f2}%");
            Console.WriteLine($"From 10 to 19: {(from10to20 * 1.0 / move * 100):f2}%");
            Console.WriteLine($"From 20 to 29: {(from20to29 * 1.0 / move * 100):f2}%");
            Console.WriteLine($"From 30 to 39: {(from30to39 * 1.0 / move * 100):f2}%");
            Console.WriteLine($"From 40 to 50: {(from40to50 * 1.0 / move * 100):f2}%");
            Console.WriteLine($"Invalid numbers: {(invalidNum * 1.0 / move * 100):f2}%");
        }
    }
}
