using System;

namespace Encrypt__Sort_and_Print_Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int[] sums = new int[numbers];
            for (int i = 0; i < numbers; i++)
            {
                string inputString = Console.ReadLine();
                sums[i] = sumVowelsConsonants(inputString);
            }
            Array.Sort(sums);
            foreach (var item in sums)
            {
                Console.WriteLine(item);
            }
        }
         static int sumVowelsConsonants(string text)
        {
            int sum = 0;
            foreach (char element in text)
            {
                if (element=='a' || element=='A' || element=='e'|| element=='E' ||
                    element=='i'|| element=='I' || element=='u' || element=='U'
                    || element=='o' || element=='O')
                {
                    sum += (int)element * text.Length;
                }
                else
                {
                    sum += (int)element / text.Length;
                }
            }
            return sum;
        }
    }
}
