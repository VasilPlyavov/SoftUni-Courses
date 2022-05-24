using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int treatmentPatients = 0;
            int untreatmentPatients = 0;
            int doctors = 7;

            for (int day = 1; day <= period; day++)
            {
                int currentPatients = int.Parse(Console.ReadLine());
                if(day%3==0 && (untreatmentPatients > treatmentPatients))
                {
                    doctors++;
                }
                if(currentPatients > doctors)
                {
                    treatmentPatients += doctors;
                    untreatmentPatients += currentPatients - doctors;
                }
                else
                {
                    treatmentPatients += currentPatients;
                      
                }
            }
            Console.WriteLine($"Treated patients: {treatmentPatients}.");
            Console.WriteLine($"Untreated patients: {untreatmentPatients}.");
        }
    }
}
