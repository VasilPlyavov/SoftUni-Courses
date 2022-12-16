using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentData = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentData.ContainsKey(studentName))
                {
                    studentData.Add(studentName, new List<double>());
                    studentData[studentName].Add(grade);
                    continue;
                }
                studentData[studentName].Add(grade);
            }
            studentData = studentData.Where(s => s.Value.Average()
              >= 4.50).ToDictionary(s => s.Key, s => s.Value);
            foreach ( var student in studentData.OrderByDescending(s=>s.Value.Average()))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            } 
        }
    }
}
