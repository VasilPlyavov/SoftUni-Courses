using System;
using System.Text;
namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            RepeatString(str, count);
        }
        private static void RepeatString(string str, int count)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.Append(str);
                
            }
            Console.WriteLine(result);
        }
    }
}
