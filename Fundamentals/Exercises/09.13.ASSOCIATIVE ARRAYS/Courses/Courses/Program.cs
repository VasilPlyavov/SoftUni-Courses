using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesStudents = new Dictionary<string, List<string>>();
            List<string> studentData = Console.ReadLine().Split(" : ").ToList();

            while (studentData[0] != "end")
            {
                string course = studentData[0];
                string student = studentData[1];
                if (!coursesStudents.ContainsKey(course))
                {
                    coursesStudents.Add(course, new List<string>());
                    coursesStudents[course].Add(student);
                    studentData = Console.ReadLine().Split(" : ").ToList();
                    continue;
                }
                coursesStudents[course].Add(student);
                studentData = Console.ReadLine().Split(" : ").ToList();
            }

            foreach (var coursekvp in coursesStudents.OrderByDescending(i => i.Value.Count))
            {
                Console.WriteLine($"{coursekvp.Key}: {coursekvp.Value.Count}");
                coursekvp.Value.Sort();
                Console.Write("-- ");
                Console.WriteLine(string.Join($"\n-- ", coursekvp.Value));
            }
        }
    }
}
