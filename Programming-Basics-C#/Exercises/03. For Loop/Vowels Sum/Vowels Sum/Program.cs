using System;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var result = 0;
            for(int i = 0; i < text.Length; i++)
            {
                var sssss = text[i];
                switch (sssss)
                {
                    case 'a': result += 1;break;
                    case 'e': result += 2;break;
                    case 'i': result += 3;break;
                    case 'o': result += 4;break;
                    case 'u': result += 5;break;
                }
                
                Console.WriteLine(result);
            }

           
        }
    }
}
