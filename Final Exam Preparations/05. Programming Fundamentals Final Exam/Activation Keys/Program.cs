using System;

namespace _05._Programming_Fundamentals_Final_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Generate")
            {
                bool isContainsCommand=false;
                string[] tokens = command.Split(">>>");
                string action = tokens[0];
                if (action == "Contains")
                {
                    isContainsCommand=true;
                    string substring = tokens[1];
                    if (input.Contains(substring))
                    {
                        Console.WriteLine($"{input} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (action=="Flip")
                {
                    string typeLowerOrUpper = tokens[1];
                    int startIndex = int.Parse(tokens[2]);
                    int endIndex = int.Parse(tokens[3]);
                    input = FlipMethod(input, startIndex, endIndex, typeLowerOrUpper);
                }
                else if (action=="Slice")
                {
                    int startIndex=int.Parse(tokens[1]);
                    int endIndex=int.Parse(tokens[2]);
                    input=input.Remove(startIndex, endIndex-startIndex);
                }
                if (!isContainsCommand)
                {
                    Console.WriteLine(input);
                }
            }
            Console.WriteLine($"Your activation key is: {input}");
        }

        static string FlipMethod(string input, int startIndex, int endIndex, string typeLowerOrUpper)
        {
            if (typeLowerOrUpper=="Upper")
            {
                string substring = input.Substring(startIndex, endIndex - startIndex);
                string upperSubstring=substring.ToUpper();
                input=input.Replace(substring, upperSubstring);
            }
            else
            {
                string substring = input.Substring(startIndex, endIndex - startIndex);
                string lowerSubstring = substring.ToLower();
                input = input.Replace(substring, lowerSubstring);
            }
            return input;
        }
    }
}
