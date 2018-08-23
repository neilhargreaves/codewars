using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars.Tests
{
    [TestClass]
    public class XbonacciSequenceTests
    {
        private XbonacciSequence xbonacciSequence = new XbonacciSequence();

        [TestMethod]
        public void Tests()
        {
            CollectionAssert.AreEqual(new double[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 }, 
                xbonacciSequence.Xbonacci(new double[] { 0, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 }, 
                xbonacciSequence.Xbonacci(new double[] { 1, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 0, 0, 0, 0, 1, 1, 2, 4, 8, 16 }, 
                xbonacciSequence.Xbonacci(new double[] { 0, 0, 0, 0, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 1, 0, 0, 0, 0, 0, 1, 2, 3, 6 }, 
                xbonacciSequence.Xbonacci(new double[] { 1, 0, 0, 0, 0, 0, 1 }, 10));
        }

        [TestMethod]
        public void BasicTests()
        {
            CollectionAssert.AreEqual(new double[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 }, xbonacciSequence.Xbonacci(new double[] { 0, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 }, xbonacciSequence.Xbonacci(new double[] { 1, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 0, 0, 0, 0, 1, 1, 2, 4, 8, 16 }, xbonacciSequence.Xbonacci(new double[] { 0, 0, 0, 0, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 1, 0, 0, 0, 0, 0, 1, 2, 3, 6 }, xbonacciSequence.Xbonacci(new double[] { 1, 0, 0, 0, 0, 0, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 2, 4, 8, 16, 32, 64, 128, 256 }, xbonacciSequence.Xbonacci(new double[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 20));
            CollectionAssert.AreEqual(new double[] { 0.5, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, xbonacciSequence.Xbonacci(new double[] { 0.5, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 10));
            CollectionAssert.AreEqual(new double[] { 0.5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.5, 0.5, 1, 2, 4, 8, 16, 32, 64, 128 }, xbonacciSequence.Xbonacci(new double[] { 0.5, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 20));
            CollectionAssert.AreEqual(new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, xbonacciSequence.Xbonacci(new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 20));
            CollectionAssert.AreEqual(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, xbonacciSequence.Xbonacci(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, 9));
            CollectionAssert.AreEqual(new double[] { }, xbonacciSequence.Xbonacci(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, 0));
        }

    }
}
