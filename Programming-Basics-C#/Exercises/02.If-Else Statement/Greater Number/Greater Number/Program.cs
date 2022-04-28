using System;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            if(first>second)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
            
        }
    }
}
