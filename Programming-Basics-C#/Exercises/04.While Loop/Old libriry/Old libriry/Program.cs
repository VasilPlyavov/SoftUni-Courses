using System;

namespace Old_libriry
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            int bookCount = int.Parse(Console.ReadLine());

            int counter = 0;
            bool found = false;

            while (counter < bookCount)
            {
                string currentBookName = Console.ReadLine();

                if (currentBookName == favouriteBook)
                {
                    found = true;
                    break;
                }
                counter++;
            }
            if (found)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");

            }
        }
    }
}
