using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Dictionary<string, string> contests = new Dictionary<string, string>();
                Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();
                string commad;
                while ((commad = Console.ReadLine()) != "end of contests")
                {
                    AddingContests(contests, commad);
                }
                string userInformation;
                while ((userInformation = Console.ReadLine()) != "end of submissions")
                {
                    AddStudents(students, userInformation, contests);
                }
                PrintTheBestStudent(students, contests);
                Console.WriteLine("Ranking:");
                PrintOtherStudents(students);
            }

            static void PrintOtherStudents(Dictionary<string, Dictionary<string, int>> students)
            {
                foreach (KeyValuePair<string, Dictionary<string, int>> student in students.OrderBy(student => student.Key))
                {
                    Console.WriteLine($"{student.Key}");
                    foreach (KeyValuePair<string, int> contest in student.Value.OrderByDescending(student => student.Value))
                    {
                        Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                    }
                }
            }

            static void PrintTheBestStudent(Dictionary<string, Dictionary<string, int>> students, Dictionary<string, string> contests)
            {
                int sum = 0;
                int max = 0;
                string thebestStudent = string.Empty;
                foreach (KeyValuePair<string, Dictionary<string, int>> student in students)
                {
                    foreach (KeyValuePair<string, int> studentPoints in student.Value)
                    {
                        sum += studentPoints.Value;
                    }
                    if (sum > max)
                    {
                        max = sum;
                        thebestStudent = student.Key;
                    }
                    sum = 0;
                }
                Console.WriteLine($"Best candidate is {thebestStudent} with total {max} points.");

            }

            static void AddStudents(Dictionary<string, Dictionary<string, int>> students, string userInformation, Dictionary<string, string> contests)
            {
                string[] tokens = userInformation.Split("=>");
                string contestToCheck = tokens[0];
                string passwordToCheck = tokens[1];
                string studentsUsername = tokens[2];
                int points = int.Parse(tokens[3]);
                if (contests.ContainsKey(contestToCheck) && contests[contestToCheck] == passwordToCheck)
                {
                    if (!students.ContainsKey(studentsUsername))
                    {
                        students.Add(studentsUsername, new Dictionary<string, int>());
                        students[studentsUsername].Add(contestToCheck, points);
                    }
                    if (!students[studentsUsername].ContainsKey(contestToCheck))
                    {
                        students[studentsUsername][contestToCheck] = points;
                    }
                    if (students[studentsUsername].ContainsKey(contestToCheck))
                    {
                        if (students[studentsUsername][contestToCheck] < points)
                        {
                            students[studentsUsername][contestToCheck] = points;
                        }
                    }
                }
            }

            static void AddingContests(Dictionary<string, string> contests, string commad)
            {
                string[] tokens = commad.Split(':');
                string contest = tokens[0];
                string password = tokens[1];
                if (!contests.ContainsKey(contest))
                {
                    contests[contest] = password;
                }
            }
        }
    }
}
