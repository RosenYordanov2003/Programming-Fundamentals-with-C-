using System;
using System.Linq;
using System.Collections.Generic;

namespace Students_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] studentsProperties = command.Split(" ");
                int age = int.Parse(studentsProperties[2]);
                bool isStudentExist = StudentMethod(studentsProperties[0], studentsProperties[1], students);
                if (isStudentExist)
                {
                    Students student=students.Find(x => x.FirstName == studentsProperties[0]&&x.LastName==studentsProperties[1]);
                    student.Age = age;
                    student.Hometown = studentsProperties[3];
                }
                else
                {
                    Students student = new Students(studentsProperties[0], studentsProperties[1], age, studentsProperties[3]);
                    students.Add(student);
                }
            }
            string city = Console.ReadLine();
            PrintMethod(city, students);
        }
        static void PrintMethod(string city, List<Students> students)
        {
            foreach (Students student in students)
            {
                if (student.Hometown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
        static bool StudentMethod(string firstName, string lastName, List<Students> students)
        {
            foreach (Students student in students)
            {
                if (student.FirstName==firstName&&student.LastName==lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Students
    {
        public Students(string firstName, string lastName, int age, string hometown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Hometown = hometown;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public int Age { get; set; }

        public string Hometown { get; set; }
    }
}
