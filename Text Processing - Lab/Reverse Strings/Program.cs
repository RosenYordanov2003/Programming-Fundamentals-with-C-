using System;

namespace Text_Processing___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            while ((command=Console.ReadLine())!="end")
            {
                char[] commandToChar = command.ToCharArray();
                Array.Reverse(commandToChar);
                string reversedWord=new string(commandToChar);
                Console.WriteLine($"{command} = {reversedWord}");
            }
        }
    }
}
