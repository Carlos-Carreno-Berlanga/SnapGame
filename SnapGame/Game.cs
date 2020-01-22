using System;
using System.Collections.Generic;
using System.Linq;

namespace SnapGame
{
    public class Game
    {
        public Game(int numberofPacks, GameType gameType)
        {
            NumberOfPacks = numberofPacks;
            GameType = gameType;
            Players = new Player[2] { new Player("Player One"), new Player("Player Two") };
            List<Card> allCards = new List<Card>();
            Packs = PackFactory.CreatePacks(numberofPacks);

        }

        public IList<Player> Players { get; private set; }

        public IEnumerable<Pack> Packs { get; private set; }

        private List<Card> allCards = new List<Card>();


        public int NumberOfPacks { get; set; }

        public GameType GameType { get; set; }

        public void Play()
        {
            JoinAllPacks();

            DistributeCards();

            PrintWinner();
        }

        private void DistributeCards()
        {
            int lastSnapPos = 0;
            Random random = new Random();
            int playerPos = 0;
            for (int i = 0; i < allCards.Count - 1; i++)
            {
                Console.WriteLine($"Move{i} Card {allCards[i].FaceValue} {allCards[i].Suit} is equal to {allCards[i + 1].FaceValue} {allCards[i + 1].Suit}?");
                if (allCards[i].Equals(allCards[i + 1], GameType))
                {

                    playerPos = random.Next(0, 2);
                    Console.WriteLine($"Yes player {Players[playerPos].Name} takes {(i + 1) - lastSnapPos}");

                    Players[playerPos].TakeCards(allCards.Skip(lastSnapPos + 1).Take((i + 1) - lastSnapPos).ToList());
                    lastSnapPos = i + 1;

                }
            }
        }

        private void PrintWinner()
        {
            if (Players[0].Cards.Count == Players[1].Cards.Count)
            {
                Console.WriteLine($"Draw {Players[0].Cards.Count}-{Players[1].Cards.Count}");
            }
            else
                if (Players[0].Cards.Count > Players[1].Cards.Count)
            {
                Console.WriteLine($"{Players[0].Name} wins!!! {Players[0].Cards.Count}-{Players[1].Cards.Count}");
            }
            else
            {
                Console.WriteLine($"{Players[1].Name} wins!!! {Players[0].Cards.Count}-{Players[1].Cards.Count}");
            }
        }

        private void JoinAllPacks()
        {
            foreach (Pack pack in Packs)
            {
                allCards.AddRange(pack.Cards);
            }

            allCards.Shuffle();
        }
    }
}
