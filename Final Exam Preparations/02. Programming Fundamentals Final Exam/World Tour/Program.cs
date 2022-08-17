using System;

namespace World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Travel")
            {

                string[] tokens = command.Split(':');
                string action = tokens[0];
                if (action == "Add Stop")
                {
                    int index = int.Parse(tokens[1]);
                    string text = tokens[2];
                    if (index >= 0 && index < input.Length)
                    {
                        input = input.Insert(index, text);
                    }
                }
                else if (action == "Remove Stop")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    if ((startIndex >= 0 && startIndex < input.Length) && (endIndex >= 0 && endIndex < input.Length))
                    {
                        input = input.Remove(startIndex, endIndex - startIndex + 1);
                    }

                }
                else if (action == "Switch")
                {
                    string oldText = tokens[1];
                    string newText = tokens[2];
                    if (input.Contains(oldText))
                    {
                        input = input.Replace(oldText, newText);
                    }

                }

                Console.WriteLine(input);
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
