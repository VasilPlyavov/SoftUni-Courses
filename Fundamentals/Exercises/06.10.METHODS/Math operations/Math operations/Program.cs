using System;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int second = int.Parse(Console.ReadLine());
            double result = Calculations(first, @operator, second);
            Console.WriteLine(result);
        }
        static double Calculations(int first, string @operator, int second)
        {
            double result = 0;
            switch(@operator)
            {
                case "/":result = first / second;break;
                case "*":result = first * second;break;
                case "+":result = first + second;break;
                case "-":result = first - second;break;
                default:
                    break;
            }
            return result;
        }
    }
}
