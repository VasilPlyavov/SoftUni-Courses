using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouritebook = Console.ReadLine();
            int counter = 0;
            bool isBookFound = false;
            string nextBookName = Console.ReadLine();

            while (isBookFound= false)
            {
                nextBookName = Console.ReadLine();
                counter++;
                if (nextBookName == "No More Books")
                {
                   
                    break;
                }
              if(nextBookName == favouritebook)
                {
                    isBookFound = true;
                    break;
                }
                counter++;
                nextBookName = Console.ReadLine();
                if (isBookFound)
                {
                    Console.WriteLine($"You checked {counter-1} books and found it.");
                    
                }
                else
                {

                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter-1} books.");
                }
            }
            
        }
    }
}
