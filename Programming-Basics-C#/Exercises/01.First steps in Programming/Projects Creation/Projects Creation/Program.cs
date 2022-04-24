using System;

namespace ArchitectProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());

            int hours = 3;
            int totalTime = hours * projects;

            Console.WriteLine("The architect " + name + " will need " + totalTime + " hours to complete " + projects + " project/s.");
        }
    }
}