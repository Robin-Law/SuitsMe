﻿namespace SuitsMe.Core
{
    //Per bridge rules (Ascending Alphabetical Order)
    //https://en.wikipedia.org/wiki/High_card_by_suit
    public enum Suit
    {
        Club,
        Diamond,
        Heart,
        Spade
    }

    public enum Face
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public class Card
    {
        public Card(Suit suit, Face face)
        {
            Face = face;
            Suit = suit;
        }

        public Suit Suit { get; }
        public Face Face { get; }
    }
}
