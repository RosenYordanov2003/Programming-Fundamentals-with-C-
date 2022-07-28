using System;
using System.Collections.Generic;
using System.Linq;
namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students>students=new List<Students>();
            string command=string.Empty;
            while ((command=Console.ReadLine())!="end")
            {
                string[] studentsProperties = command.Split(" ");
                int age=int.Parse(studentsProperties[2]);
                Students student = new Students(studentsProperties[0],studentsProperties[1],age,studentsProperties[3]);
                students.Add(student);
            }
            string city=Console.ReadLine();
            PrintMethod(city, students);
        }

        static void PrintMethod(string city, List<Students> students)
        {
            foreach (Students student in students)
            {
                if (student.Hometown==city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
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
