using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> destroyedPlantes = new List<string>();
            List<string> attackedPlanets = new List<string>();
            string patern = @"\@(?<planetsName>[A-Za-z]+)[^\@\-\!\:\>]*?\:\d+[^\@\-\!\:\>]*?\!(?<attackType>A|D){1}\![^\@\-\!\:\>]*?\-\>\d+";
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();
                int count = FindKey(command);
                string decryptedMessage = DecryptTheMessage(command, count);
                Match match = Regex.Match(decryptedMessage, patern);
                if (match.Success)
                {
                    string planetName = match.Groups["planetsName"].Value;
                    string attackType = match.Groups["attackType"].Value;
                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if(attackType == "D")
                    {
                        destroyedPlantes.Add(planetName);
                    }
                }
            }
            PrintResult(destroyedPlantes, attackedPlanets);
        }

        static void PrintResult(List<string> destroyedPlantes, List<string> attackedPlanets)
        {
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (string attackedPlanet in attackedPlanets.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {attackedPlanet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlantes.Count}");
            foreach (string destroyedPlanet in destroyedPlantes.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {destroyedPlanet}");
            }
        }

        static string DecryptTheMessage(string command, int count)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char symbol in command)
            {
                char newSymbol = (char)(symbol - count);
                sb.Append(newSymbol);
            }
            return sb.ToString().Trim();
        }

        static int FindKey(string command)
        {
            string patern = @"[star]{1}";
            MatchCollection matches = Regex.Matches(command, patern,RegexOptions.IgnoreCase);
            return matches.Count;
        }
    }
}
