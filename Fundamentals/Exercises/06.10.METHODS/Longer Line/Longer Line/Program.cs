using System;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            LongestLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void LongestLine(double a, double b, double c, double d, double e, double f, double g, double k)
        {
            double firstLine = Math.Sqrt(Math.Pow(Math.Abs(a - c), 2) + Math.Pow(Math.Abs(b - d), 2));
            double secondLine = Math.Sqrt(Math.Pow(Math.Abs(e - g), 2) + Math.Pow(Math.Abs(f - k), 2));

            if (firstLine >= secondLine)
            {
                ClosesToZero(a, b, c, d);
            }
            else
            {
                ClosesToZero(e, f, g, k);
            }

        }

        static void ClosesToZero(double a, double b, double c, double d)
        {
            double first = Math.Sqrt(Math.Pow(Math.Abs(a), 2) + Math.Pow(Math.Abs(b), 2));
            double second = Math.Sqrt(Math.Pow(Math.Abs(c), 2) + Math.Pow(Math.Abs(d), 2));

            if (first > second)
            {
                Console.WriteLine($"({c}, {d})({a}, {b})");
            }
            else
            {
                Console.WriteLine($"({a}, {b})({c}, {d})");
            }       

        }
    }
}
