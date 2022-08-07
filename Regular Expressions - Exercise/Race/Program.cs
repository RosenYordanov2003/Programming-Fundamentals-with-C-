using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(", ").ToList();
            Dictionary<string, int> participants = new Dictionary<string, int>();
            string command;
            while ((command = Console.ReadLine()) != "end of race")
            {
                string name = FindName(command);
                if (names.Contains(name))
                {
                    int sum = FindSum(command);
                    if (!participants.ContainsKey(name))
                    {
                        participants[name] = 0;
                    }
                    participants[name] += sum;
                }
            }
            PrintResult(participants);
        }

        static void PrintResult(Dictionary<string, int> participants)
        {
            List<string> rankList = new List<string>();
            foreach (KeyValuePair<string, int> participant in participants.OrderByDescending(x => x.Value))
            {
                rankList.Add(participant.Key);
            }
            for (int i = 0; i < rankList.Count; i++)
            {
                Console.WriteLine($"1st place: {rankList[i]}");
                Console.WriteLine($"2nd place: {rankList[i + 1]}");
                Console.WriteLine($"3rd place: {rankList[i + 2]}");
                break;
            }
        }

        static int FindSum(string command)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char digit in command)
            {
                if (char.IsDigit(digit))
                {
                    sb.Append(digit);
                }
            }
            int number = int.Parse(sb.ToString());
            int totalSum = FindTotalSum(number);
            return totalSum;
        }

        static int FindTotalSum(int sum)
        {
            int total = 0;
            while (sum > 0)
            {
                int digit = sum % 10;
                total += digit;
                sum /= 10;
            }
            return total;
        }

        static string FindName(string command)
        {
            StringBuilder name = new StringBuilder();
            foreach (char letter in command)
            {
                if (char.IsLetter(letter))
                {
                    name.Append(letter);
                }
            }
            return name.ToString();
        }
    }
}
