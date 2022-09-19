using System;
using System.Linq;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            
            for (int i = 0; i < nums.Length; i++)
            {
                
                Console.WriteLine($"{Convert.ToDecimal(nums[i])} => {Math.Round(Convert.ToDecimal(nums[i]),MidpointRounding.AwayFromZero)}");
            }
           
        }
    }
}
