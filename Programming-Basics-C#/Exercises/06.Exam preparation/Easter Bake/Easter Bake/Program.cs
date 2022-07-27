using System;

namespace Easter_Bake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sugarCount = 0;
            double flourCount = 0;
            double neededSugar = 0;
            double neededFlour = 0;
            double maxsugar = 0;
            double maxflour = 0;
            for (int i = 1; i <= n; i++)
            {
                double sugarQuantity = double.Parse(Console.ReadLine());
                double flourQuantity = double.Parse(Console.ReadLine());
                neededSugar += sugarQuantity;//общо нужна захар
                
                neededFlour += flourQuantity;//общо нужно брашно
               
                if (sugarQuantity > maxsugar)
                {
                    maxsugar = sugarQuantity;
                }
                if (flourQuantity > maxflour)
                {
                    maxflour = flourQuantity;
                }
                sugarQuantity++;
                flourQuantity++;
            }
            
            double numPackageSugar = neededSugar / 950;
            double numPackageFlour = neededFlour / 750;
            Console.WriteLine($"Sugar: {Math.Ceiling(numPackageSugar)}");
            Console.WriteLine($"Flour: {Math.Ceiling(numPackageFlour)}");
            Console.WriteLine($"Max used flour is {maxflour} grams, max used sugar is {maxsugar} grams.");
        }
    }
}
