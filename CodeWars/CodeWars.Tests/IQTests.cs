using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars.Tests
{
    [TestClass]
    public class IQTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, IQ.Test("2 4 7 8 10"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(1, IQ.Test("1 2 2"));
        }
    }
}
