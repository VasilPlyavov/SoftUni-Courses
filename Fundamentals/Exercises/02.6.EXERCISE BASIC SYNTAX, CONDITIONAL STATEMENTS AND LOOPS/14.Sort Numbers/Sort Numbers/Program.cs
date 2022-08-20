using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a == b && b == c && c == a)
            {
               
                Console.Write("{0} {1} {2} ", a, b, c);
               
            }
            else
            {
                if ((a > b && b > c) || (a == b && b > c) || (a > b && b == c))
                {
                    
                    Console.WriteLine($"{a}, {b}, {c}");
                    Console.WriteLine();
                }
                if ((b > a && a > c) || (b == a && a > c) || (b > a && a == c))
                {
                    
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                    Console.WriteLine();
                }
                if ((c > b && b > a) || (c == b && b > a) || (c > b && b == a))
                {
                    
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                    Console.WriteLine();
                }
                if ((c > a && a > b) || (c == a && a > b))
                {
                    
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                    Console.WriteLine();
                }
                if ((b > c && c > a) || (b == c && c > a))
                {
                    
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                    Console.WriteLine();
                }
                if ((a > c && c > b) || (a == c && c > b))
                {
                    
                    Console.Write("{0} {1} {2}", a, c, b);
                    Console.WriteLine();

                }
            }
        }
    }

}
