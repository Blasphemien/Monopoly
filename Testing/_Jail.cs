using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace MolopolyGame.Testing
{
    [TestFixture]
    public class _Jail
    {
        
        static Player myPlayer = new Player("Keil");
        static Jail myJail = new Jail(myPlayer);
        [Test]
        public void TestJail()
        {

            string expected = "You {0} are in jail!" ;
            string testToString = myJail.ToString();

            Assert.AreEqual(expected, testToString);
        }
    }
}
