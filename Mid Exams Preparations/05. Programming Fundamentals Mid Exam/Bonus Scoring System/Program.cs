using System;

namespace Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            int numberLectures = int.Parse(Console.ReadLine());
            int aditionalBonus = int.Parse(Console.ReadLine());
            double maxBonus = 0;
            int maxAttendance = 0;
            for (int i = 1; i <= countStudents; i++)
            {
                int attendance = int.Parse(Console.ReadLine());
                double formula = ((double)attendance / numberLectures) * (5 + aditionalBonus);
                if (formula > maxBonus)
                {
                    maxBonus = formula;
                    maxAttendance = attendance;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }
    }
}
