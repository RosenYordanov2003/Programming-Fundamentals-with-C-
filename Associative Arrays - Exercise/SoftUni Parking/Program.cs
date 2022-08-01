using System;
using System.Linq;
using System.Collections.Generic;
namespace SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split(' ');
                string operation = tokens[0];
                string userName = tokens[1];
                if (operation == "register")
                {
                    string plat = tokens[2];
                    RegisterMethod(users, userName, plat);
                }
                else
                {
                    UnregisterMethod(users, userName);
                }
            }
            PrintMethod(users);
        }
        static void PrintMethod(Dictionary<string, string> users)
        {
            foreach (KeyValuePair<string, string> user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

        static void UnregisterMethod(Dictionary<string, string> users, string userName)
        {
            if (!users.ContainsKey(userName))
            {
                Console.WriteLine($"ERROR: user {userName} not found");
            }
            else
            {
                users.Remove(userName);
                Console.WriteLine($"{userName} unregistered successfully");
            }
        }

        static void RegisterMethod(Dictionary<string, string> users, string userName, string plate)
        {
            if (users.ContainsKey(userName))
            {
                Console.WriteLine($"ERROR: already registered with plate number {plate}");
            }
            else
            {
                users[userName] = plate;
                Console.WriteLine($"{userName} registered {plate} successfully");
            }
        }
    }
}
