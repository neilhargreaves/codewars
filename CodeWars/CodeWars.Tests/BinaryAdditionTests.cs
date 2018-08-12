using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CodeWars.Tests
{
    [TestClass]
    public class BinaryAdditionTests
    {
        [TestMethod]
        public void TestExample()
        {
            Assert.AreEqual("11", BinaryAddition.AddBinary(1, 2), "Should return \"11\" for 1 + 2");
        }

        [TestMethod]
        public void Test_One_Two()
        {
            Assert.AreEqual("11", BinaryAddition.AddBinary(1, 2), "Should return \"11\" for 1 + 2");
        }

        [TestMethod]
        public void Test_FiftyOne_Twelve()
        {
            Assert.AreEqual("111111", BinaryAddition.AddBinary(51, 12), "Should return \"111111\" for 51 + 12");
        }

        [TestMethod]
        public void Test_Hundred_Zero()
        {
            Assert.AreEqual("1100100", BinaryAddition.AddBinary(100, 0), "Should return \"1100100\" for 100 + 0");
        }

        [TestMethod]
        public void Random()
        {
            var rnd = new Random();

            for (int i = 0; i < 100; ++i)
            {
                int a = rnd.Next(0, 100000);
                int b = rnd.Next(0, 100000);

                string expected = Convert.ToString(a + b, 2);

                Assert.AreEqual(expected, BinaryAddition.AddBinary(a, b), $"Should return \"{expected}\" for {a} + {b}");
            };
        }
    }
}
