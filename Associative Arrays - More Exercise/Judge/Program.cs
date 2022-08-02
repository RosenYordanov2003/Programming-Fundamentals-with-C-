using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contestDictionary = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> individual = new Dictionary<string, Dictionary<string, int>>();
            string command;
            while ((command = Console.ReadLine()) != "no more time")
            {
                string[] tokens = command.Split(" -> ");
                string userName = tokens[0];
                string contest = tokens[1];
                int points = int.Parse(tokens[2]);
                ContestDictionarySet(contestDictionary, userName, contest, points);
                IndividualDictionarySet(individual, userName, contest, points);
            }
            PrintContestResults(contestDictionary);
            Console.WriteLine("Individual standings:");
            PrintIndividual(individual);
        }

        static void PrintIndividual(Dictionary<string, Dictionary<string, int>> individual)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            int sum = 0;
            foreach (var student in individual)
            {
                foreach (var points in student.Value)
                {
                    sum += points.Value;
                }
                students.Add(student.Key, sum);
                sum = 0;
            }
            int counter = 0;
            foreach (KeyValuePair<string, int> item in students.OrderByDescending(student => student.Value).ThenBy(student => student.Key))
            {
                counter++;
                Console.WriteLine($"{counter}. {item.Key} -> {item.Value}");
            }
        }

        static void IndividualDictionarySet(Dictionary<string, Dictionary<string, int>> individual, string userName, string contest, int points)
        {
            if (!individual.ContainsKey(userName))
            {
                individual.Add(userName, new Dictionary<string, int>());
                individual[userName].Add(contest, points);
            }
            else
            {
                if (!individual[userName].ContainsKey(contest))
                {
                    individual[userName].Add(contest, points);
                }
            }
            if (individual[userName][contest] < points)
            {
                individual[userName][contest] = points;
            }
        }

        static void ContestDictionarySet(Dictionary<string, Dictionary<string, int>> contestDictionary, string userName, string contest, int points)
        {
            if (!contestDictionary.ContainsKey(contest))
            {
                contestDictionary.Add(contest, new Dictionary<string, int>());
                contestDictionary[contest].Add(userName, points);
            }
            else
            {
                if (!contestDictionary[contest].ContainsKey(userName))
                {
                    contestDictionary[contest].Add(userName, points);
                }
            }
            if (contestDictionary[contest][userName] < points)
            {
                contestDictionary[contest][userName] = points;
            }
        }
        static void PrintContestResults(Dictionary<string, Dictionary<string, int>> contestDictionary)
        {
            int count = 0;
            foreach (KeyValuePair<string, Dictionary<string, int>> contest in contestDictionary)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                foreach (KeyValuePair<string, int> student in contest.Value.OrderByDescending(students => students.Value).ThenBy(students => students.Key))
                {
                    count++;
                    Console.WriteLine($"{count}. {student.Key} <::> {student.Value}");
                }
                count = 0;
            }
        }
    }
}
