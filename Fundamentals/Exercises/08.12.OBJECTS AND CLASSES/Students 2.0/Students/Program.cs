using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//vzimame broq na studentite;

            List<Student> students = new List<Student>();//list za da dyrjim studentite;

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();//vzimame si inputa kat omasiv;
                

                string firstName = tokens[0];//vzimame argumentite i posle gi vkarvame v lista ot Student
                string lastName = tokens[1];
                double grade = double.Parse(tokens[2]);
                Student student = new Student(firstName,lastName,grade);//syzdavame nov student;
                students.Add(student);//vkarvame studenta v lista;

            }
            students = students.OrderByDescending(x => x.Grade).ToList();
            foreach (Student currentStudents in students)
            {
                Console.WriteLine(currentStudents);
            }
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, double grade)//constructor
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}
