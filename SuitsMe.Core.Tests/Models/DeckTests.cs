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
    }
}
