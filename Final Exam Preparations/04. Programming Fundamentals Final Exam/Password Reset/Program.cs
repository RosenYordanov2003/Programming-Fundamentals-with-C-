using System;

namespace _04._Programming_Fundamentals_Final_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string operation = tokens[0];
                if (operation == "TakeOdd")
                {
                    text=TakeOodds(text);
                    Console.WriteLine(text);
                }
                else if (operation == "Cut")
                {
                    int index = int.Parse(tokens[1]);
                    int lenght = int.Parse(tokens[2]);
                    string textToRemove = text.Substring(index, lenght);
                    int indexToSearch=text.IndexOf(textToRemove);
                    text = text.Remove(indexToSearch, textToRemove.Length);
                    Console.WriteLine(text);
                }
                else if (operation=="Substitute")
                {
                    string oldText = tokens[1];
                    string newText = tokens[2];
                    if (text.Contains(oldText))
                    {
                        text = text.Replace(oldText, newText);
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }
            Console.WriteLine($"Your password is: {text}");
        }

        static string TakeOodds(string text)
        {
            string oddWord = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddWord += text[i];
                }
            }
            return oddWord;
        }
    }
}
