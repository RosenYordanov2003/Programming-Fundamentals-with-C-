using System;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            int unsuccesCounter = 0;
            string password = string.Empty;
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];
            }
            string attempts = string.Empty;
            while (true)
            {
                attempts = Console.ReadLine();
                if (attempts == password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                unsuccesCounter++;
                if (unsuccesCounter >= 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}
