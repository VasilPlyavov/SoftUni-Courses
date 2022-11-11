using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();//vhodni danni

            while (command != "course start")
            {
                string[] cmdArgs = command.Split(':').ToArray();//split po :[Insert:Arrays:0]
                string firstCommand = cmdArgs[0];
                string lessonTitle = cmdArgs[1];

                if (firstCommand == "Add")
                {
                    if (!lessons.Contains(lessonTitle))
                    {
                        lessons.Add(lessonTitle);
                    }
                }
                else if (firstCommand == "Insert")
                {
                    int index = int.Parse(cmdArgs[2]);
                    if (!lessons.Contains(lessonTitle))
                    {
                        lessons.Insert(index, lessonTitle);
                    }
                }
                else if (firstCommand == "Remove")
                {
                    lessons.Remove(lessonTitle);
                }
                else if (firstCommand == "Swap")
                {
                    string secondLessonTitle = cmdArgs[2];

                    int indexOfFirstLesson = lessons.IndexOf(lessonTitle);
                    int indexOfSecondLesson = lessons.IndexOf(secondLessonTitle);
                    if (indexOfFirstLesson != -1 && indexOfSecondLesson != -1)
                    {
                        lessons[indexOfFirstLesson] = secondLessonTitle;
                        lessons[indexOfSecondLesson] = lessonTitle;

                        string firstLessonExercise = $"{lessonTitle}-Exercise";
                        int indexOfFirstExercise = indexOfFirstLesson + 1;

                        if (indexOfFirstLesson < lessons.Count && lessons[indexOfFirstExercise] == firstLessonExercise) ;
                        {
                            lessons.RemoveAt(indexOfFirstExercise);
                            indexOfFirstExercise = lessons.IndexOf(lessonTitle);
                            lessons.Insert(indexOfFirstExercise, firstLessonExercise);
                        }
                        string secondLessonExercise = $"{secondLessonTitle}-Exercise";
                        int indexOfSecondExercise = indexOfSecondLesson;

                        if (indexOfSecondExercise < lessons.Count &&
                            lessons[indexOfSecondExercise] == secondLessonExercise)
                        {
                            lessons.RemoveAt(indexOfSecondLesson + 1);
                            indexOfSecondLesson = lessons.IndexOf(secondLessonTitle);
                            lessons.Insert(indexOfSecondLesson + 1, secondLessonExercise);
                        }
                    }
                }
                else if (firstCommand == "Exercise")
                {
                    int index = lessons.IndexOf(lessonTitle);
                    string exercise = $"{lessonTitle}-Exercise";//vzemane na exercise

                    bool isThereAreLesson = lessons.Contains(lessonTitle);
                    bool isThereAreExercise = lessons.Contains(exercise);
                    if (isThereAreLesson && !isThereAreExercise)
                    {
                        lessons.Insert(index + 1, exercise);//+1 za da dobavim lessons
                    }
                    else if (!isThereAreLesson)
                    {
                        lessons.Add(lessonTitle);
                        lessons.Add(exercise);
                    }
                }
                command = Console.ReadLine();//chetene na vhodni daani
            }
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }

        }
    }
}
