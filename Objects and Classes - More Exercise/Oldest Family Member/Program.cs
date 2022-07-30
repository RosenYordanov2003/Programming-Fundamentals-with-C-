using System;
using System.Collections.Generic;
using System.Linq;

namespace Oldest_Family_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int countPeople = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countPeople; i++)
            {
                string[] personInfo = Console.ReadLine().Split(' ');
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                Person currentPerson = new Person(name, age);
                family.AddMember(currentPerson);
            }
            Person oldestPerson = family.GetOldestMember();
            Console.WriteLine(oldestPerson);
        }
    }
    class Family
    {
        public Family()
        {
            People = new List<Person>();
        }
        public List<Person> People { get; set; }
        public void AddMember(Person currentPerson)
        {
            People.Add(currentPerson);
        }
        public Person GetOldestMember()
        {
            return People.OrderByDescending(person => person.Age).First();
        }
    }
    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
}
