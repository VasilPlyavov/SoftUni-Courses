using System;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddsum = 0;
            int evensum = 0;
          
            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evensum += current;
                }
                else if (i % 2 != 0)
                {
                    oddsum += current;

                }

            }
            if (evensum == oddsum)
            {
                
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evensum);
            }
            else
            {
                int difference = Math.Abs(oddsum - evensum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + difference);
            }


        }

    }
}

