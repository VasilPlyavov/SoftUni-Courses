using System;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine().Split()
                .Select(int.Parse).OrderByDescending(i => i).Take(3).ToArray()));
        }
    }
}
