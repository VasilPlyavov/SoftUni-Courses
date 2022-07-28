using System;

namespace Fitness_Center
{
    class Program
    {
        static void Main(string[] args)
        {
            // ("Back", "Chest", 'Legs", "Abs"
            //"Protein shake" или "Protein bar
            int numVisitors = int.Parse(Console.ReadLine());
            int backCounter = 0;
            int chestCounter = 0;
            int legsCounter = 0;
            int absCounter = 0;
            int proteinshakeCounter = 0;
            int proteinbarCounter = 0;

            for (int i = 0; i < numVisitors; i++)
            {
                string type = Console.ReadLine();
                switch (type)
                {
                    case "Back": backCounter++; break;
                    case "Chest": chestCounter++; break;
                    case "Legs": legsCounter++; break;
                    case "Abs": absCounter++; break;
                    case "Protein shake": proteinshakeCounter++; break;
                    case "Protein bar": proteinbarCounter++; break;
                }
                
            }
            int totaltrained = backCounter + chestCounter + legsCounter + absCounter;//pehat trenirashti
            double trainedPeople = 1.0 * totaltrained / numVisitors * 100;//pechat 60%
            double proteinPeople = proteinshakeCounter + proteinbarCounter;//hora kupili protein
            double percentageproteinPeople = 1.0 * proteinPeople / numVisitors * 100;//kupili protein

            Console.WriteLine($"{backCounter} - back");
            Console.WriteLine($"{chestCounter} - chest");
            Console.WriteLine($"{legsCounter} - legs");
            Console.WriteLine($"{absCounter} - abs");
            Console.WriteLine($"{proteinshakeCounter} - protein shake");
            Console.WriteLine($"{proteinbarCounter} - protein bar");
            Console.WriteLine($"{(trainedPeople):f2}% - work out");
            Console.WriteLine($"{(percentageproteinPeople):f2}% - protein");

        }
    }
}
