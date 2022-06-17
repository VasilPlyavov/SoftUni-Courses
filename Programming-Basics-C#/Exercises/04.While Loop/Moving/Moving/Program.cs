using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());

            int volume = width * length * hight;
            bool hasVolume = true;

            string command = Console.ReadLine();

            while (command != "Done")
            { 
                int box = int.Parse(command);
                volume -= box;
                if (volume < 0)
                {
                    hasVolume = false;
                    break;
                }
                command = Console.ReadLine();
            }
            if (hasVolume)
            {
                Console.WriteLine($"{volume} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
            }
        }
    }
}
