using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace MolopolyGame.Testing
{
    [TestFixture]
    public class _Card
    {
        Card Card = new Card();
        [Test]
        public void TestCommunityCard()
        {                        
            string myCard = Card.GetCommunityCard();
            string testCard;

            for (int i = 0; i <= 15; i++)
            {
                if (myCard == Card.communityChestCardArray[i])
                {
                    testCard = myCard;
                    Assert.AreEqual(myCard, testCard);
                }
            }                            
        }

        [Test]
        public void TestChanceCard()
        {
            string myCard = Card.GetChanceCard();
            string testCard;

            for (int i = 0; i <= 15; i++ )
            {
                if(myCard == Card.chanceCardArray[i])
                {
                    testCard = myCard;
                    Assert.AreEqual(myCard, testCard);
                }
            }             
        }

        [Test]
        public void TestGetCard()
        {
            string myDeck = Card.GetCard();
            string testDeck;

            if(myDeck == Card.GetCommunityCard())
            {
                testDeck = myDeck;
                Assert.AreEqual(myDeck, testDeck);
            }

            if(myDeck == Card.GetChanceCard())
            {
                testDeck = myDeck;
                Assert.AreEqual(myDeck, testDeck);
            }
        }
    }
}
