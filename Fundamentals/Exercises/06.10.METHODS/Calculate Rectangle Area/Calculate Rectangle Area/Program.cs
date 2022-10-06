using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            double area = CalcRectangleArea(width, heigth);
            Console.WriteLine(area);
        }
        static double CalcRectangleArea(double width, double heigth)
        {
            return width* heigth;
        }
    }
}
