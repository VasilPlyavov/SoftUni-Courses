using System;
using System.Linq;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] array1 = new int[array.Length / 2];
            int[] array2 = new int[array.Length / 2];
            int n = 0;
            for (int i = array.Length/4-1; i >= 0; i--)
            {
                array1[n] = array[i];
                n++;
            }
            n = array.Length / 2 - 1;
                for (int i = array.Length-array.Length/4; i <array.Length ; i++)
            {
                array1[n] = array[i];
                n--;
            }
            n = 0;
            int start = array.Length / 4;
            int end = array.Length - array.Length / 4;
            for (int i = start; i < end; i++)
            {
                array2[n] = array[i];
                n++;
            }
            int[] sum = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                sum[i] = array1[i] + array2[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
