using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = int.Parse(Console.ReadLine());
            double morethan5 = 0;
            double morethan4 = 0;
            double morethan3 = 0;
            double lessthan3 = 0;
            double gradeResult = 0;
            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 5.00)
                {
                    morethan5++;
                }
                else if (grade >= 4.00)
                {
                    morethan4++;
                }
                else if (grade >= 3)
                {
                    morethan3++;
                }
                else 
                {
                    lessthan3++;
                }
                gradeResult += grade;
            }
            double topStudents = 100.0 * morethan5 / students;
            double between4 = 100.0 * morethan4 / students;
            double between3 = 100.0 * morethan3 / students;
            double fail = 100.0 * lessthan3 / students;
            double average = gradeResult / students;

            Console.WriteLine($"Top students: {(topStudents):f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(between4):f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(between3):f2}%");
            Console.WriteLine($"Fail: {(fail):f2}%");
            Console.WriteLine($"Average: {(average):f2}");
        }
    }
}
