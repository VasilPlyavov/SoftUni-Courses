using System;

namespace Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            double v =0;
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            v = (length + width + heigth) / 3;
            Console.WriteLine($"Length:{length}");
           
            Console.WriteLine($"Width:{width}");
            
            Console.WriteLine($"Heigth:{heigth}");
           
            Console.WriteLine($"Pyramid Volume: {v:f2}");
        }
    }
}
