using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars.Tests
{
    [TestClass]
    public class DontGiveMeFiveTests
    {
        [TestMethod]
        public void ExampleTests()
        {
            Assert.AreEqual(8, DontGiveMeFive.NoFives(1, 9));
            Assert.AreEqual(12, DontGiveMeFive.NoFives(4, 17));
        }

        [TestMethod]
        public void MoreTests()
        {
            Assert.AreEqual(72, DontGiveMeFive.NoFives(1, 90));
            Assert.AreEqual(20, DontGiveMeFive.NoFives(-4, 17));
            Assert.AreEqual(38, DontGiveMeFive.NoFives(-4, 37));
            Assert.AreEqual(13, DontGiveMeFive.NoFives(-14, -1));
            Assert.AreEqual(1, DontGiveMeFive.NoFives(149, 151));
            Assert.AreEqual(9, DontGiveMeFive.NoFives(-14, -6));
        }
    }
}