using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars.Tests
{
    [TestClass]
    public class CinemaClerkTestMethods
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] peopleInLine = new int[] { 25, 25, 50, 50 };
            Assert.AreEqual("YES", CinemaClerk.Tickets(peopleInLine));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] peopleInLine = new int[] { 25, 100 };
            Assert.AreEqual("NO", CinemaClerk.Tickets(peopleInLine));
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 };
            Assert.AreEqual("YES", CinemaClerk.Tickets(peopleInLine));
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] peopleInLine = new int[] { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 };
            Assert.AreEqual("NO", CinemaClerk.Tickets(peopleInLine));
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] peopleInLine = new int[] { 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 };
            Assert.AreEqual("NO", CinemaClerk.Tickets(peopleInLine));
        }

        [TestMethod]
        public void TestMethod6()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 50, 100, 50 };
            Assert.AreEqual("YES", CinemaClerk.Tickets(peopleInLine));
        }

        [TestMethod]
        public void TestMethod7()
        {
            int[] peopleInLine = new int[] { 25, 25 };
            Assert.AreEqual("YES", CinemaClerk.Tickets(peopleInLine));
        }

        [TestMethod]
        public void TestMethod8()
        {
            int[] peopleInLine = new int[] { 50, 100, 100 };
            Assert.AreEqual("NO", CinemaClerk.Tickets(peopleInLine));
        }

        [TestMethod]
        public void TestMethod9()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 25, 25, 25, 50, 50, 50, 100, 100, 100, 100 };
            Assert.AreEqual("NO", CinemaClerk.Tickets(peopleInLine));
        }

        [TestMethod]
        public void TestMethod10()
        {
            int[] peopleInLine = new int[] { 25, 25, 50, 50, 100 };
            Assert.AreEqual("NO", CinemaClerk.Tickets(peopleInLine));
        }
        [TestMethod]
        public void TestMethod11()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 25, 100, 100 };
            Assert.AreEqual("NO", CinemaClerk.Tickets(peopleInLine));
        }
    }
}
