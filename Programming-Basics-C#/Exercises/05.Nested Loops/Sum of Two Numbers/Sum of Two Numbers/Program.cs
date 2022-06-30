using System;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int finalNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinations = 0;
            bool isFound = false;
            for (int i = startNum; i <= finalNum; i++)
            {
                for (int j = startNum; j <= finalNum; j++)
                {
                    combinations++;
                    if(i+j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicNum})");
                        isFound = true;
                        break;
                    }
                    
                }
                if (isFound)
                {   
                    break;
                }
            }
            
            if (!isFound)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
            }
            
        }
    }
}
