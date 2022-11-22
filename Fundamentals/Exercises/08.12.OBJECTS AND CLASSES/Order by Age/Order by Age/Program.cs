using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputInfo = input.Split(" ");
                string name = inputInfo[0];
                string id = inputInfo[1];
                int age = int.Parse(inputInfo[2]);
                Person person = new Person(name, id, age);
                people.Add(person);


                input = Console.ReadLine();
            }
            var orderedAge = people.OrderBy(x => x.Age);

            foreach (Person person in orderedAge)
            {
                Console.WriteLine(person.Name + " with ID: " +  person.ID + " is " + person.Age + " years old.");
            }
        }
        class Person
        {

            public Person(string name, string iD, int age)
            {
                Name = name;
                ID = iD;
                Age = age;
            }

            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }


        }
    }



}


