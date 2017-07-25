using System.Collections.Generic;
using NUnit.Framework;
using SuitsMe.Core.Models;

namespace SuitsMe.Core.Tests.Models
{
    [TestFixture]
    class DeckTests
    {
        [Test]
        public static void OrderDeckShouldReturnDeckGivenDeck() => Assert.IsInstanceOf<Deck>(new Deck(new List<Card>()).GetOrderedDeck());

        [Test]
        public static void OrderDeckShouldReturnNewInstanceOfDeck()
        {
            var oldDeck = new Deck(new List<Card>());
            var newDeck = oldDeck.GetOrderedDeck();
            Assert.AreNotSame(oldDeck, newDeck);
        }

        [Test]
        public static void OrderDeckShouldReturnDeckContainingAllCardsOfOldDeck()
        {
            var aceOfSpades = new Card(Suit.Spade, Face.Ace);
            var queenOfHearts = new Card(Suit.Heart, Face.Queen);
            var cards = new List<Card>
            {
                aceOfSpades,
                queenOfHearts
            };
            var oldDeck = new Deck(cards);
            var newDeck = oldDeck.GetOrderedDeck();
            // The Assert.Contains signature is a bit messy, IMO. I usually use FluentAssertions for this sort of thing
            Assert.IsTrue(newDeck.Cards.Contains(aceOfSpades) && newDeck.Cards.Contains(aceOfSpades), "New Deck Should Contain the Ace of Spades and Queen of Hearts!");
        }
    }
}
