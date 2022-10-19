using System;

namespace Data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type=="int")
            {
                int num = int.Parse(Console.ReadLine());
                intMethod(num);
            }
            else if (type=="real")
            {
                double num = double.Parse(Console.ReadLine());
                doubleMethod(num);
            }
            else if (type=="string")
            {
                string word= Console.ReadLine();
                stringWord(word);
            }
        }

        static void stringWord(string word)
        {
            Console.WriteLine("$" + word + "$");
        }

        static void doubleMethod(double num)
        {
            Console.WriteLine($"{(num*1.5):f2}");
        }

        static void intMethod(int num)
        {
            Console.WriteLine(num * 2);
        }
    }
}

