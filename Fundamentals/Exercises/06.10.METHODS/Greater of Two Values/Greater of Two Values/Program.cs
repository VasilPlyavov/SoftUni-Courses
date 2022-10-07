using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "int")
            {
                int firstnum = int.Parse(Console.ReadLine());
                int secondnum = int.Parse(Console.ReadLine());
                int output = GetIntMax(firstnum, secondnum);
                Console.WriteLine(output);
            }
            else if (input == "char")
            {
                char firstnum = char.Parse(Console.ReadLine());
                char secondnum = char.Parse(Console.ReadLine());
                char output = GetCharMax(firstnum, secondnum);
                Console.WriteLine(output);
            }
            else if (input == "string")
            {
                string firstnum = Console.ReadLine();
                string secondnum = Console.ReadLine();
                string output = GetStringMax(firstnum, secondnum);
                Console.WriteLine(output);
            }

        }
        static int GetIntMax(int firstnum, int secondnum)
        {
            if (firstnum >= secondnum)
            {
                return firstnum;
            }
            else
            {
                return secondnum;
            }
        }
        static char GetCharMax(char firstnum, char secondnum)
        {
            if (firstnum >= secondnum)
            {
                return firstnum;
            }
            else
            {
                return secondnum;
            }
        }
        static string GetStringMax(string firstnum, string secondnum)
        {
            
            string theBiggest = string.Empty;
            if (firstnum.CompareTo(secondnum) >= 0)
            {
                theBiggest = firstnum;
                return theBiggest;
            }
            else
            {
                theBiggest = secondnum;
                return theBiggest;
            }


        }
    }
}
