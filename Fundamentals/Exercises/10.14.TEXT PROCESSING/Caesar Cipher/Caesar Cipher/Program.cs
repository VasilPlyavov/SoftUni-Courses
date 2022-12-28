using System;
using System.Text;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder toCypher1 = new StringBuilder();
            toCypher1.Append(Console.ReadLine());
            StringBuilder cypher = new StringBuilder();
            foreach (var @char in toCypher1.ToString())
            {
                cypher.Append((char)(@char + 3));
            }
            Console.WriteLine(cypher);
        }
    }
}
