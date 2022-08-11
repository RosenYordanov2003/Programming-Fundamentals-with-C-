using System;

namespace SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeerStudents = int.Parse(Console.ReadLine());
            int secondEmployeerStudents = int.Parse(Console.ReadLine());
            int thirdEmployeerStudents = int.Parse(Console.ReadLine());
            int totalCountStudents = int.Parse(Console.ReadLine());
            int countHours = 0;
            int totalHandleStudentsPerHour = firstEmployeerStudents + secondEmployeerStudents + thirdEmployeerStudents;
            int currentStudentsHandle = 0;
            while (totalCountStudents > 0)
            {
                countHours++;
                if (countHours % 4 == 0)
                {
                    continue;
                }
                currentStudentsHandle += totalHandleStudentsPerHour;
                totalCountStudents -= totalHandleStudentsPerHour;

            }
            Console.WriteLine($"Time needed: {countHours}h.");
        }
    }
}
