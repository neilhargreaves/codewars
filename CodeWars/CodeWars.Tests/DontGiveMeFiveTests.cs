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

        [TestMethod]
        public void RandomTests()
        {
            var rand = new Random();

            Func<int, int, int> myDontGiveMeFive = delegate (int start, int end)
            {
                var count = 0;
                for (int i = start; i <= end; i++)
                {
                    if (!i.ToString().Contains("5"))
                    {
                        count++;
                    }
                }
                return count;
            };

            for (var i = 0; i < 30; i++)
            {
                var start = rand.Next(-50, 60);
                var end = rand.Next(start + 1, 80);

                Assert.AreEqual(myDontGiveMeFive(start, end), DontGiveMeFive.NoFives(start, end));
            }
        }
    }
}