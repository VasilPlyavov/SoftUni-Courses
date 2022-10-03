using System;

namespace Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] results = new int[n];

            for (int i = 0; i < n; i++)
            {
                double totalSum = 0.00;
                string name = Console.ReadLine();
                double sumVolews = 0.00;
                double sumConsonants = 0.00;

                foreach (char letter in name)
                {
                    switch (letter)
                    {
                        case 'a':
                            sumVolews += letter * name.Length;
                            break;
                        case 'e':
                            sumVolews += letter * name.Length;
                            break;
                        case 'o':
                            sumVolews += letter * name.Length;
                            break;
                        case 'u':
                            sumVolews += letter * name.Length;
                            break;
                        case 'i':
                            sumVolews += letter * name.Length;
                            break;
                        default:
                            sumConsonants += letter / name.Length;
                            break;
                    }
                }
                totalSum += sumVolews + sumConsonants;
                results[i] = (int)totalSum;
            }

            Array.Sort(results);
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}
