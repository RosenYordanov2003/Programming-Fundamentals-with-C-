using System;

namespace _03._Programming_Fundamentals_Final_Exam_Retake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] tokens = command.Split(":|:");
                string operation = tokens[0];
                if (operation == "InsertSpace")
                {
                    int index = int.Parse(tokens[1]);
                    input = input.Insert(index, " ");
                    Console.WriteLine(input);
                }
                else if (operation == "Reverse")
                {
                    string substring = tokens[1];
                    int index = input.IndexOf(substring);
                    if (index != -1)
                    {
                        input = input.Remove(index, substring.Length);
                        string reverse = ReverseString(substring);
                        input += reverse;
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (operation=="ChangeAll")
                {
                    string oldText = tokens[1];
                    string newText=tokens[2];
                    input = input.Replace(oldText, newText);
                    Console.WriteLine(input);
                }
            }
            Console.WriteLine($"You have a new text message: {input}");
        }

        static string ReverseString(string substring)
        {
            string reverse = string.Empty;
            for (int i = substring.Length-1; i >= 0; i--)
            {
                reverse += substring[i];
            }
            return reverse;
        }
    }
}
