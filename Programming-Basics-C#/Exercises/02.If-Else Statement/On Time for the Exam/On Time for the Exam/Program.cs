using System;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minutesArrive = int.Parse(Console.ReadLine());
            int examInMinutes = hourExam * 60 + minutesExam;
            int arriveinminutes = hourArrive * 60 + minutesArrive;

            if(arriveinminutes> examInMinutes)
            {
                Console.WriteLine("Late");
                int lateminutes = arriveinminutes - examInMinutes;
                if (lateminutes < 60)
                {
                    Console.WriteLine($"{lateminutes} minutes after the start");
                }
                else
                {
                    int latehours = lateminutes / 60;
                    int lateminute = lateminutes %60;
                    Console.WriteLine($"{latehours}:{lateminute:D2} hours after the start");
                }
            }
            else if(arriveinminutes == examInMinutes || examInMinutes - arriveinminutes <= 30)
            {
                Console.WriteLine("On time");
                if (arriveinminutes != examInMinutes)
                {
                    Console.WriteLine($"{examInMinutes - arriveinminutes} minutes before the start");
                }
               
            }
            else if(examInMinutes - arriveinminutes > 30)
            {
                Console.WriteLine("Early");
                int earlyinminutes = examInMinutes - arriveinminutes;
               
                if (earlyinminutes < 60)
                {
                    Console.WriteLine($"{earlyinminutes} minutes before the start");
                }
                else
                {
                    int earlyhour = earlyinminutes / 60;
                    int earlyMinutes = earlyinminutes % 60;
                    Console.WriteLine($"{earlyhour}:{earlyMinutes:D2} hours before the start");
                }
            }



        }
    }
}
