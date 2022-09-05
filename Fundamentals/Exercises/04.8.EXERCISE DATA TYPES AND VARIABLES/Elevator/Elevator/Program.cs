using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPEople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling(numOfPEople / (double)capacity);
            Console.WriteLine(courses);
        }
    }
}
