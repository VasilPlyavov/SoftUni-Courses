using System;

namespace Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            double pagesforOneday = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double totaltime = pages / pagesforOneday;
            double hours = totaltime / days;
            Console.WriteLine(hours);
        }
    }
}
