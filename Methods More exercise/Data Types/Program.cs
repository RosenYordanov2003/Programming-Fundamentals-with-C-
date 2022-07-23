using System;

namespace Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "int")
            {
                int nuumber = int.Parse(Console.ReadLine());
                InputOperation(nuumber);
            }
            else if (input == "real")
            {
                double nuumber = double.Parse(Console.ReadLine());
                InputOperation(nuumber);
            }
            else if (input == "string")
            {
                string text = Console.ReadLine();
                InputOperation(text);
            }
        }
        static void InputOperation(string text)
        {
            Console.WriteLine($"${text}$");
        }
        static void InputOperation(double number)
        {
            Console.WriteLine($"{(number * 1.5):f2}");
        }
        static void InputOperation(int nuumber)
        {
            Console.WriteLine(nuumber * 2);
        }
    }
}
