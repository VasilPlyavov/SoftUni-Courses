using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int result = AddSum(first, second, third) - SubstractSum(first, second, third); ;
            Console.WriteLine(result);

        }
        static int AddSum(int first, int second,int third)
        {
            int result = 0;
            result = first + second;
            return result;
        }
        static int SubstractSum(int first, int second, int third)
        {
            int result = 0;
             result = third - result;
            return result;
        }
    }
}
