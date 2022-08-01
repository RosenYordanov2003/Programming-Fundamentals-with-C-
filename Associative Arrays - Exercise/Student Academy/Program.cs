using System;
using System.Linq;
using System.Collections.Generic;
namespace Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsGradesInfo = new Dictionary<string, List<double>>();
            int countStudents=int.Parse(Console.ReadLine());
            for (int i = 1; i <= countStudents; i++)
            {
                string studentName = Console.ReadLine();
                double grade=double.Parse(Console.ReadLine());
                if (!studentsGradesInfo.ContainsKey(studentName))
                {
                    studentsGradesInfo[studentName]=new List<double>();
                }
                studentsGradesInfo [studentName].Add(grade);
            }
            Console.WriteLine(string.Join($"{Environment.NewLine}", studentsGradesInfo
                 .Where(student=>student.Value.Average()>=4.50)
                .Select(student => $"{student.Key} -> {student.Value.Sum() / student.Value.Count():f2}"))); ;
        }
    }
}
