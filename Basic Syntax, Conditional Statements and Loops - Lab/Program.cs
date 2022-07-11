using System;

namespace Basic_Syntax__Conditional_Statements_and_Loops___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int studentAge = int.Parse(Console.ReadLine());
            double studentAverageGrade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {studentName}, Age: {studentAge}, Grade: {studentAverageGrade:f2}");
        }
    }
}
