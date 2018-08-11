using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars.Tests
{
    [TestClass]
    public class NumberTriangleTest
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(1, NumberTriangle.rowSumNumbers(1));
            Assert.AreEqual(74088, NumberTriangle.rowSumNumbers(42));
        }

        [TestMethod]
        public void Test2()
        {
            Random rnd = new Random();

            for (long i = 0; i < 50; i++)
            {
                long n = rnd.Next(500) + 1;
                Assert.AreEqual(n * n * n, NumberTriangle.rowSumNumbers(n));
            }
        }
    }
}
