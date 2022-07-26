using System;
using System.Collections.Generic;
using System.Linq;


namespace Cards_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// we have to find who have the better hand
            /// 1 we have to compare the cards from the first player with the cards from the second player in current iteration-done
            /// 2 the player with the better card get both cards from the iteration-done
            /// 3 card get from the lost player go last. Winning card go before last card. if the cards are equal they have to be removed from the players cards-done
            /// 4 the game end when one of the players  let with 0 cards and print the sum of the card on wining player.
           List<int>firstPlayerCards = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
           List<int>secondPlayerCards = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (firstPlayerCards.Count>0&&secondPlayerCards.Count>0)
            {
                if (firstPlayerCards.Count<=0||secondPlayerCards.Count<=0)
                {
                    break;
                }
                if (firstPlayerCards[0]>secondPlayerCards[0])
                {
                 
                    firstPlayerCards.Add(firstPlayerCards[0]);
                    firstPlayerCards.Add(secondPlayerCards[0]);
                    secondPlayerCards.RemoveAt(0);
                    firstPlayerCards.RemoveAt(0);
                }
                else if (secondPlayerCards[0]>firstPlayerCards[0])
                {
                    secondPlayerCards.Add(secondPlayerCards[0]);
                    secondPlayerCards.Add(firstPlayerCards[0]);
                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);
                } 
                else
                {
                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);
                }
            }
            if (firstPlayerCards.Count>0)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerCards.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerCards.Sum()}");
            }
        }
    }
}
