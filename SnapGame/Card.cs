namespace SnapGame
{
    public class Card
    {
        public Card(Face faceValue, Suit suit)
        {
            FaceValue = faceValue;
            Suit = suit;
        }
        public Face FaceValue { get; private set; }
        public Suit Suit { get; set; }

        public bool Equals(Card card, GameType gameType)
        {
            if (gameType == GameType.AllMatch)
            {
                return card.FaceValue == this.FaceValue && card.Suit == this.Suit;
            }
            else
                if (gameType == GameType.FaceMatch)
            {
                return card.FaceValue == this.FaceValue;
            }
            return card.Suit == this.Suit;
        }

    }
}
