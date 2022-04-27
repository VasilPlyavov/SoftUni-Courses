using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = (Console.ReadLine());
            if (type == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double result = side * side;
                Console.WriteLine($"{result:f3}");
            }
            else if (type == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideb = double.Parse(Console.ReadLine());
                double result = sideA * sideb;
                Console.WriteLine($"{result:f3}");
            }
            else if (type == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double result = Math.PI * r * r;
                Console.WriteLine($"{result:f3}");
            }
            else if (type == "triangle")
            {
                double l = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double result = (l * h)/2;
                Console.WriteLine($"{result:f3}");
            }
        }
            
        
    }
}
