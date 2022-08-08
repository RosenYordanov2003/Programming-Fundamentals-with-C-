using System;
using System.Text.RegularExpressions;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"[^\s\,]{20}";
            Regex regex = new Regex(pattern);
            char[] separators = new char[] { ',', ' ' };
            string[] array = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < array.Length; i++)
            {
                string currentTicket = array[i];
                Match match = regex.Match(currentTicket);
                if (match.Success)
                {
                    PrintCurrentTicketStatment(currentTicket);
                }
                if (currentTicket.Length < 20 || currentTicket.Length > 20)
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }

        static void PrintCurrentTicketStatment(string currentTicket)
        {
            char[] winnerSymbols = new char[] { '@', '$', '#', '^' };
            int middle = currentTicket.Length / 2;
            string firstMiddle = FindFirstMiddle(currentTicket, middle);
            string secondMiddle = FindSecondMiddle(currentTicket, middle);
            if (firstMiddle.Contains(winnerSymbols[0]) || firstMiddle.Contains(winnerSymbols[1]) || firstMiddle.Contains(winnerSymbols[2]) || firstMiddle.Contains(winnerSymbols[3])
                && secondMiddle.Contains(winnerSymbols[0]) || secondMiddle.Contains(winnerSymbols[1]) || secondMiddle.Contains(winnerSymbols[2]) || secondMiddle.Contains(winnerSymbols[3]))
            {
                FindCount(winnerSymbols, firstMiddle, secondMiddle, currentTicket);
            }
            else
            {
                Console.WriteLine($"ticket \"{currentTicket}\" - no match");
            }
        }

        static void FindCount(char[] winnerSymbols, string firstMiddle, string secondMiddle, string currentTicket)
        {
            int firstCcounter = 0;
            char winnerSumbol = '0';
            string winner = string.Empty;
            string firstrHalfWinningSymbols = string.Empty;
            for (int i = 0; i < firstMiddle.Length; i++)
            {
                char current = firstMiddle[i];
                if (firstMiddle[i] == winnerSymbols[0] || firstMiddle[i] == winnerSymbols[1] ||
                    firstMiddle[i] == winnerSymbols[2] || firstMiddle[i] == winnerSymbols[3])
                {
                    if (current != winnerSumbol && firstCcounter > 0)
                    {
                        firstCcounter = 0;
                        break;
                    }
                    else
                    {
                        firstrHalfWinningSymbols += current;
                        winnerSumbol = current;
                        firstCcounter++;
                        winner = firstMiddle[i].ToString();
                    }
                }
            }
            char winnerSumbol2 = '0';
            int secondCounter = 0;
            string secondHalfWinningSymbols = string.Empty;
            for (int i = 0; i < secondMiddle.Length; i++)
            {
                char current = secondMiddle[i];
                if (secondMiddle[i] == winnerSymbols[0] || secondMiddle[i] == winnerSymbols[1] ||
                    secondMiddle[i] == winnerSymbols[2] || secondMiddle[i] == winnerSymbols[3])
                {
                    if (current != winnerSumbol2 && secondCounter > 0)
                    {
                        secondCounter = 0;
                        break;
                    }
                    else
                    {
                        secondHalfWinningSymbols += current;
                        secondCounter++;
                        winnerSumbol2 = current;
                    }
                }
            }
            if ((firstCcounter >= 6 && firstCcounter <= 9) && (secondCounter >= 6 && secondCounter <= 9) && (firstrHalfWinningSymbols == secondHalfWinningSymbols))
            {
                int biggerCounter = Math.Max(firstCcounter, secondCounter);
                Console.WriteLine($"ticket \"{currentTicket}\" - {biggerCounter}{winner}");
            }
            else if ((firstCcounter == 10 && secondCounter == 10) && (firstrHalfWinningSymbols == secondHalfWinningSymbols))
            {
                Console.WriteLine($"ticket \"{currentTicket}\" - {firstCcounter}{winner} Jackpot!");
            }
            else
            {
                Console.WriteLine($"ticket \"{currentTicket}\" - no match");
            }
        }

        static string FindSecondMiddle(string currentTicket, int middle)
        {
            string secondMiddle = string.Empty;
            for (int i = currentTicket.Length - 1; i >= middle; i--)
            {
                secondMiddle += currentTicket[i];
            }
            return secondMiddle;
        }

        private static string FindFirstMiddle(string currentTicket, int middle)
        {
            string firstMiddle = string.Empty;
            for (int i = 0; i < middle; i++)
            {
                firstMiddle += currentTicket[i];
            }
            return firstMiddle;
        }
    }
}
