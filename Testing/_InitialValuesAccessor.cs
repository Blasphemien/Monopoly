using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace MolopolyGame.Testing
{
    [TestFixture]
    public class _InitialValuesAccessor
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(InitialValuesAccessor.getBankerStartingBalance(), 10000);
            Assert.AreEqual(InitialValuesAccessor.getPlayerStartingBalance(), 1500);
        }
    }
}
