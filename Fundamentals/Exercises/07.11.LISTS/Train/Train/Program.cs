using System;
using System.Collections.Generic;
using System.Linq;
namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] elements = command.Split();//["Add","10"]

                if (elements[0] == "Add")
                {
                    int passengers = int.Parse(elements[1]);//elements[1]=="10"
                    train.Add(passengers);//added to list in train
                }
                else
                {
                    int passengers = int.Parse(elements[0]);//or command[1]
                    for (int i = 0; i < train.Count; i++)//searching for wagons
                    {
                        if (train[i] + passengers <= maxCapacity)
                        {
                            train[i] += passengers;//
                            break;
                        }

                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(' ', train));
        }
    }
}
