using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> playersPoints = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "JOKER")
            {
                string[] nameTokens = input.Split(':');
                string playerName = nameTokens[0];
                string[] cards = nameTokens[1].Trim()
                    .Split(new String [] {", "},StringSplitOptions.RemoveEmptyEntries);
                var points = 0;
                if (!playersPoints.ContainsKey(playerName))
                {
                    playersPoints.Add(playerName, new Dictionary<string, int>());
                   GetCardsSum(playersPoints[playerName], cards);
                }
                else
                {
                    GetCardsSum(playersPoints[playerName], cards);
                }

                input = Console.ReadLine();
            }

            foreach (var player in playersPoints)
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()}");
            }
        }
        
        private static void GetCardsSum(Dictionary<string, int> playersPoint, string[] cards)
        {
            foreach (var card in cards)
            {
                int value = GetValue(card);
                if (!playersPoint.ContainsKey(card))
                {
                    playersPoint.Add(card, value);
                }
            }
           
        }

        private static int GetValue(string card)
        {
            int power = 0;

            switch (card[0])
            {
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    power += (int)card[0] -48;
                    break;
                case '1':
                    power += 10;
                    break;
                case 'J':
                    power += 11;
                    break;
                case 'Q':
                    power += 12;
                    break;
                case 'K':
                    power += 13;
                    break;
                case 'A':
                    power += 14;
                    break;
            }


            switch (card[card.Length-1])
            {
                case 'S':
                    power *= 4;
                    break;
                case 'H':
                    power *= 3;
                    break;
                case 'D':
                    power *= 2;
                    break;
                case 'C':
                    power *= 1;
                    break;
            }
            return power;
        }
    }
}
