using System;
using System.Text;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Console.ReadLine());
            for (int i = 1; i < sb.Length; i++)
            {
                if (sb[i-1] ==sb[i])
                {
                    sb.Remove(i - 1, 1);
                    i--;
                }
            }
            Console.WriteLine(sb);
        }
    }
}
