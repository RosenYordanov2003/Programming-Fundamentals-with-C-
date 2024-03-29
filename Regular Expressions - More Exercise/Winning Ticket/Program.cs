﻿using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions___More_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\@{6,}|\${6,}|\^{6,}|\#{6,})";
            Regex regex = new Regex(pattern);
            char[] separators = new char[] { ',', ' ' };
            string[] array = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < array.Length; i++)
            {
                string currenttTicket = array[i];
                if (currenttTicket.Length < 20||currenttTicket.Length>20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    Match match = regex.Match(currenttTicket);
                    if (match.Success)
                    {
                        Match firstHalf = regex.Match(currenttTicket.Substring(0, 10));
                        Match secondHalf = regex.Match(currenttTicket.Substring(10));
                        int lenght = Math.Min(firstHalf.Length, secondHalf.Length);
                        SetTickets(firstHalf, secondHalf, lenght, currenttTicket);
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{currenttTicket}\" - no match");
                    }
                }
            }
        }
        static void SetTickets(Match firstHalf, Match secondHalf, int lenght, string currentTicket)
        {
            if (firstHalf.Success && secondHalf.Success)
            {
                string firstHalfResult = firstHalf.Value.Substring(0, lenght);
                string secondHalfResult = secondHalf.Value.Substring(0, lenght);
                if (firstHalfResult == secondHalfResult)
                {
                    if (firstHalfResult.Length == 10)
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - {lenght}{firstHalfResult[0]} Jackpot!");
                    }
                    else if(firstHalfResult.Length>=6&&firstHalfResult.Length<=9)
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - {firstHalfResult.Length}{firstHalfResult[0]}");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                }
            }
            else
            {
                Console.WriteLine($"ticket \"{currentTicket}\" - no match");
            }
        }
    }
}
