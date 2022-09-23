using System;
using System.Linq;
namespace Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rigthSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }
                for (int k = i + 1; k < array.Length; k++)
                {
                    rigthSum += array[k];
                }
                if (leftSum == rigthSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
