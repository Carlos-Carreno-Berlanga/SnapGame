using System.Collections.Generic;

namespace SnapGame
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
            Cards = new List<Card>();
        }
        public string Name { get; private set; }
        public List<Card> Cards { get; private set; }

        public void TakeCards(IList<Card> cardsToTake)
        {
            Cards.AddRange(cardsToTake);
        }


    }
}
