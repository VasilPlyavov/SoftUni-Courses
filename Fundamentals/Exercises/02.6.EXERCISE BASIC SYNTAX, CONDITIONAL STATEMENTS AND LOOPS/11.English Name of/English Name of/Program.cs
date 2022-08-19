using System;

namespace English_Name_of
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            LastLetter(input);
        }
        public  static void LastLetter(string input)
        {
            string last = input.Substring(input.Length - 1,1);
            int output = Convert.ToInt32(last);

            if (output==0)
            {
                Console.WriteLine("zero");
            }
            else if (output==1)
            {
                Console.WriteLine("one");
            }
            else if (output==2)
            {
                Console.WriteLine("two");
            }
            else if (output==3)
            {
                Console.WriteLine("three");
            }
            else if (output==4)
            {
                Console.WriteLine("four");
            }
            else if (output==5)
            {
                Console.WriteLine("five");
            }
            else if (output==6)
            {
                Console.WriteLine("six");
            }
            else if (output==7)
            {
                Console.WriteLine("seven");
            }
            else if(output==8)
            {
                Console.WriteLine("eight");
            }
            else if (output==9)
            {
                Console.WriteLine("nine");
            }
            else
            {
                Console.WriteLine("");
            }


        }
    }
}
