using System;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftsum = 0;
            int rightsum = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                leftsum += number;
                sum = leftsum +rightsum;

            }
            for (int i = 0; i <n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                rightsum += numbers;
            }
            if(leftsum == rightsum )
            {
                
                Console.WriteLine("Yes, sum = " + leftsum);
            }
            else
            {
                double difference = Math.Abs(rightsum - leftsum);
                Console.WriteLine("No, diff = " + difference);
            }
           
        }
    }
}
