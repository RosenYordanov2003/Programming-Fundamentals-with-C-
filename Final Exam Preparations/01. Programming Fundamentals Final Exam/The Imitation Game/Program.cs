using System;

namespace The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] tokens = command.Split("|");
                string action = tokens[0];
                if (action == "Move")
                {
                    int numberOffLetters = int.Parse(tokens[1]);
                    string substring = input.Substring(0, numberOffLetters);
                    input = input.Remove(0, substring.Length);
                    input += substring;
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(tokens[1]);
                    string value = tokens[2];
                    input = input.Insert(index, value);
                }
                else if (action == "ChangeAll")
                {
                    string oldText = tokens[1];
                    string newText = tokens[2];
                    input = input.Replace(oldText, newText);
                }
            }
            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}
