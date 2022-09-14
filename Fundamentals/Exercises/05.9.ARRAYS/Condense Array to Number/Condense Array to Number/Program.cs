using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToArray();

            if (nums.Length==1)
            {
                Console.WriteLine(nums[0]);
                return;
            }
            int[] condense = new int[nums.Length - 1];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < condense.Length-i; j++)
                {

                    condense[j] = nums[j] + nums[j + 1];

                }
                nums = condense;
            }
            Console.WriteLine(condense[0]);
        }
    }
}
