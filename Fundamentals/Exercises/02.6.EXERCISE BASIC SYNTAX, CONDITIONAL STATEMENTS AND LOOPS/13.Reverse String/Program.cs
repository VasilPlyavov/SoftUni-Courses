using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Text;
namespace ZADACHA_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(String.Join("", number
                .Reverse()));
        }
    }
}
