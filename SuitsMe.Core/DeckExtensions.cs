using System;
using System.Collections.Generic;
using System.Linq;

namespace SuitsMe.Core
{
    public static class DeckExtensions
    {
        public static Deck GetOrderedCopy(this Deck deck)
        {
            return new Deck(deck.Cards.OrderBy(card => card.Suit).ThenBy(card => card.Face).ToList());
        }

        public static Deck GetShuffledCopy(this Deck deck)
        {
            return new Deck(deck.Cards.OrderBy(c => Guid.NewGuid()).ToList());
        }
    }
}