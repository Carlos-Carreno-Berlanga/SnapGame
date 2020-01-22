using System.Collections.Generic;

namespace SnapGame
{
    public class Pack
    {
        public Pack(IList<Card> cards)
        {
            Cards = cards;
        }

        public IList<Card> Cards { get; private set; }
    }
}
