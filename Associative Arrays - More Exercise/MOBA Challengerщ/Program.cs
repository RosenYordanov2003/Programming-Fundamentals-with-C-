using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBA_Challengerщ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
            string command;
            while ((command = Console.ReadLine()) != "Season end")
            {
                if (!command.Contains("vs"))
                {
                    SetPlayers(players, command);
                }
                else
                {
                    Duel(players, command);
                }
            }
            PrintPlayers(players);
        }

        static void PrintPlayers(Dictionary<string, Dictionary<string, int>> players)
        {
            foreach (KeyValuePair<string, Dictionary<string, int>> player in players.OrderByDescending(z => z.Value.Values.Sum()).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                foreach (KeyValuePair<string, int> item in player.Value.OrderByDescending(player => player.Value).ThenBy(player => player.Key))
                {
                    Console.WriteLine($"- {item.Key} <::> {item.Value}");
                }
            }
        }

        static void Duel(Dictionary<string, Dictionary<string, int>> players, string command)
        {
            string[] tokens = command.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);
            string firstPlayer = tokens[0];
            string secondPlayer = tokens[1];
            string playerToRemove = string.Empty;
            if (players.ContainsKey(firstPlayer) && players.ContainsKey(secondPlayer))
            {
                foreach (var playerPosition in players[firstPlayer])
                {
                    foreach (var secondPlayerPos in players[secondPlayer])
                    {
                        var firstPlayerpos = playerPosition.Key;
                        var secondPlayerpos = secondPlayerPos.Key;
                        if (firstPlayerpos == secondPlayerpos)
                        {
                            if (players[firstPlayer].Values.Sum() > players[secondPlayer].Values.Sum())
                            {
                                playerToRemove = secondPlayer;
                            }
                            else
                            {
                                playerToRemove = firstPlayer;
                            }
                        }
                    }
                }
                players.Remove(playerToRemove);
            }
        }

        static void SetPlayers(Dictionary<string, Dictionary<string, int>> players, string command)
        {
            string[] tokens = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            string playerName = tokens[0];
            string position = tokens[1];
            int skills = int.Parse(tokens[2]);
            if (!players.ContainsKey(playerName))
            {
                players.Add(playerName, new Dictionary<string, int>());
                players[playerName].Add(position, skills);
            }
            else
            {
                if (!players[playerName].ContainsKey(position))
                {
                    players[playerName][position] = skills;
                }
            }
            if (players[playerName][position] < skills)
            {
                players[playerName][position] = skills;
            }
        }
    }
}
