using System;

namespace Data_Type_Finder2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string final = String.Empty;

            switch (input)
            {
                case "int":
                    int intInput = int.Parse(Console.ReadLine());
                    final = InputOperation(intInput);
                    break;
                case "real":
                    double doubleInput = double.Parse(Console.ReadLine());
                    final = $"{DoubleOperation(doubleInput):f2}";
                    break;
                case "string":
                    string strInput = Console.ReadLine();
                    final = InputOperation(strInput);
                    break;
                default:
                    break;
            }
            Console.WriteLine(final);
        }

         static string InputOperation(string strInput)
        {
            return $"${strInput}$";
        }

         static double DoubleOperation(double doubleInput)
        {
            return doubleInput * 1.5;
        }

        private static string InputOperation(int input)
        {
            return (input * 2).ToString();
        }
    }
}
