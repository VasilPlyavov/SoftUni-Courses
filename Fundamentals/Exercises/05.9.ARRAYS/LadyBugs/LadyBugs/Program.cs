using System;
using System.Linq;
namespace LadyBugs
{
    class Program
    {
        static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());//3

            int[] initialIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();//01

            int[] field = new int[fieldSize];//0 0 0

            for (int i = 0; i < initialIndexes.Length; i++)
            {
                int currentIndex = initialIndexes[i];
                if (currentIndex >= 0 && currentIndex < field.Length)
                {
                    field[currentIndex] = 1;
                }

            }
            string command = String.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] elements = command.Split();//0 rigth 1
                int ladyBugIndex = int.Parse(elements[0]);
                string direction = elements[1];
                int flyLength = int.Parse(elements[2]);
                if (ladyBugIndex < 0 || ladyBugIndex > field.Length-1 || field[ladyBugIndex] == 0)
                {
                    continue;
                }

                field[ladyBugIndex] = 0;
                if (direction =="rigth")
                {
                    int landIndex = ladyBugIndex + flyLength;
                    if (landIndex>field.Length-1)
                    {
                        continue;
                    }
                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex]==1)
                        {
                            landIndex += flyLength;
                            if (landIndex > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >=0 && landIndex<=field.Length-1)
                    {
                        field[landIndex] = 1;
                    }
                    
                }
                else if(direction == "left")
                {
                    int landIndex = ladyBugIndex + flyLength;

                    if (landIndex <0)
                    {
                        continue;
                    }


                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLength;
                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1;
                    }
                    

                }
            }
            Console.WriteLine(String.Join(' ', field));
        }
    }
}
