using System;
using System.Collections.Generic;

namespace SnapGame
{
    public static class PackFactory
    {
        public static Pack CreatePack()
        {
            
            List<Card> cards = new List<Card>(52);
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {

                foreach (Face faceValue in Enum.GetValues(typeof(Face)))
                {
                    cards.Add(new Card(faceValue, suit));
                }
            }
            cards.Shuffle();
            Pack pack = new Pack(cards);
            return pack;

        }

        public static IEnumerable<Pack> CreatePacks(int numOfPacks)
        {
            for(int i = 0; i < numOfPacks; i++)
            {
                yield return CreatePack();
            }
        }



    }
}
