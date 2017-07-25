using System.Collections.Generic;
using NUnit.Framework;
using SuitsMe.Core.Models;

namespace SuitsMe.Core.Tests.Models
{
    [TestFixture]
    class DeckTests
    {
        [Test]
        public static void ShouldReturnDeckGivenDeck() => Assert.IsInstanceOf<Deck>(new Deck(new List<Card>()).GetOrderedDeck());
    }
}
